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
                Console.WriteLine(Arthimetic(10, 0).ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("thank you");
            }
        }

        private static int Arthimetic(int num1, int num2)
        {
            return Devide(num1, num2);
        }

        private static int Devide(int num1, int num2)
        {
            return num1/num2;
        }
    }
}
