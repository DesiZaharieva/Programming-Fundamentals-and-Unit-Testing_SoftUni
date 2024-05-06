namespace _02_Even_Powers_of_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int result = 1;

            for(int i = 0;i <= n; i = i + 2)
            {
                
                Console.WriteLine(result);
                result *= 2 * 2;

            }
           
        }
    }
}