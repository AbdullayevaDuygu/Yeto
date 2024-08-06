using System.Diagnostics.Metrics;
using System.Net.WebSockets;

namespace HWConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            Console.WriteLine("Kesr eded daxil edin:");
            string input = Console.ReadLine();
            double number = Convert.ToDouble(input);
            int number1 = (int)number;
            Console.WriteLine(number1);
            //2.
            Console.WriteLine("AZN daxil edin:");
            string input1 = Console.ReadLine();
            double number2 = Convert.ToDouble(input1);
            Console.WriteLine(AznToUsd(number2));

        }
        static double AznToUsd(double number3)
        {
            return number3 * 0.59;
        }
        static void MakeRandomValues()
        {
            //5.
            Random random = new Random();
            int num = random.Next(0, 11);
            Random random1 = new Random();
            int num2 = random1.Next(0, 11);
            string value1 = GetEqualsByValue(num, num2);
            Console.WriteLine(value1);

        }


        
        static string GetEqualsByValue(int num3,int num4)
        {
            return num3 == num4 ? "Beraberdir" : "Beraber deyil";
        }













    }
}
