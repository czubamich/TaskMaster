namespace TaskMaster
{
    partial class Task
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ttbTaskName = new System.Windows.Forms.TextBox();
            this.ckbComplete = new System.Windows.Forms.CheckBox();
            this.cmsTaskMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConfirmRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCancelRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.tltInfo = new System.Windows.Forms.ToolTip(this.components);
            this.ckbActive = new System.Windows.Forms.CheckBox();
            this.cmsTaskMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ttbTaskName
            // 
            this.ttbTaskName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ttbTaskName.BackColor = System.Drawing.SystemColors.Control;
            this.ttbTaskName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ttbTaskName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.ttbTaskName.Location = new System.Drawing.Point(3, 1);
            this.ttbTaskName.Name = "ttbTaskName";
            this.ttbTaskName.Size = new System.Drawing.Size(221, 24);
            this.ttbTaskName.TabIndex = 100;
            this.ttbTaskName.Text = "Task #";
            this.ttbTaskName.TextChanged += new System.EventHandler(this.ttbTaskName_TextChanged);
            // 
            // ckbComplete
            // 
            this.ckbComplete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbComplete.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbComplete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ckbComplete.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbComplete.ContextMenuStrip = this.cmsTaskMenu;
            this.ckbComplete.FlatAppearance.BorderSize = 0;
            this.ckbComplete.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)), true);
            this.ckbComplete.Location = new System.Drawing.Point(254, 1);
            this.ckbComplete.Name = "ckbComplete";
            this.ckbComplete.Size = new System.Drawing.Size(24, 24);
            this.ckbComplete.TabIndex = 300;
            this.ckbComplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbComplete.UseVisualStyleBackColor = true;
            this.ckbComplete.CheckedChanged += new System.EventHandler(this.ckbComplete_CheckedChanged);
            // 
            // cmsTaskMenu
            // 
            this.cmsTaskMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRemove});
            this.cmsTaskMenu.Name = "cmsTaskMenu";
            this.cmsTaskMenu.Size = new System.Drawing.Size(118, 26);
            // 
            // tsmRemove
            // 
            this.tsmRemove.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmConfirmRemove,
            this.tsmCancelRemove});
            this.tsmRemove.Name = "tsmRemove";
            this.tsmRemove.Size = new System.Drawing.Size(117, 22);
            this.tsmRemove.Text = "Remove";
            // 
            // tsmConfirmRemove
            // 
            this.tsmConfirmRemove.Name = "tsmConfirmRemove";
            this.tsmConfirmRemove.Size = new System.Drawing.Size(118, 22);
            this.tsmConfirmRemove.Text = "Confirm";
            // 
            // tsmCancelRemove
            // 
            this.tsmCancelRemove.Name = "tsmCancelRemove";
            this.tsmCancelRemove.Size = new System.Drawing.Size(118, 22);
            this.tsmCancelRemove.Text = "Cancel";
            // 
            // tltInfo
            // 
            this.tltInfo.Popup += new System.Windows.Forms.PopupEventHandler(this.tltInfo_Popup);
            // 
            // ckbActive
            // 
            this.ckbActive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbActive.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbActive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ckbActive.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbActive.ContextMenuStrip = this.cmsTaskMenu;
            this.ckbActive.FlatAppearance.BorderSize = 0;
            this.ckbActive.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)), true);
            this.ckbActive.Location = new System.Drawing.Point(228, 1);
            this.ckbActive.Name = "ckbActive";
            this.ckbActive.Size = new System.Drawing.Size(24, 24);
            this.ckbActive.TabIndex = 301;
            this.ckbActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbActive.UseVisualStyleBackColor = true;
            this.ckbActive.CheckedChanged += new System.EventHandler(this.ckbActive_CheckedChanged);
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.cmsTaskMenu;
            this.Controls.Add(this.ckbComplete);
            this.Controls.Add(this.ckbActive);
            this.Controls.Add(this.ttbTaskName);
            this.Name = "Task";
            this.Size = new System.Drawing.Size(280, 26);
            this.cmsTaskMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox ttbTaskName;
        private System.Windows.Forms.CheckBox ckbComplete;
        public System.Windows.Forms.ToolTip tltInfo;
        public System.Windows.Forms.ToolStripMenuItem tsmRemove;
        public System.Windows.Forms.ContextMenuStrip cmsTaskMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmCancelRemove;
        public System.Windows.Forms.ToolStripMenuItem tsmConfirmRemove;
        private System.Windows.Forms.CheckBox ckbActive;
    }
}
