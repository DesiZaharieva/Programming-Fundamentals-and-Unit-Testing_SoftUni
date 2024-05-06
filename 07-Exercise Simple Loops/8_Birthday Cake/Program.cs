namespace _8_Birthday_Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int square = width * length;

            while(square >= 0)
            {
                String input = Console.ReadLine();
                if (input == "STOP")
                    break;
                square -= int.Parse(input);
            }

            if (square >= 0)
                Console.WriteLine($"{square} pieces are left.");
            else
                Console.WriteLine($"No more cake left! You need {-square} pieces more.");
        }
    }
}