namespace _03_Biggest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int maxNumber = int.MinValue;
            for(int number = 1;number <= n;number++)
            {
                int value = int.Parse(Console.ReadLine());
                
                if(value > maxNumber)
                {
                    maxNumber = value;
                }
            }
            Console.WriteLine(maxNumber);

        }
    }
}