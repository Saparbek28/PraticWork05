using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class PersonException : ArgumentException
    {
        public int Value { get; }
        public PersonException(string message, int val)
            : base(message)
        {
            Value = val;
        }
    }
}
