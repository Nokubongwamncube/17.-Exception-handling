using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your First number");
                double number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter your second ");
                double number2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Your first number divided by your second number = ");
                Console.WriteLine(number1 / number2);


            }

            catch
            {
                Console.WriteLine("Error: Enter numbers only");




            }
          


            //frezze console
            Console.ReadLine();

        }
    }
}
