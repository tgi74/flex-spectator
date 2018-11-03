using FlexSpectatorApi;
using System;
using System.Windows.Forms;

namespace FlexSpectator
{
    internal static class Program
    {
        private static TournamentConfig config;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            config = new TournamentConfig("flex.cfg");
            string osuPath = config.GetOrDef("OsuPath", string.Empty);

            // Select a path to an osu! executable
            if (osuPath == string.Empty)
            {
                MessageBox.Show("You have to select a path to the osu!.exe which will be used to start the clients\n\n" +
                    "It is recommanded to not use your default installation", "Information");
                using (var o = new OpenFileDialog())
                {
                    o.Filter = "osu! executable|osu!.exe";
                    var res = o.ShowDialog();
                    // If no osu!.exe was selected, close
                    if (res != DialogResult.OK)
                        return;
                    osuPath = o.FileName;
                }

                config.Set("OsuPath", osuPath);
                config.SaveAsync().ContinueWith((t) => FlexLogger.Log($"Configuration save terminated with status {t.Status}"));
            }

            Application.Run(new MainForm(osuPath));
        }
    }
}
