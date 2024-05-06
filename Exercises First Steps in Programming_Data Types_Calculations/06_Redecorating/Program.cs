namespace _06_Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityNylon = int.Parse(Console.ReadLine());
            int quantityPaint = int.Parse(Console.ReadLine());
            int quantityThinner = int.Parse(Console.ReadLine());
            int hoursCraftsmen = int.Parse(Console.ReadLine());

            double amountNylon = (quantityNylon + 2) * 1.50;
            double amountPaint = (quantityPaint + (quantityPaint * 0.10)) * 14.50;
            double amountThinner = quantityThinner * 5.00;

            double totalSum = amountNylon + amountPaint + amountThinner + 0.40;

            double amountCraftsmen = (totalSum * 0.3) * hoursCraftsmen;

            double bigTotal = totalSum + amountCraftsmen;

            Console.WriteLine(bigTotal);


        }
    }
}