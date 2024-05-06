namespace _03_Biggest_of_Five_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());

            if(num1 < num5 && num2 < num5 && num3 < num5 && num4 < num5)
            {
                Console.WriteLine(num5);
            }
            else if (num1 < num4 && num2 < num4 && num3 < num4 && num5 > num4)
            {
                Console.WriteLine(num4);
            }
            else if (num1 < num3 && num2 < num3 && num3 > num4 && num5 < num3)
            {
                Console.WriteLine(num3);
            }
            else if (num1 < num2 && num2 > num3 && num4 < num2 && num5 < num2)
            {
                Console.WriteLine(num2);
            }
            else if (num1 > num2 && num3 < num1 && num4 < num1 && num5 < num1)
            {
                Console.WriteLine(num1);
            }
        }
    }
}