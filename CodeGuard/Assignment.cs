using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeGuard
{
    class Assignment
    {
        public Grade grade;
        public string filepath;
        public string author;
        public string name;
        [Obsolete("This field has been replaced by the Grade enum.", true)]
        public bool compiled;
        public string standardOutput;
        public string standardError;
        public Exception exception;
    }

    enum Grade
    {
        NOT_GRADED,
        DID_NOT_COMPILE,
        INCORRECT_OUTPUT,
        CORRECT,
        TIMED_OUT
    }
}
