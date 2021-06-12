using System;

namespace Activity_Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;

            Console.WriteLine("please enter number1");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter number2");
            number2 = Convert.ToInt32("Console.ReadLine");

            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;

            Console.WriteLine("number1 =" + Convert.ToString(number1) + "and number2 =" + Convert.ToString(number2));
             
        }
    }
}
