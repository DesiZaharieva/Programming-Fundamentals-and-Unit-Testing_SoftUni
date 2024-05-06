namespace _07_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            for(char let = start;let <= end;let ++)
            {
                Console.Write(let + " ");
            }
        }
    }
}