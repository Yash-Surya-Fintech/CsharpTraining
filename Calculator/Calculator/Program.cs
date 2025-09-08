namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter A");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter B");
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("tell us about the operation ");
            char op=Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case '+': Console.WriteLine(a + b); break;
                case '-': Console.WriteLine(a - b); break;
                case '*':Console.WriteLine(a * b); break;
                case '/':Console.WriteLine(a / b); break;   
            }
        }
    }
}
