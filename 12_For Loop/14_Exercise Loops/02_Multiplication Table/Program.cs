namespace _02_Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int result = n;

            for(int i = 1;i <= 10;i++)
            {
                result = n * i;
                Console.WriteLine($"{n} x {i} = {result}");
            }

    
        }
    }
}