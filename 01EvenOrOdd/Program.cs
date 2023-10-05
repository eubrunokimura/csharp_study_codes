namespace EvenOrOdd
{
    class Program
    {
        public static void Main(string[] args)
        {

            bool conversion;
            int result;


            do
            {
                Console.WriteLine("Even or odd?");
                string input = Console.ReadLine();
                conversion = int.TryParse(input, out result);
            } while (!conversion);

            if (result % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }



        }
    }
}