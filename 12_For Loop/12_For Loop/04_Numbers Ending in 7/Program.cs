namespace _04_Numbers_Ending_in_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());

            for(int i = 7;i <= endNum; i += 10)
            {
                Console.WriteLine(i);
            }
        }
    }
}