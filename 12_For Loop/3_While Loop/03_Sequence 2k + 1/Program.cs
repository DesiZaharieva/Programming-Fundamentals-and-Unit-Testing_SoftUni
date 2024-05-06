using System.Diagnostics.CodeAnalysis;

namespace _03_Sequence_2k___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNum = int.Parse(Console.ReadLine());

            int sum = 1;
            Console.WriteLine(sum);

            while (sum < maxNum)
            {
                sum = sum * 2 + 1;
                Console.WriteLine(sum);
            }
            
        }
    }
}