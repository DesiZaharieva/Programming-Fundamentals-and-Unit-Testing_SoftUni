namespace _03_Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());

            double finalAmount = amount + months * (amount * (interest / 100.0)) / 12;

            Console.WriteLine(finalAmount);
            Console.ReadLine();
        }
    }
}