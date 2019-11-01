namespace CodeGuard
{
    partial class SettingsDialog
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.mossGroupBox = new System.Windows.Forms.GroupBox();
            this.useMossCheckbox = new System.Windows.Forms.CheckBox();
            this.mossLinkLabel = new System.Windows.Forms.LinkLabel();
            this.javaGroupBox = new System.Windows.Forms.GroupBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.recordOutputCheckbox = new System.Windows.Forms.CheckBox();
            this.javaTextBox = new System.Windows.Forms.TextBox();
            this.javaLabel = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.timeOutCheckbox = new System.Windows.Forms.CheckBox();
            this.tabControl.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            this.mossGroupBox.SuspendLayout();
            this.javaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.generalTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(380, 454);
            this.tabControl.TabIndex = 0;
            // 
            // generalTabPage
            // 
            this.generalTabPage.Controls.Add(this.mossGroupBox);
            this.generalTabPage.Controls.Add(this.javaGroupBox);
            this.generalTabPage.Location = new System.Drawing.Point(4, 22);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalTabPage.Size = new System.Drawing.Size(372, 428);
            this.generalTabPage.TabIndex = 0;
            this.generalTabPage.Text = "General";
            this.generalTabPage.UseVisualStyleBackColor = true;
            // 
            // mossGroupBox
            // 
            this.mossGroupBox.Controls.Add(this.useMossCheckbox);
            this.mossGroupBox.Controls.Add(this.mossLinkLabel);
            this.mossGroupBox.Location = new System.Drawing.Point(7, 120);
            this.mossGroupBox.Name = "mossGroupBox";
            this.mossGroupBox.Size = new System.Drawing.Size(353, 100);
            this.mossGroupBox.TabIndex = 1;
            this.mossGroupBox.TabStop = false;
            this.mossGroupBox.Text = "MOSS Settings";
            // 
            // useMossCheckbox
            // 
            this.useMossCheckbox.AutoSize = true;
            this.useMossCheckbox.Checked = true;
            this.useMossCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useMossCheckbox.Location = new System.Drawing.Point(10, 20);
            this.useMossCheckbox.Name = "useMossCheckbox";
            this.useMossCheckbox.Size = new System.Drawing.Size(254, 17);
            this.useMossCheckbox.TabIndex = 1;
            this.useMossCheckbox.Text = "Use MOSS (Measurement Of Software Similarity)";
            this.useMossCheckbox.UseVisualStyleBackColor = true;
            this.useMossCheckbox.CheckedChanged += new System.EventHandler(this.UseMossCheckbox_CheckedChanged);
            // 
            // mossLinkLabel
            // 
            this.mossLinkLabel.AutoSize = true;
            this.mossLinkLabel.Location = new System.Drawing.Point(7, 81);
            this.mossLinkLabel.Name = "mossLinkLabel";
            this.mossLinkLabel.Size = new System.Drawing.Size(83, 13);
            this.mossLinkLabel.TabIndex = 0;
            this.mossLinkLabel.TabStop = true;
            this.mossLinkLabel.Text = "What is MOSS?";
            this.mossLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MossLinkLabel_LinkClicked);
            // 
            // javaGroupBox
            // 
            this.javaGroupBox.Controls.Add(this.timeOutCheckbox);
            this.javaGroupBox.Controls.Add(this.browseButton);
            this.javaGroupBox.Controls.Add(this.recordOutputCheckbox);
            this.javaGroupBox.Controls.Add(this.javaTextBox);
            this.javaGroupBox.Controls.Add(this.javaLabel);
            this.javaGroupBox.Location = new System.Drawing.Point(7, 7);
            this.javaGroupBox.Name = "javaGroupBox";
            this.javaGroupBox.Size = new System.Drawing.Size(359, 107);
            this.javaGroupBox.TabIndex = 0;
            this.javaGroupBox.TabStop = false;
            this.javaGroupBox.Text = "Java";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(295, 15);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(58, 23);
            this.browseButton.TabIndex = 3;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // recordOutputCheckbox
            // 
            this.recordOutputCheckbox.AutoSize = true;
            this.recordOutputCheckbox.Checked = true;
            this.recordOutputCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.recordOutputCheckbox.Location = new System.Drawing.Point(7, 43);
            this.recordOutputCheckbox.Name = "recordOutputCheckbox";
            this.recordOutputCheckbox.Size = new System.Drawing.Size(133, 17);
            this.recordOutputCheckbox.TabIndex = 2;
            this.recordOutputCheckbox.Text = "Record compile output";
            this.recordOutputCheckbox.UseVisualStyleBackColor = true;
            this.recordOutputCheckbox.CheckedChanged += new System.EventHandler(this.RecordOutputCheckbox_CheckedChanged);
            // 
            // javaTextBox
            // 
            this.javaTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.javaTextBox.Location = new System.Drawing.Point(86, 17);
            this.javaTextBox.Name = "javaTextBox";
            this.javaTextBox.Size = new System.Drawing.Size(202, 20);
            this.javaTextBox.TabIndex = 1;
            // 
            // javaLabel
            // 
            this.javaLabel.AutoSize = true;
            this.javaLabel.Location = new System.Drawing.Point(4, 20);
            this.javaLabel.Name = "javaLabel";
            this.javaLabel.Size = new System.Drawing.Size(73, 13);
            this.javaLabel.TabIndex = 0;
            this.javaLabel.Text = "&Java location:";
            // 
            // applyButton
            // 
            this.applyButton.Enabled = false;
            this.applyButton.Location = new System.Drawing.Point(317, 472);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "&Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(236, 472);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(155, 472);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // timeOutCheckbox
            // 
            this.timeOutCheckbox.AutoSize = true;
            this.timeOutCheckbox.Checked = true;
            this.timeOutCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.timeOutCheckbox.Location = new System.Drawing.Point(7, 67);
            this.timeOutCheckbox.Name = "timeOutCheckbox";
            this.timeOutCheckbox.Size = new System.Drawing.Size(289, 17);
            this.timeOutCheckbox.TabIndex = 4;
            this.timeOutCheckbox.Text = "Quit a program if it does not finish running in 30 seconds";
            this.timeOutCheckbox.UseVisualStyleBackColor = true;
            this.timeOutCheckbox.CheckedChanged += new System.EventHandler(this.TimeOutCheckbox_CheckedChanged);
            // 
            // SettingsDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(404, 507);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsDialog_Load);
            this.tabControl.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            this.mossGroupBox.ResumeLayout(false);
            this.mossGroupBox.PerformLayout();
            this.javaGroupBox.ResumeLayout(false);
            this.javaGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox javaGroupBox;
        private System.Windows.Forms.TextBox javaTextBox;
        private System.Windows.Forms.Label javaLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.CheckBox recordOutputCheckbox;
        private System.Windows.Forms.GroupBox mossGroupBox;
        private System.Windows.Forms.LinkLabel mossLinkLabel;
        private System.Windows.Forms.CheckBox useMossCheckbox;
        private System.Windows.Forms.CheckBox timeOutCheckbox;
    }
}