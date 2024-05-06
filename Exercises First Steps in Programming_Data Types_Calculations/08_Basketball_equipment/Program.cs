namespace _08_Basketball_equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int trainingFee = int.Parse(Console.ReadLine());

            double priceSneakers = trainingFee - (trainingFee * 0.4);
            double priceTeam = priceSneakers - (priceSneakers * 0.2);
            double priceBasketball = priceTeam / 4;
            double priceAcc = priceBasketball / 5;

            double allCosts = priceSneakers + priceTeam + priceBasketball + priceAcc + trainingFee;

            Console.WriteLine(allCosts);
        }
    }
}