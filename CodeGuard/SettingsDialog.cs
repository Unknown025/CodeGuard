using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodeGuard
{
    public partial class SettingsDialog : Form
    {
        public SettingsDialog()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog()
            {
                IsFolderPicker = true,
                Title = "Select Java Folder",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
            };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                if (File.Exists(Path.Combine(dialog.FileName, "bin\\javac.exe")))
                {
                    javaTextBox.Text = dialog.FileName;
                    applyButton.Enabled = true;
                }
                else
                {
                    TaskDialog.Show("The folder selected does not contain the Java compiler. Please select the Java SE Development Kit install location.",
                        "JDK Not Found", "Error", TaskDialogStandardIcon.Warning, this);
                }
            }
        }

        private void MossLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://theory.stanford.edu/~aiken/moss/");
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Settings.JavaPath = javaTextBox.Text;
            Settings.UseMoss = useMossCheckbox.Checked;
            applyButton.Enabled = false;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            applyButton.PerformClick();
            this.Close();
        }

        private void SettingsDialog_Load(object sender, EventArgs e)
        {
            javaTextBox.Text = Settings.JavaPath;
            useMossCheckbox.Checked = Settings.UseMoss;
        }

        private void RecordOutputCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
        }

        private void TimeOutCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
        }

        private void UseMossCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
        }
    }
}
