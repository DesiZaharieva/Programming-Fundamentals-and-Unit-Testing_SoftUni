using System.Data;

namespace _03_Triangle_of_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            for (int row = 1; row <= size; row++)
            {
                for (int numberOfStars = 1; numberOfStars <= row; numberOfStars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            




        }
    }
}