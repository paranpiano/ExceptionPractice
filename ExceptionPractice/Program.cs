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
            try
            {
                Console.WriteLine(Devide(10, 0).ToString());
                Console.WriteLine("thank you");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error has occurred, Sorry!");
            }

        }

        private static int Devide(int v1, int v2)
        {
            return v1/v2;
        }
    }
}
