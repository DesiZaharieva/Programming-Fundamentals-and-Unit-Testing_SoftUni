namespace _01_Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string screening =(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());

            double totalPrice = cols * rows; // Totalseats in the cinema.

            if (screening == "Premiere")
            {
                totalPrice *= 12;
            } else if (screening == "Normal")
                        {
                totalPrice *= 7.50;
            } else if (screening == "Discount")
            {
                totalPrice *= 5;
            }
           
            Console.WriteLine($"{totalPrice:f2} leva");
            Console.Read();
        }
    }
}