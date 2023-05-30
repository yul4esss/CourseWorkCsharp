using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkC_
{
    public class CustomException : Exception
    {
        private string error;

        public CustomException(string message) : base(message)
        {
            error = message;
        }

        public override string Message => error;
    }
}
