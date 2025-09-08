namespace OddOrEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a integr");
            int a=Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0) Console.WriteLine(" Even no");
            Console.WriteLine("Odd no");
        }
    }
}
