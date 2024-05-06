namespace _11_Coffee_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drinkName = Console.ReadLine();
            string extra = Console.ReadLine();

            double price = 0;

            if (drinkName == "coffee")
            {

                if (extra == "sugar")
                {
                    price = 1.00 + 0.40;
                    Console.WriteLine($"Final price: ${price:f2}");

                }
                else if (extra == "no")
                {
                    price = 1.00;
                    Console.WriteLine($"Final price: ${price:f2}");
                }
            }
            else if (drinkName == "tea")
            {
                if (extra == "sugar")
                {
                    price = 0.60 + 0.40;
                    Console.WriteLine($"Final price: ${price:f2}");
                }
                else if (extra == "no")
                {
                    price = 0.60;
                    Console.WriteLine($"Final price: ${price:f2}");
                }
            }
        }
    }
}