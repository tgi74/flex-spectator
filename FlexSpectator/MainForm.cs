using FlexSpectatorApi;
using System.Windows.Forms;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using osu;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace FlexSpectator
{
    internal partial class MainForm : Form
    {
        private string path;
        private OsuSpectatorManager manager;

        public MainForm(string path)
        {
            this.path = Directory.GetParent(path).FullName;
            InitializeComponent();
            UpdateTabs();
            comboMode.Items.AddRange(Enum.GetNames(typeof(OsuModes)));

            FlexLogger.RegisterLogCallback(ReceiveLog);
        }

        /// <summary>
        /// Execute this action on this <see cref="MainForm"/>'s Thread
        /// </summary>
        /// <param name="action"></param>
        private void Execute(Action action)
        {
            if (IsDisposed)
                return;

            try
            {
                Invoke((MethodInvoker)(() => action.Invoke()));
            }
            catch(Exception ex)
            {
                Console.WriteLine("Execute is not capable of calling Invoke...");
                Console.WriteLine(ex);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            manager = new OsuSpectatorManager(path);
            manager.OnConnectionJoin += Manager_OnConnectionUpdate;
            manager.OnConnectionQuit += Manager_OnConnectionUpdate;
            txtTeamSize.Text = manager.TeamSize.ToString();
            txtClientCount.Text = manager.ClientCount.ToString();
        }

        private void Manager_OnConnectionUpdate(object sender, EventArgs e)
        {
            RemoveTopMost();
            Execute(UpdateTabs);
        }

        private void UpdateTabs()
        {
            tabs.TabPages.Clear();
            tabs.TabPages.Add("-1", "All");

            if (manager == null)
                return;

            foreach(var c in manager.GetClients)
                tabs.TabPages.Add($"{c.ClientId}", $"Spectator {c.ClientId}");
        }

        private void ReceiveLog(string s)
        {
            Execute(() =>
            {
                if (txtLogs.IsDisposed)
                    return;

                try
                {
                    txtLogs.AppendText(s + Environment.NewLine);
                }
                catch
                {
                    Console.WriteLine("Could not print logs, Please see the console!");
                }
            });
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            manager.Dispose();
        }

        public int SelectedSpectator => tabs.SelectedTab == null ? -2 : int.Parse(tabs.SelectedTab.Name);
        public OsuSpectatorConnection Spectator => SelectedSpectator <= -1 ? null : manager.GetClient(SelectedSpectator);
        public List<OsuSpectatorConnection> Spectators => SelectedSpectator <= -1 ? manager.GetClients : new List<OsuSpectatorConnection> { Spectator };
        public OsuSpectatorConnection MasterSpectator => manager.GetClient(0);

        private void SpectatorUpdate_Tick(object sender, EventArgs e)
        {
            OsuSpectatorConnection s = Spectator ?? MasterSpectator;
            if (s == null)
                return;

            if (!txtSpecId.Enabled)
                txtSpecId.Text = s.SpectatingId.ToString();
            if (!comboMode.Enabled)
                comboMode.SelectedIndex = (int)s.Mode;
            if (!trackDim.Enabled)
                trackDim.Value = s.DimLevel;
            if (!txtBeatmap.Enabled)
                txtBeatmap.Text = s.Beatmap;
            txtBeatmapId.Text = s.Data.BeatmapId.ToString();
            SetButtonOk(btnCalculation, s.Data.SkipCalculations);
            SetButtonOk(btnBuffer, s.Data.Buffering);
            SetButtonOk(btnPlay, s.Data.AudioPlaying);

            string timesynctext = "";
            int time = MasterSpectator?.MenuTime ?? -1;
            foreach (var c in manager.GetClients)
                timesynctext += $"Spectator {c.ClientId}: {c.MenuTime - time}ms{Environment.NewLine}";
            lblTimeSync.Text = timesynctext;
        }

        private void ResetAllBtn_Click(object sender, EventArgs e)
        {
            manager.TeamSize = int.Parse(txtTeamSize.Text);
            manager.ClientCount = int.Parse(txtClientCount.Text);

            manager.RestartAllAsync().ContinueWith((t) => Log($"Full reset terminated with status {t.Status}"));
        }

        private void BtnSpecApply_Click(object sender, EventArgs e)
        {
            Log($"Updating spectator on client {SelectedSpectator}");
            if (ToggleIsEditable(txtSpecId))
                return;

            foreach (var s in Spectators)
                s.SpectatingId = int.Parse(txtSpecId.Text);
        }

        private void BtnTopMost_Click(object sender, EventArgs e)
        {
            RemoveTopMost();
        }

        [DllImport("user32.dll")]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private void RemoveTopMost()
        {
            Log("NoTopMost requested");
            Task.Run(() =>
            {
                // -2: NOTOPMOST
                foreach (var pc in Process.GetProcessesByName("osu!"))
                    SetWindowPos(pc.MainWindowHandle, new IntPtr(-2), 0, 0, 0, 0, 0x0001 | 0x0002 | 0x0040);
            });
        }

        private void BtnSyncTime_Click(object sender, EventArgs e)
        {
            Log($"Syncing time on client {SelectedSpectator}");
            if (MasterSpectator == null)
                return;

            int mastertime = MasterSpectator.Data.MenuTime;
            foreach (var s in Spectators)
                Task.Run(() => s.MenuTime = mastertime);
        }

        private void BtnResetClient_Click(object sender, EventArgs e)
        {
            Log($"Reseting client {SelectedSpectator}");

            foreach (var s in Spectators)
                manager.RestartAsync(s.ClientId).ContinueWith((t) => Log($"Restart of client {s.ClientId} terminated with status {t.Status}"));
        }

        private void BtnModeEdit_Click(object sender, EventArgs e)
        {
            Log($"Updating Mode on client {SelectedSpectator}");
            if (ToggleIsEditable(comboMode))
                return;

            foreach (var s in Spectators)
                s.Mode = (OsuModes)comboMode.SelectedIndex;
        }

        private void BtnDimEdit_Click(object sender, EventArgs e)
        {
            Log($"Updating Dim on client {SelectedSpectator}");
            if (ToggleIsEditable(trackDim))
                return;

            foreach (var s in Spectators)
                s.DimLevel = trackDim.Value;
        }

        private void BtnBeatmapEdit_Click(object sender, EventArgs e)
        {
            Log($"Updating Beatmap on client {SelectedSpectator}");
            if (ToggleIsEditable(txtBeatmap))
                return;

            foreach (var s in Spectators)
                s.Beatmap = txtBeatmap.Text;
        }

        private void BtnBuffer_Click(object sender, EventArgs e)
        {
            Log($"Toggle Buffer on client {SelectedSpectator}");
            foreach (var c in Spectators)
                c.Buffering = !c.Buffering;
        }

        private void BtnCalculation_Click(object sender, EventArgs e)
        {
            Log($"Toggle Calculation-skip on client {SelectedSpectator}");
            foreach (var c in Spectators)
                c.SkipCalculations = !c.SkipCalculations;
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Log($"Play Audio on client {SelectedSpectator}");
            foreach (var c in Spectators)
                c.PlayAudio();
        }

        private void BtnWakeUp_Click(object sender, EventArgs e)
        {
            Log($"Wake Up on client {SelectedSpectator}");
            foreach (var c in Spectators)
                c.WakeUp();
        }

        private void BtnClientApply_Click(object sender, EventArgs e)
        {
            manager.ClientCount = int.Parse(txtClientCount.Text);

            manager.StartMissingAsync().ContinueWith((t) => Log($"Start of missing clients terminated with status {t.Status}"));
        }

        private void BtnHelpMenu_Click(object sender, EventArgs e)
        {
            Log($"[Help] Syncing menu on client {SelectedSpectator}");
            if (MasterSpectator == null)
                return;

            int mastertime = MasterSpectator.Data.MenuTime;
            string masterbeatmap = MasterSpectator.Beatmap;
            foreach (var s in Spectators)
            {
                Task.Run(() =>
                {
                    s.Beatmap = masterbeatmap;
                    s.PlayAudio();
                    s.MenuTime = mastertime;
                });
            }
        }

        private bool ToggleIsEditable(Control c)
        {
            Log($"{c.Name} {(!c.Enabled ? "can" : "can't")} be edited");
            return c.Enabled = !c.Enabled;
        }

        private void SetButtonOk(Control c, bool ok)
        {
            c.BackColor = ok ? Color.Green : Color.Red;
        }

        public void Log(object o)
        {
            FlexLogger.Log($"[View] {o}");
        }
    }
}