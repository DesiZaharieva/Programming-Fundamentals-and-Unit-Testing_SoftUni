namespace _1__Power_of_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int result = number;

            for (int i = 1; i < p; i++)
            {
                result = result * number;
                
            }
            Console.WriteLine(result);
        }
    }
}