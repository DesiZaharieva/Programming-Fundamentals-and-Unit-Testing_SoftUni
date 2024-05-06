namespace _07_Special_Bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stopNumber = int.Parse(Console.ReadLine());

            int numEnd = 0;
            

            while(true)
            {
                int newNum = int.Parse(Console.ReadLine());
                
                if (newNum == stopNumber)
                {
                    Console.WriteLine(numEnd + numEnd * 0.2);
                    break;
                }
                numEnd = newNum;

            }
            
        }
    }
}