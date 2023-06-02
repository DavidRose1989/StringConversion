using System;

namespace StingConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "15";
            string mySecondString = "15";
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);
            int resultint = num1 + num2;
           

            Console.WriteLine(resultint);
            Console.Read();

        }
    }
}