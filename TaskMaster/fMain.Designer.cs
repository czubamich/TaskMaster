namespace TaskMaster
{
    partial class fMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button btnNewTask;
            this.pgbTime = new System.Windows.Forms.ProgressBar();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmSetBreakTime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSetTargetTime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSetCurrentProgress = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmResetTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmResetTimerConfirm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmResetTimerCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.flpTaskList = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnBreak = new System.Windows.Forms.Button();
            this.btnPauseResume = new System.Windows.Forms.Button();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.tltTime = new System.Windows.Forms.ToolTip(this.components);
            btnNewTask = new System.Windows.Forms.Button();
            this.cmsMenu.SuspendLayout();
            this.flpTaskList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewTask
            // 
            btnNewTask.Location = new System.Drawing.Point(3, 3);
            btnNewTask.Name = "btnNewTask";
            btnNewTask.Size = new System.Drawing.Size(76, 23);
            btnNewTask.TabIndex = 1;
            btnNewTask.Tag = "btnNewTask";
            btnNewTask.Text = "New Task";
            btnNewTask.UseVisualStyleBackColor = true;
            btnNewTask.Click += new System.EventHandler(this.btnNewTask_Click);
            // 
            // pgbTime
            // 
            this.pgbTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbTime.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pgbTime.ContextMenuStrip = this.cmsMenu;
            this.pgbTime.Location = new System.Drawing.Point(4, 244);
            this.pgbTime.MarqueeAnimationSpeed = 10;
            this.pgbTime.Maximum = 1000;
            this.pgbTime.Name = "pgbTime";
            this.pgbTime.Size = new System.Drawing.Size(381, 32);
            this.pgbTime.Step = 1;
            this.pgbTime.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbTime.TabIndex = 4;
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSetBreakTime,
            this.tsmSetTargetTime,
            this.tsmSetCurrentProgress,
            this.tsmResetTimer});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(180, 92);
            // 
            // tsmSetBreakTime
            // 
            this.tsmSetBreakTime.Name = "tsmSetBreakTime";
            this.tsmSetBreakTime.Size = new System.Drawing.Size(179, 22);
            this.tsmSetBreakTime.Text = "Set break duration";
            this.tsmSetBreakTime.Click += new System.EventHandler(this.tsmSetTime_Click);
            // 
            // tsmSetTargetTime
            // 
            this.tsmSetTargetTime.Name = "tsmSetTargetTime";
            this.tsmSetTargetTime.Size = new System.Drawing.Size(179, 22);
            this.tsmSetTargetTime.Text = "Set target duration";
            this.tsmSetTargetTime.Click += new System.EventHandler(this.tsmSetTime_Click);
            // 
            // tsmSetCurrentProgress
            // 
            this.tsmSetCurrentProgress.Name = "tsmSetCurrentProgress";
            this.tsmSetCurrentProgress.Size = new System.Drawing.Size(179, 22);
            this.tsmSetCurrentProgress.Text = "Set current progress";
            this.tsmSetCurrentProgress.Click += new System.EventHandler(this.tsmSetTime_Click);
            // 
            // tsmResetTimer
            // 
            this.tsmResetTimer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmResetTimerConfirm,
            this.tsmResetTimerCancel});
            this.tsmResetTimer.Name = "tsmResetTimer";
            this.tsmResetTimer.Size = new System.Drawing.Size(179, 22);
            this.tsmResetTimer.Text = "Reset the timer";
            // 
            // tsmResetTimerConfirm
            // 
            this.tsmResetTimerConfirm.Name = "tsmResetTimerConfirm";
            this.tsmResetTimerConfirm.Size = new System.Drawing.Size(118, 22);
            this.tsmResetTimerConfirm.Text = "Confirm";
            this.tsmResetTimerConfirm.Click += new System.EventHandler(this.tsmResetTimer_Click);
            // 
            // tsmResetTimerCancel
            // 
            this.tsmResetTimerCancel.Name = "tsmResetTimerCancel";
            this.tsmResetTimerCancel.Size = new System.Drawing.Size(118, 22);
            this.tsmResetTimerCancel.Text = "Cancel";
            // 
            // flpTaskList
            // 
            this.flpTaskList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpTaskList.AutoScroll = true;
            this.flpTaskList.AutoScrollMinSize = new System.Drawing.Size(-1, 0);
            this.flpTaskList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpTaskList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpTaskList.Controls.Add(btnNewTask);
            this.flpTaskList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpTaskList.Location = new System.Drawing.Point(4, 12);
            this.flpTaskList.Name = "flpTaskList";
            this.flpTaskList.Size = new System.Drawing.Size(454, 228);
            this.flpTaskList.TabIndex = 6;
            this.flpTaskList.WrapContents = false;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.BackColor = System.Drawing.Color.White;
            this.lblTime.ContextMenuStrip = this.cmsMenu;
            this.lblTime.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)), true);
            this.lblTime.Location = new System.Drawing.Point(311, 249);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(69, 22);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "00:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBreak
            // 
            this.btnBreak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBreak.BackgroundImage = global::TaskMaster.Properties.Resources.clock;
            this.btnBreak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBreak.ContextMenuStrip = this.cmsMenu;
            this.btnBreak.FlatAppearance.BorderSize = 0;
            this.btnBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBreak.Location = new System.Drawing.Point(391, 244);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(32, 32);
            this.btnBreak.TabIndex = 3;
            this.btnBreak.UseVisualStyleBackColor = true;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // btnPauseResume
            // 
            this.btnPauseResume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPauseResume.BackgroundImage = global::TaskMaster.Properties.Resources.play;
            this.btnPauseResume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPauseResume.ContextMenuStrip = this.cmsMenu;
            this.btnPauseResume.FlatAppearance.BorderSize = 0;
            this.btnPauseResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPauseResume.Location = new System.Drawing.Point(429, 244);
            this.btnPauseResume.Name = "btnPauseResume";
            this.btnPauseResume.Size = new System.Drawing.Size(32, 32);
            this.btnPauseResume.TabIndex = 1;
            this.btnPauseResume.UseVisualStyleBackColor = true;
            this.btnPauseResume.Click += new System.EventHandler(this.btnPauseResume_Click);
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Enabled = true;
            this.tmrUpdate.Interval = 500;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.flpTaskList);
            this.Controls.Add(this.pgbTime);
            this.Controls.Add(this.btnBreak);
            this.Controls.Add(this.btnPauseResume);
            this.MinimumSize = new System.Drawing.Size(240, 180);
            this.Name = "fMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Master";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.Shown += new System.EventHandler(this.fMain_Shown);
            this.SizeChanged += new System.EventHandler(this.fMain_SizeChanged);
            this.cmsMenu.ResumeLayout(false);
            this.flpTaskList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.Button btnPauseResume;
        private System.Windows.Forms.ProgressBar pgbTime;
        private System.Windows.Forms.FlowLayoutPanel flpTaskList;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmResetTimer;
        private System.Windows.Forms.ToolStripMenuItem tsmSetBreakTime;
        private System.Windows.Forms.ToolStripMenuItem tsmSetTargetTime;
        private System.Windows.Forms.ToolTip tltTime;
        private System.Windows.Forms.ToolStripMenuItem tsmResetTimerConfirm;
        private System.Windows.Forms.ToolStripMenuItem tsmResetTimerCancel;
        private System.Windows.Forms.ToolStripMenuItem tsmSetCurrentProgress;
    }
}

