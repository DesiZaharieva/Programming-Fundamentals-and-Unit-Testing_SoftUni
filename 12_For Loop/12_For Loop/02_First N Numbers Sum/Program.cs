namespace _02_First_N_Numbers_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumNum = 0;
            int num = 1;
            Console.Write(num);

            for (int i = 2;i <= n;i++)
            {
                 
               Console.Write($"+{i}");
                sumNum = sumNum + i;
                
             }
            
            Console.WriteLine($"={sumNum + 1}");
        }
    }
}