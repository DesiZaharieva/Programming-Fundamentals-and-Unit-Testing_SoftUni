namespace _05_Teaching_Materials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int boardCleaner = int.Parse(Console.ReadLine());

            double pricePens = pens * 5.80;
            double priceMarker = markers * 7.20;
            double priceBoardCleaner = boardCleaner * 1.20;
            int inputDiscount = int.Parse(Console.ReadLine());


            double priceAll = pricePens + priceMarker + priceBoardCleaner;

            double discount = priceAll * inputDiscount / 100;

            double priceAfterDiscount = priceAll - discount;

            Console.WriteLine(priceAfterDiscount);


        }
    }
}