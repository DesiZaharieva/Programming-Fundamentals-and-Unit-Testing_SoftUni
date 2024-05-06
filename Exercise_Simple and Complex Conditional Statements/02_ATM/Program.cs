namespace _02_ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = int.Parse(Console.ReadLine());   
            int withdraw = int.Parse(Console.ReadLine());   
            int limit = int.Parse(Console.ReadLine());  
            
            if(withdraw > limit)
            {
                Console.WriteLine("The limit was exceeded.");
            }
            else if (withdraw > balance)
            {
                Console.WriteLine("Insufficient availability.");
            }
            else if (withdraw < balance && withdraw < limit)
            {
                Console.WriteLine("The withdraw was successful.");
            }
        }
    }
}

// o	Print "The withdraw was successful.", if the balance is enough
//o Print "The limit was exceeded.", if the limit is exceeded
//o	Print "Insufficient availability.", if the balance isn't enough
