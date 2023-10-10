using System;

namespace EvenInRange
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Program: Even in Range");
            Console.WriteLine("That program says even numbers starting from 0 to given number.\n");

            String input;
            bool validateNumber;
            int rangeNumber;

            do
            {
                Console.WriteLine("Give a number greater than 0: ");
                input = Console.ReadLine();

                validateNumber = int.TryParse(input, out rangeNumber);


                if (!validateNumber || rangeNumber <= 0)
                {
                    Console.WriteLine("Invalid Number...");
                }



            } while ((!validateNumber) || (rangeNumber <= 0));


            Console.WriteLine("\n\n\nRange...");
            for (int i = 0; i <= rangeNumber; i++)
            {
                Console.WriteLine("Number: " + i.ToString() + (i % 2 == 0 ? " -> Even" : String.Empty));
            }

        }
    }
}