namespace _01_Decreasing_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            while(n >= 1)
            {
                Console.WriteLine(n);
                n--;
            }
        }
    }
}