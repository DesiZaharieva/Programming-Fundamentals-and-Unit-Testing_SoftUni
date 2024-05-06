namespace _07_Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numChickenMenu = int.Parse(Console.ReadLine());
            int numFishMenu = int.Parse(Console.ReadLine());
            int numVegMenu = int.Parse(Console.ReadLine());

            double sumChickenMenu = numChickenMenu * 10.35;
            double sumFishMenu = numFishMenu * 12.40;
            double sumVegMenu = numVegMenu * 8.15;

            double sumMenues = sumChickenMenu + sumFishMenu + sumVegMenu;

            double dessertPrice = sumMenues * 0.2;

            double total = sumMenues + dessertPrice + 2.50;

            Console.WriteLine(total);
        }
    }
}