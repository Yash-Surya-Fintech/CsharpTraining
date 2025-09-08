namespace TemperatureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {// this is changed one 
            Console.WriteLine("Enter your Temperature ");
            double temp=Convert.ToDouble(Console.ReadLine());       
            Console.WriteLine("Enter your Conversion C or F");
            char type=Convert.ToChar(Console.ReadLine());
            char res=char.ToUpper(type);
            if (res == 'C') Console.WriteLine((temp - 32) * 5 / 9);
            else Console.WriteLine((temp * 9 / 5) + 32);
  
        }
    }
}
