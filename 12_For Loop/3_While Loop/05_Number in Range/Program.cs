using System.Xml;

namespace _05_Number_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            bool isRange = num >= 1 && num <= 100;

            while(!isRange)
            {
                num = int.Parse(Console.ReadLine());
                isRange = num >= 1 && num <= 100;
            }
            Console.WriteLine(num);

        }
    }
}