using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
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
            Settings.LoadSettings();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            filesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            filesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);            
            //resultGridView.Rows.Add("Test Assignment #1", imageList.Images[0], "No Plagiarism Detected");
            //resultGridView.Rows.Add("Test Assignment #2", imageList.Images[1], "Possible Plagiarism");
            //resultGridView.Rows.Add("Test Assignment #3", imageList.Images[2], "No Plagiarism Detected");
            //resultGridView.Rows.Add("Test Assignment #4", imageList.Images[3], "No Plagiarism Detected");         
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog()
            {
                RestoreDirectory = true,
                Multiselect = true,
                EnsureFileExists = true,
                Title = "Select Files"
            };
            dialog.Filters.Add(new CommonFileDialogFilter("Java File", "*.java"));
            if(dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                foreach(var item in dialog.FileNames)
                {
                    AssignmentManager.NewAssignment(item);
                }
            }
            UpdateList();
        }

        private void OpenDirectoryItem_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog()
            {
                RestoreDirectory = true,
                EnsureFileExists = true,
                Title = "Select Files",
                IsFolderPicker = true
            };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                foreach (var item in Directory.GetFiles(dialog.FileName))
                {
                    if(item.EndsWith(".java"))
                        AssignmentManager.NewAssignment(item);
                }
            }
            UpdateList();
        }

        public void UpdateList()
        {
            filesListView.Items.Clear();
            var list = AssignmentManager.Assignments;

            foreach(var item in list)
            {
                var listItem = new ListViewItem()
                {
                    Text = Path.GetFileName(item.filepath),
                    Checked = true
                };
                filesListView.Items.Add(listItem);
            }
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            runButton.Enabled = false;
            queueProgressBar.Value = 0;
            queueProgressBar.Maximum = AssignmentManager.Total;
            queueProgressBar.Visible = true;
            string testCase = testCaseTextBox.Text;
            SynchronizationContext _context = SynchronizationContext.Current;
            Thread thread = new Thread(() => 
            {
                AssignmentManager.Run(_context, queueProgressBar, statusLabel, resultGridView, imageList, runButton, testCase);
            });
            thread.Start();
        }

        private void SettingsItem_Click(object sender, EventArgs e)
        {
            new SettingsDialog().ShowDialog();
        }

        private void ResultGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            assignmentDetails.ResetText();
            if(e.RowIndex < 0 || e.RowIndex > resultGridView.Rows.Count)
                return;
            DataGridViewRow row = resultGridView.Rows[e.RowIndex];
            string name = row.Cells[0].Value.ToString();
            var assignment = AssignmentManager.GetAssignmentByName(name);
            if (assignment == null)
                assignmentDetails.ResetText();
            else
            {
                assignmentDetails.AppendText("Assignment Details\n", Color.Blue, true);
                if(assignment.grade == Grade.DID_NOT_COMPILE)
                {
                    assignmentDetails.AppendText("This assignment could not be compiled.\n", Color.Red, false);
                    if (assignment.exception != null)
                    {
                        assignmentDetails.AppendText(assignment.exception.Message + "\n", Color.Black, false);
                        assignmentDetails.AppendText(assignment.exception.StackTrace + "\n", Color.Black, false);
                    }
                    if(assignment.standardError != null)
                    {
                        assignmentDetails.AppendText(assignment.standardError, Color.Red, false);
                    }
                }
                else if(assignment.grade == Grade.INCORRECT_OUTPUT)
                {
                    assignmentDetails.AppendText("Assignment compiled with no issues.\n", Color.Green, false);
                    assignmentDetails.AppendText("Assignment output was incorrect.\n", Color.Red, false);
                    assignmentDetails.AppendText(assignment.standardOutput);
                }
                else if(assignment.grade == Grade.CORRECT)
                {
                    assignmentDetails.AppendText("Assignment compiled with no issues.\n", Color.Green, false);
                    assignmentDetails.AppendText("Assignment output was correct.", Color.Green, false);
                }
            }
        }

        private void ClearAllMenuItem_Click(object sender, EventArgs e)
        {
            TaskDialog dialog = new TaskDialog()
            {
                Icon = (TaskDialogStandardIcon)TaskDialogCommonIcon.ExplorerSearch,
                Cancelable = true,
                Caption = "Clear all?",
                InstructionText = "Clear All Items?",
                StartupLocation = TaskDialogStartupLocation.CenterOwner,
                OwnerWindowHandle = this.Handle
            };
            dialog.StandardButtons = TaskDialogStandardButtons.Yes | TaskDialogStandardButtons.No;
            if(dialog.Show() == TaskDialogResult.Yes)
            {
                filesListView.Clear();
                AssignmentManager.Clear();
            }
        }

        enum TaskDialogCommonIcon
        {
            None = 0,
            Sheet = 2,
            ExplorerFolderOpen = 3,
            ExplorerFolderFlat = 5,
            ExplorerFolderLeft = 6,
            Search = 8,
            ExplorerFolderClosed = 10,
            ExplorerGames = 14,
            Application = 15,
            TransparentSpace = 17,
            ExplorerSearch = 18,
            TextFile = 19,
            Letter = 20,
            Picture = 21,
            Diashow = 103,
            // ...
        }

        private void ViewHelpItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.rainyville.org/CodeGuard/Help");
        }

        private void CheckForUpdatesItem_Click(object sender, EventArgs e)
        {
            new TaskDialog()
            {
                Cancelable = true,
                Caption = "Check For Updates",
                Icon = TaskDialogStandardIcon.Error,
                InstructionText = "Not Supported",
                Text = "This option is not currently supported.",
                StandardButtons = TaskDialogStandardButtons.Close,
                OwnerWindowHandle = this.Handle,
                StartupLocation = TaskDialogStartupLocation.CenterOwner
            }.Show();
        }

        private void AboutItem_Click(object sender, EventArgs e)
        {
            new TaskDialog()
            {
                InstructionText = "CodeGuard v1.0.0.0",
                Caption = "About CodeGuard",
                Text = "CodeGuard, the easy solution for grading Java files.\nCreated by Sasha Petushkov.",
                Cancelable = true,
                StandardButtons = TaskDialogStandardButtons.Close,
                OwnerWindowHandle = this.Handle,
                StartupLocation = TaskDialogStartupLocation.CenterOwner
            }.Show();
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