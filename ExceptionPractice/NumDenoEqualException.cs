using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPractice
{
    public class NumDenoEqualException : Exception
    {
        public NumDenoEqualException(string message) : base(message)
        {
            
        }
    }
}
