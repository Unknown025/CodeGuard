using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CodeGuard
{
    public partial class MainWindow : Form
    {
        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);

        public MainWindow()
        {
            InitializeComponent();
            SetWindowTheme(filesListView.Handle, "Explorer", null);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            filesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            filesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            var item = new ListViewItem()
            {
                Text = "Test File.java",
                Checked = true
            };
            filesListView.Items.Add(item);
            resultGridView.Rows.Add("Test Assignment #1", imageList.Images[0], "No Plagiarism Detected");
            resultGridView.Rows.Add("Test Assignment #2", imageList.Images[1], "Possible Plagiarism");
            resultGridView.Rows.Add("Test Assignment #3", imageList.Images[2], "No Plagiarism Detected");
            resultGridView.Rows.Add("Test Assignment #4", imageList.Images[3], "No Plagiarism Detected");
            assignmentDetails.AppendText("Assignment Details\n", Color.Blue, true);
            assignmentDetails.AppendText("This assignment could not be compiled.", Color.Red, false);
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Multiselect = true,
                EnsureFileExists = true,
                Title = "Select Files"
            };
            if(dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                foreach(var item in dialog.FileNames)
                {
                    AssignmentManager.NewAssignment(item);
                }
            }
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

public static class RichTextBoxExtensions
{
    public static void AppendText(this RichTextBox box, string text, Color color, bool bold)
    {
        box.SelectionStart = box.TextLength;
        box.SelectionLength = 0;

        if (bold)
            box.SelectionFont = new Font(box.Font, FontStyle.Bold);
        box.SelectionColor = color;
        box.AppendText(text);
        box.SelectionColor = box.ForeColor;        
    }
}