namespace _6_Boiling_Water
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tempWater = double.Parse(Console.ReadLine());

            if(tempWater > 100)
            {
                Console.WriteLine("The water is boiling");
            }
            else
                Console.WriteLine("The water is not hot enough");
        }
    }
}