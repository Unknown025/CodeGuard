using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CodeGuard
{
    class AssignmentManager
    {
        private static List<Assignment> assignmentList = new List<Assignment>();

        /// <summary>
        /// Adds a new assignment to the queue.
        /// </summary>
        /// <param name="nFilepath"></param>
        public static void NewAssignment(string nFilepath)
        {
            var assignment = new Assignment()
            {
                author = null,
                graded = false,
                filepath = nFilepath,
                name = Path.GetFileName(nFilepath)
            };
            assignmentList.Add(assignment);
        }

        public static void TryCompile(out bool success)
        {
            success = false;

        }
    }
}
