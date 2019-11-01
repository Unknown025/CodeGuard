using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CodeGuard
{
    class AssignmentManager
    {
        private static List<Assignment> assignmentList = new List<Assignment>();
        private static List<Assignment> compiledList = new List<Assignment>();

        /// <summary>
        /// Adds a new assignment to the queue.
        /// </summary>
        /// <param name="nFilepath"></param>
        public static bool NewAssignment(string nFilepath)
        {
            var assignment = new Assignment()
            {
                author = null,
                grade = Grade.INCORRECT_OUTPUT,
                filepath = nFilepath,
                name = Path.GetFileName(nFilepath)
            };
            foreach(Assignment _assignment in assignmentList)
            {
                if (_assignment.filepath == assignment.filepath)
                    return false;
            }
            assignmentList.Add(assignment);
            return true;
        }

        /// <summary>
        /// Returns the current queue.
        /// </summary>
        public static List<Assignment> Assignments
        {
            get { return assignmentList; }
        }

        /// <summary>
        /// Returns the processed queue.
        /// </summary>
        public static List<Assignment> CompiledAssignments
        {
            get { return compiledList; }
        }

        /// <summary>
        /// Attempts to compile an assignment.
        /// </summary>
        /// <param name="assignment"></param>
        /// <param name="success"></param>
        public static void TryCompile(Assignment assignment, out Assignment newAssignment)
        {
            newAssignment = assignment;
            ProcessStartInfo processStartInfo = new ProcessStartInfo()
            {
                Arguments = "\"" +assignment.filepath + "\"",
                RedirectStandardError = true,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                ErrorDialog = false,
                FileName = Path.Combine(Settings.JavaPath, "bin\\javac.exe"),
                UseShellExecute = false
            };
            Process process = new Process()
            {
                StartInfo = processStartInfo
            };
            try
            {                
                process.Start();
                process.WaitForExit(30000);
                if (!process.HasExited)
                    process.Kill();
                
                StringBuilder standardOutput = new StringBuilder();
                while (!process.StandardOutput.EndOfStream)
                {
                    standardOutput.Append(process.StandardOutput.ReadLine());
                }
                StringBuilder standardError = new StringBuilder();
                while (!process.StandardError.EndOfStream)
                {
                    standardError.Append(process.StandardError.ReadLine());
                }
                newAssignment.standardOutput = standardOutput.ToString();
                newAssignment.standardError = standardError.ToString();
                if(!string.IsNullOrEmpty(newAssignment.standardError) || process.ExitCode != 0)
                {
                    newAssignment.grade = Grade.DID_NOT_COMPILE;
                }
            }
            catch (Exception ex)
            {
                newAssignment.exception = ex;
                newAssignment.grade = Grade.DID_NOT_COMPILE;
            }
        }

        /// <summary>
        /// Attempts to run an assignment.
        /// </summary>
        /// <param name="assignment"></param>
        /// <param name="newAssignment"></param>
        public static void TryRun(Assignment assignment, string expectedOuput, out Assignment newAssignment)
        {
            newAssignment = assignment;
            if (newAssignment.grade == Grade.DID_NOT_COMPILE)
            {
                return;
            }
            ProcessStartInfo processStartInfo = new ProcessStartInfo()
            {
                Arguments = "\"" + Path.GetFileNameWithoutExtension(assignment.filepath) + "\"",
                RedirectStandardError = true,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                ErrorDialog = false,
                FileName = Path.Combine(Settings.JavaPath, "bin\\java.exe"),
                UseShellExecute = false,
                WorkingDirectory = Path.GetDirectoryName(assignment.filepath)
            };
            Process process = new Process()
            {
                StartInfo = processStartInfo
            };
            try
            {
                process.Start();
                bool exited = process.WaitForExit(5000);
                if (!exited)
                {
                    process.Kill();
                    newAssignment.grade = Grade.TIMED_OUT;
                    return;
                }
                StringBuilder standardOutput = new StringBuilder();
                while (!process.StandardOutput.EndOfStream)
                {
                    standardOutput.Append(process.StandardOutput.ReadLine());
                }
                StringBuilder standardError = new StringBuilder();
                while (!process.StandardError.EndOfStream)
                {
                    standardError.Append(process.StandardError.ReadLine());
                }
                newAssignment.standardOutput = standardOutput.ToString();
                newAssignment.standardError = standardError.ToString();
                if(standardOutput.ToString().Equals(expectedOuput))
                {
                    newAssignment.grade = Grade.CORRECT;
                }
                else
                {
                    newAssignment.grade = Grade.INCORRECT_OUTPUT;
                }
            }
            catch (Exception ex)
            {
                newAssignment.exception = ex;
                newAssignment.grade = Grade.DID_NOT_COMPILE;
            }
        }

        /// <summary>
        /// Returns the amount of assignments to compile.
        /// </summary>
        public static int Total
        {
            get { return assignmentList.Count; }
        }

        /// <summary>
        /// Processes the assignment queue.
        /// </summary>
        /// <param name="context"></param>
        public static void Run(SynchronizationContext context, ToolStripProgressBar progressBar, ToolStripStatusLabel label, DataGridView dataGridView,
            ImageList imageList, Button runButton, string expected)
        {
            Settings.LoadSettings();
            dataGridView.Rows.Clear();
            compiledList.Clear();
            foreach(Assignment assignment in assignmentList)
            {
                assignment.grade = Grade.NOT_GRADED;
            }
            if (assignmentList == null)
                return;
            int index = 0;
            foreach(var assignment in assignmentList)
            {
                index++;
                context.Post(o =>
                {
                    progressBar.Value = index;
                    label.Text = "Compiling " + Path.GetFileNameWithoutExtension(assignment.filepath);
                }, null);
                TryCompile(assignment, out Assignment compiled);
                TryRun(compiled, expected, out compiled);

                compiledList.Add(compiled);
                int imagelistIndex = 1;
                if (compiled.grade == Grade.DID_NOT_COMPILE)
                    imagelistIndex = 3;
                if(compiled.grade == Grade.INCORRECT_OUTPUT)
                    imagelistIndex = 4;
                context.Post(o =>
                {
                    dataGridView.Rows.Add(Path.GetFileName(compiled.filepath), imageList.Images[imagelistIndex], "Not scanned for plagiarism.");
                }, null);
            }
            context.Post(o =>
            {
                label.Text = "Ready.";
                progressBar.Visible = false;
                dataGridView.ClearSelection();
                runButton.Enabled = true;
            }, null);
        }

        /// <summary>
        /// Returns an assignment by name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Assignment GetAssignmentByName(string name)
        {
            foreach(var assignment in compiledList)
            {
                if (Path.GetFileName(assignment.filepath).Equals(name))
                    return assignment;
            }
            return null;
        }

        /// <summary>
        /// Clears the entire queue.
        /// </summary>
        public static void Clear()
        {
            assignmentList.Clear();
            compiledList.Clear();
        }
    }
}
