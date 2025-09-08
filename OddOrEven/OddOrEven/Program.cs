namespace OddOrEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("enter a integr");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write("Enter a number: ");
            }
               if (a % 2 == 0) Console.WriteLine(" Even no");
            Console.WriteLine("Odd no");
            Console.WriteLine(" press any key for exit ");
            Console.ReadKey();

        }
    }
}
