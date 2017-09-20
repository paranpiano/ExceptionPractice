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
                Console.WriteLine(Arthimetic(10, 10).ToString());
            }
            catch (NumDenoEqualException ne)
            {
                Console.WriteLine("NumDenoEqualException has occured!");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Drivde by zero not possible!");
                Console.WriteLine(Arthimetic(10, 1));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("thank you");
            }
        }

        private static int Arthimetic(int num1, int num2)
        {
            try
            {
                return Devide(num1, num2);
            }
            catch (Exception e)
            {
                //throw e;  
                throw new Exception(" Something bad happended ! " + e.StackTrace);
            }
        }

        private static int Devide(int num1, int num2)
        {
            if ((num1 < 0) || (num2 < 0))
            {
                throw new Exception("Negative number not allowed");
            }

            if (num1  == num2)
            {
                throw new NumDenoEqualException("Numerator and denomorater is the same");
            }

            return num1/num2;
        }
    }

}
