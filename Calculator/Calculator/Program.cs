namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string operation;
            Console.WriteLine("enter A");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write("Enter A ");
            }
            Console.WriteLine("enter B");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write("Enter B ");
            }
       
            Console.WriteLine("tell us about the operation ");
            while (operation != "+" && operation != "-" && operation != "*" && operation != "/")
            {
                Console.WriteLine("Invalid operation. Please enter one of the following: +, -, *, /");
                Console.Write("Enter an operation (+, -, *, /): ");
                operation = Console.ReadLine();
            }
            switch (operation)
            {
                case '+': Console.WriteLine(a + b); break;
                case '-': Console.WriteLine(a - b); break;
                case '*':Console.WriteLine(a * b); break;
                case '/':
                    if(b==0)
                        Console.WriteLine("No can't be divided by zero ")
                            else 
                        Console.WriteLine(a / b); 
                       break;   
            }
        }
    }
}
