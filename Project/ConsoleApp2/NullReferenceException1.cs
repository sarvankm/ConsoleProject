using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class NullReferenceException1 : Exception
    {
        public int Code2 { get; set; }
        public NullReferenceException1( string message) : base(message)
        {
            
        }
        public override string ToString()
        {
            return $"Error Message: {Message}";
        }
    }
}
