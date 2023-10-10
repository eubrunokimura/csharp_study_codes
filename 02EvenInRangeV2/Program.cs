namespace EvenInRange
{
    public class Program
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("Program: Even in Range v2.");
            Console.WriteLine("In that code we show even number to from 0 to a given input. (Using LINQ)");


            bool isNumber;
            int givenRange;
            string input;

            do
            {
                Console.WriteLine("Write a number: ");
                input = Console.ReadLine();
                isNumber = int.TryParse(input, out givenRange);

            } while (!isNumber);



            IEnumerable<int> numbers = Enumerable.Range(0, givenRange + 1).Where(x => x % 2 == 0);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }


        }
    }
}