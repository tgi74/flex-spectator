namespace FlexSpectator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.resetAllBtn = new System.Windows.Forms.Button();
            this.lblTeamSize = new System.Windows.Forms.Label();
            this.txtTeamSize = new System.Windows.Forms.TextBox();
            this.lblResetReq = new System.Windows.Forms.Label();
            this.lblSpecial1 = new System.Windows.Forms.Label();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.lblLogs = new System.Windows.Forms.Label();
            this.tabs = new System.Windows.Forms.TabControl();
            this.txtSpecId = new System.Windows.Forms.TextBox();
            this.lblSpecId = new System.Windows.Forms.Label();
            this.btnSpecEdit = new System.Windows.Forms.Button();
            this.spectatorUpdate = new System.Windows.Forms.Timer(this.components);
            this.btnTopMost = new System.Windows.Forms.Button();
            this.btnSyncTime = new System.Windows.Forms.Button();
            this.lblTimeSync = new System.Windows.Forms.Label();
            this.btnResetClient = new System.Windows.Forms.Button();
            this.lblMode = new System.Windows.Forms.Label();
            this.btnModeEdit = new System.Windows.Forms.Button();
            this.comboMode = new System.Windows.Forms.ComboBox();
            this.txtClientCount = new System.Windows.Forms.TextBox();
            this.lblClientCount = new System.Windows.Forms.Label();
            this.btnBuffer = new System.Windows.Forms.Button();
            this.btnCalculation = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.trackDim = new System.Windows.Forms.TrackBar();
            this.lblDim = new System.Windows.Forms.Label();
            this.btnDimEdit = new System.Windows.Forms.Button();
            this.btnBeatmapEdit = new System.Windows.Forms.Button();
            this.lblBeatmap = new System.Windows.Forms.Label();
            this.txtBeatmap = new System.Windows.Forms.TextBox();
            this.btnClientApply = new System.Windows.Forms.Button();
            this.lblBeatmapId = new System.Windows.Forms.Label();
            this.txtBeatmapId = new System.Windows.Forms.TextBox();
            this.btnWakeUp = new System.Windows.Forms.Button();
            this.btnHelpMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackDim)).BeginInit();
            this.SuspendLayout();
            // 
            // resetAllBtn
            // 
            this.resetAllBtn.BackColor = System.Drawing.Color.Red;
            this.resetAllBtn.Location = new System.Drawing.Point(691, 12);
            this.resetAllBtn.Name = "resetAllBtn";
            this.resetAllBtn.Size = new System.Drawing.Size(81, 41);
            this.resetAllBtn.TabIndex = 0;
            this.resetAllBtn.Text = "Reset all";
            this.resetAllBtn.UseVisualStyleBackColor = false;
            this.resetAllBtn.Click += new System.EventHandler(this.ResetAllBtn_Click);
            // 
            // lblTeamSize
            // 
            this.lblTeamSize.AutoSize = true;
            this.lblTeamSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamSize.Location = new System.Drawing.Point(12, 9);
            this.lblTeamSize.Name = "lblTeamSize";
            this.lblTeamSize.Size = new System.Drawing.Size(89, 20);
            this.lblTeamSize.TabIndex = 1;
            this.lblTeamSize.Text = "Team size: ";
            // 
            // txtTeamSize
            // 
            this.txtTeamSize.Location = new System.Drawing.Point(116, 12);
            this.txtTeamSize.Name = "txtTeamSize";
            this.txtTeamSize.Size = new System.Drawing.Size(100, 20);
            this.txtTeamSize.TabIndex = 2;
            // 
            // lblResetReq
            // 
            this.lblResetReq.AutoSize = true;
            this.lblResetReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetReq.ForeColor = System.Drawing.Color.Red;
            this.lblResetReq.Location = new System.Drawing.Point(12, 539);
            this.lblResetReq.Name = "lblResetReq";
            this.lblResetReq.Size = new System.Drawing.Size(314, 20);
            this.lblResetReq.TabIndex = 3;
            this.lblResetReq.Text = "* \"Reset All\" is required to update this value";
            // 
            // lblSpecial1
            // 
            this.lblSpecial1.AutoSize = true;
            this.lblSpecial1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecial1.ForeColor = System.Drawing.Color.Red;
            this.lblSpecial1.Location = new System.Drawing.Point(95, 9);
            this.lblSpecial1.Name = "lblSpecial1";
            this.lblSpecial1.Size = new System.Drawing.Size(15, 20);
            this.lblSpecial1.TabIndex = 4;
            this.lblSpecial1.Text = "*";
            // 
            // txtLogs
            // 
            this.txtLogs.Location = new System.Drawing.Point(344, 350);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.Size = new System.Drawing.Size(440, 209);
            this.txtLogs.TabIndex = 5;
            this.txtLogs.TabStop = false;
            // 
            // lblLogs
            // 
            this.lblLogs.AutoSize = true;
            this.lblLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogs.Location = new System.Drawing.Point(340, 327);
            this.lblLogs.Name = "lblLogs";
            this.lblLogs.Size = new System.Drawing.Size(52, 20);
            this.lblLogs.TabIndex = 6;
            this.lblLogs.Text = "Logs: ";
            // 
            // tabs
            // 
            this.tabs.Location = new System.Drawing.Point(16, 64);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(756, 23);
            this.tabs.TabIndex = 7;
            // 
            // txtSpecId
            // 
            this.txtSpecId.Enabled = false;
            this.txtSpecId.Location = new System.Drawing.Point(146, 121);
            this.txtSpecId.Name = "txtSpecId";
            this.txtSpecId.Size = new System.Drawing.Size(173, 20);
            this.txtSpecId.TabIndex = 8;
            // 
            // lblSpecId
            // 
            this.lblSpecId.AutoSize = true;
            this.lblSpecId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecId.Location = new System.Drawing.Point(12, 119);
            this.lblSpecId.Name = "lblSpecId";
            this.lblSpecId.Size = new System.Drawing.Size(128, 20);
            this.lblSpecId.TabIndex = 9;
            this.lblSpecId.Text = "Spectating User:";
            // 
            // btnSpecEdit
            // 
            this.btnSpecEdit.Location = new System.Drawing.Point(325, 119);
            this.btnSpecEdit.Name = "btnSpecEdit";
            this.btnSpecEdit.Size = new System.Drawing.Size(75, 23);
            this.btnSpecEdit.TabIndex = 10;
            this.btnSpecEdit.Text = "Edit";
            this.btnSpecEdit.UseVisualStyleBackColor = true;
            this.btnSpecEdit.Click += new System.EventHandler(this.BtnSpecApply_Click);
            // 
            // spectatorUpdate
            // 
            this.spectatorUpdate.Enabled = true;
            this.spectatorUpdate.Interval = 33;
            this.spectatorUpdate.Tick += new System.EventHandler(this.SpectatorUpdate_Tick);
            // 
            // btnTopMost
            // 
            this.btnTopMost.Location = new System.Drawing.Point(604, 12);
            this.btnTopMost.Name = "btnTopMost";
            this.btnTopMost.Size = new System.Drawing.Size(81, 41);
            this.btnTopMost.TabIndex = 11;
            this.btnTopMost.Text = "Remove TopMost";
            this.btnTopMost.UseVisualStyleBackColor = true;
            this.btnTopMost.Click += new System.EventHandler(this.BtnTopMost_Click);
            // 
            // btnSyncTime
            // 
            this.btnSyncTime.Location = new System.Drawing.Point(97, 93);
            this.btnSyncTime.Name = "btnSyncTime";
            this.btnSyncTime.Size = new System.Drawing.Size(69, 23);
            this.btnSyncTime.TabIndex = 13;
            this.btnSyncTime.Text = "Sync Time";
            this.btnSyncTime.UseVisualStyleBackColor = true;
            this.btnSyncTime.Click += new System.EventHandler(this.BtnSyncTime_Click);
            // 
            // lblTimeSync
            // 
            this.lblTimeSync.AutoSize = true;
            this.lblTimeSync.Location = new System.Drawing.Point(601, 93);
            this.lblTimeSync.Name = "lblTimeSync";
            this.lblTimeSync.Size = new System.Drawing.Size(0, 13);
            this.lblTimeSync.TabIndex = 14;
            // 
            // btnResetClient
            // 
            this.btnResetClient.Location = new System.Drawing.Point(16, 93);
            this.btnResetClient.Name = "btnResetClient";
            this.btnResetClient.Size = new System.Drawing.Size(75, 23);
            this.btnResetClient.TabIndex = 15;
            this.btnResetClient.Text = "Reset";
            this.btnResetClient.UseVisualStyleBackColor = true;
            this.btnResetClient.Click += new System.EventHandler(this.BtnResetClient_Click);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(12, 191);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(180, 20);
            this.lblMode.TabIndex = 16;
            this.lblMode.Text = "Change mode forcefully:";
            // 
            // btnModeEdit
            // 
            this.btnModeEdit.Location = new System.Drawing.Point(325, 191);
            this.btnModeEdit.Name = "btnModeEdit";
            this.btnModeEdit.Size = new System.Drawing.Size(75, 23);
            this.btnModeEdit.TabIndex = 17;
            this.btnModeEdit.Text = "Edit";
            this.btnModeEdit.UseVisualStyleBackColor = true;
            this.btnModeEdit.Click += new System.EventHandler(this.BtnModeEdit_Click);
            // 
            // comboMode
            // 
            this.comboMode.Enabled = false;
            this.comboMode.FormattingEnabled = true;
            this.comboMode.Location = new System.Drawing.Point(198, 193);
            this.comboMode.Name = "comboMode";
            this.comboMode.Size = new System.Drawing.Size(121, 21);
            this.comboMode.TabIndex = 18;
            // 
            // txtClientCount
            // 
            this.txtClientCount.Location = new System.Drawing.Point(325, 12);
            this.txtClientCount.Name = "txtClientCount";
            this.txtClientCount.Size = new System.Drawing.Size(75, 20);
            this.txtClientCount.TabIndex = 20;
            // 
            // lblClientCount
            // 
            this.lblClientCount.AutoSize = true;
            this.lblClientCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCount.Location = new System.Drawing.Point(222, 9);
            this.lblClientCount.Name = "lblClientCount";
            this.lblClientCount.Size = new System.Drawing.Size(101, 20);
            this.lblClientCount.TabIndex = 19;
            this.lblClientCount.Text = "Client count: ";
            // 
            // btnBuffer
            // 
            this.btnBuffer.Location = new System.Drawing.Point(325, 93);
            this.btnBuffer.Name = "btnBuffer";
            this.btnBuffer.Size = new System.Drawing.Size(75, 23);
            this.btnBuffer.TabIndex = 22;
            this.btnBuffer.Text = "Buffering";
            this.btnBuffer.UseVisualStyleBackColor = true;
            this.btnBuffer.Click += new System.EventHandler(this.BtnBuffer_Click);
            // 
            // btnCalculation
            // 
            this.btnCalculation.Location = new System.Drawing.Point(406, 93);
            this.btnCalculation.Name = "btnCalculation";
            this.btnCalculation.Size = new System.Drawing.Size(75, 23);
            this.btnCalculation.TabIndex = 23;
            this.btnCalculation.Text = "Skip calc";
            this.btnCalculation.UseVisualStyleBackColor = true;
            this.btnCalculation.Click += new System.EventHandler(this.BtnCalculation_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(248, 93);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(71, 23);
            this.btnPlay.TabIndex = 24;
            this.btnPlay.Text = "Play music";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // trackDim
            // 
            this.trackDim.Enabled = false;
            this.trackDim.LargeChange = 10;
            this.trackDim.Location = new System.Drawing.Point(103, 220);
            this.trackDim.Maximum = 100;
            this.trackDim.Name = "trackDim";
            this.trackDim.Size = new System.Drawing.Size(216, 45);
            this.trackDim.TabIndex = 25;
            this.trackDim.Value = 100;
            // 
            // lblDim
            // 
            this.lblDim.AutoSize = true;
            this.lblDim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDim.Location = new System.Drawing.Point(12, 220);
            this.lblDim.Name = "lblDim";
            this.lblDim.Size = new System.Drawing.Size(85, 20);
            this.lblDim.TabIndex = 26;
            this.lblDim.Text = "Client Dim:";
            // 
            // btnDimEdit
            // 
            this.btnDimEdit.Location = new System.Drawing.Point(325, 220);
            this.btnDimEdit.Name = "btnDimEdit";
            this.btnDimEdit.Size = new System.Drawing.Size(75, 23);
            this.btnDimEdit.TabIndex = 27;
            this.btnDimEdit.Text = "Edit";
            this.btnDimEdit.UseVisualStyleBackColor = true;
            this.btnDimEdit.Click += new System.EventHandler(this.BtnDimEdit_Click);
            // 
            // btnBeatmapEdit
            // 
            this.btnBeatmapEdit.Location = new System.Drawing.Point(325, 153);
            this.btnBeatmapEdit.Name = "btnBeatmapEdit";
            this.btnBeatmapEdit.Size = new System.Drawing.Size(75, 23);
            this.btnBeatmapEdit.TabIndex = 30;
            this.btnBeatmapEdit.Text = "Edit";
            this.btnBeatmapEdit.UseVisualStyleBackColor = true;
            this.btnBeatmapEdit.Click += new System.EventHandler(this.BtnBeatmapEdit_Click);
            // 
            // lblBeatmap
            // 
            this.lblBeatmap.AutoSize = true;
            this.lblBeatmap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeatmap.Location = new System.Drawing.Point(12, 154);
            this.lblBeatmap.Name = "lblBeatmap";
            this.lblBeatmap.Size = new System.Drawing.Size(154, 20);
            this.lblBeatmap.TabIndex = 29;
            this.lblBeatmap.Text = "Beatmap checksum:";
            // 
            // txtBeatmap
            // 
            this.txtBeatmap.Enabled = false;
            this.txtBeatmap.Location = new System.Drawing.Point(174, 156);
            this.txtBeatmap.Name = "txtBeatmap";
            this.txtBeatmap.Size = new System.Drawing.Size(145, 20);
            this.txtBeatmap.TabIndex = 28;
            // 
            // btnClientApply
            // 
            this.btnClientApply.Location = new System.Drawing.Point(406, 10);
            this.btnClientApply.Name = "btnClientApply";
            this.btnClientApply.Size = new System.Drawing.Size(75, 23);
            this.btnClientApply.TabIndex = 31;
            this.btnClientApply.Text = "Apply";
            this.btnClientApply.UseVisualStyleBackColor = true;
            this.btnClientApply.Click += new System.EventHandler(this.BtnClientApply_Click);
            // 
            // lblBeatmapId
            // 
            this.lblBeatmapId.AutoSize = true;
            this.lblBeatmapId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeatmapId.Location = new System.Drawing.Point(12, 255);
            this.lblBeatmapId.Name = "lblBeatmapId";
            this.lblBeatmapId.Size = new System.Drawing.Size(98, 20);
            this.lblBeatmapId.TabIndex = 33;
            this.lblBeatmapId.Text = "Beatmap id: ";
            // 
            // txtBeatmapId
            // 
            this.txtBeatmapId.Enabled = false;
            this.txtBeatmapId.Location = new System.Drawing.Point(116, 257);
            this.txtBeatmapId.Name = "txtBeatmapId";
            this.txtBeatmapId.Size = new System.Drawing.Size(203, 20);
            this.txtBeatmapId.TabIndex = 32;
            // 
            // btnWakeUp
            // 
            this.btnWakeUp.Location = new System.Drawing.Point(174, 93);
            this.btnWakeUp.Name = "btnWakeUp";
            this.btnWakeUp.Size = new System.Drawing.Size(68, 23);
            this.btnWakeUp.TabIndex = 34;
            this.btnWakeUp.Text = "Wake up";
            this.btnWakeUp.UseVisualStyleBackColor = true;
            this.btnWakeUp.Click += new System.EventHandler(this.BtnWakeUp_Click);
            // 
            // btnHelpMenu
            // 
            this.btnHelpMenu.Location = new System.Drawing.Point(16, 291);
            this.btnHelpMenu.Name = "btnHelpMenu";
            this.btnHelpMenu.Size = new System.Drawing.Size(75, 23);
            this.btnHelpMenu.TabIndex = 35;
            this.btnHelpMenu.Text = "Sync Menu";
            this.btnHelpMenu.UseVisualStyleBackColor = true;
            this.btnHelpMenu.Click += new System.EventHandler(this.BtnHelpMenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnHelpMenu);
            this.Controls.Add(this.btnWakeUp);
            this.Controls.Add(this.lblBeatmapId);
            this.Controls.Add(this.txtBeatmapId);
            this.Controls.Add(this.btnClientApply);
            this.Controls.Add(this.btnBeatmapEdit);
            this.Controls.Add(this.lblBeatmap);
            this.Controls.Add(this.txtBeatmap);
            this.Controls.Add(this.btnDimEdit);
            this.Controls.Add(this.lblDim);
            this.Controls.Add(this.trackDim);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnCalculation);
            this.Controls.Add(this.btnBuffer);
            this.Controls.Add(this.txtClientCount);
            this.Controls.Add(this.lblClientCount);
            this.Controls.Add(this.comboMode);
            this.Controls.Add(this.btnModeEdit);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.btnResetClient);
            this.Controls.Add(this.lblTimeSync);
            this.Controls.Add(this.btnSyncTime);
            this.Controls.Add(this.btnTopMost);
            this.Controls.Add(this.btnSpecEdit);
            this.Controls.Add(this.lblSpecId);
            this.Controls.Add(this.txtSpecId);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.lblLogs);
            this.Controls.Add(this.txtLogs);
            this.Controls.Add(this.lblSpecial1);
            this.Controls.Add(this.lblResetReq);
            this.Controls.Add(this.txtTeamSize);
            this.Controls.Add(this.lblTeamSize);
            this.Controls.Add(this.resetAllBtn);
            this.Name = "MainForm";
            this.Text = "Flex Spectator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackDim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetAllBtn;
        private System.Windows.Forms.Label lblTeamSize;
        private System.Windows.Forms.TextBox txtTeamSize;
        private System.Windows.Forms.Label lblResetReq;
        private System.Windows.Forms.Label lblSpecial1;
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.Label lblLogs;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TextBox txtSpecId;
        private System.Windows.Forms.Label lblSpecId;
        private System.Windows.Forms.Button btnSpecEdit;
        private System.Windows.Forms.Timer spectatorUpdate;
        private System.Windows.Forms.Button btnTopMost;
        private System.Windows.Forms.Button btnSyncTime;
        private System.Windows.Forms.Label lblTimeSync;
        private System.Windows.Forms.Button btnResetClient;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Button btnModeEdit;
        private System.Windows.Forms.ComboBox comboMode;
        private System.Windows.Forms.TextBox txtClientCount;
        private System.Windows.Forms.Label lblClientCount;
        private System.Windows.Forms.Button btnBuffer;
        private System.Windows.Forms.Button btnCalculation;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TrackBar trackDim;
        private System.Windows.Forms.Label lblDim;
        private System.Windows.Forms.Button btnDimEdit;
        private System.Windows.Forms.Button btnBeatmapEdit;
        private System.Windows.Forms.Label lblBeatmap;
        private System.Windows.Forms.TextBox txtBeatmap;
        private System.Windows.Forms.Button btnClientApply;
        private System.Windows.Forms.Label lblBeatmapId;
        private System.Windows.Forms.TextBox txtBeatmapId;
        private System.Windows.Forms.Button btnWakeUp;
        private System.Windows.Forms.Button btnHelpMenu;
    }
}

