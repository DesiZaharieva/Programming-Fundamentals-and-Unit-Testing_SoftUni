namespace _1_Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int row = 1;

            for(int cur = 1;cur <= n;)
            {
                for(int print = 0;print < row && cur <= n;print++)
                    Console.Write($"{cur++} ");
                Console.WriteLine();
                row++;
            }
        }
    }
}