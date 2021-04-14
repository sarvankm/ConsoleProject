using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class NullReferenceException2:Exception
    {
        public NullReferenceException2(string message) : base(message)
        {

        }
        public override string ToString()
        {
            return $"Error Message: {Message}";
        }
    }
}
