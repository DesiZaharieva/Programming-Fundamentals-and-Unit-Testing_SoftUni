namespace _02_Odd_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int odd = int.Parse(Console.ReadLine());

            while(odd % 2 == 0)
            {

                 odd = int.Parse(Console.ReadLine());


            }
            Console.WriteLine(odd);
        }
    }
}