namespace _5_Vacation_Savings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine()); // пари, които ни трябват
            double moneyAvailable = double.Parse(Console.ReadLine()); // колко пари си имаме в джоба

            int totalDays = 0; // общо дните, откакто сме започнали
            int spendingDays = 0; //колко дни по ред сме харчили

            while (moneyAvailable < moneyNeeded && spendingDays < 5)
            {
                totalDays++;
                String type = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());

                if (type == "spend")
                {
                    amount -= amount;
                    if (moneyAvailable < 0)
                        moneyAvailable = 0;
                    spendingDays++;
                }
                else if (type == "save")
                {

                    moneyAvailable += amount;
                    spendingDays = 0; // дните на харчене се нулират

                }
            }
            if (spendingDays >= 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(totalDays);
            }
            else if (moneyAvailable >= moneyNeeded) ;
            {
                Console.WriteLine($"You saved the money for {totalDays} days.");
            }



        }
    }
}