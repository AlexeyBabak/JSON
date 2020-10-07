using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    public class CustomException : Exception
    {
        public override string Message
        {
            get { return "All fields are Ignored"; }
        }
    }
}
