using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Devide(10, 5).ToString());
            Console.WriteLine("thank you");
        }

        private static int Devide(int v1, int v2)
        {
            return v1/v2;
        }
    }
}
