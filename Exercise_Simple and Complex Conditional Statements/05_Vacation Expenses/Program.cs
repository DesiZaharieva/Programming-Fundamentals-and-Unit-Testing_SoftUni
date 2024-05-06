namespace _05_Vacation_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string accType = Console.ReadLine();
            int countOfDays = int.Parse(Console.ReadLine());

            double discount = 0;
            double sumNoDiscount = 0;
            double expensesForVacation = 0;

            if(season == "Spring")
            {
                
                if (accType == "Hotel")
                {
                    sumNoDiscount = countOfDays * 30;
                    discount = sumNoDiscount * 0.20;
                    expensesForVacation = sumNoDiscount - discount;
                    Console.WriteLine($"{expensesForVacation:f2}");
                }
                else if (accType == "Camping")
                {
                    sumNoDiscount = countOfDays * 10;
                    discount = sumNoDiscount * 0.20;
                    expensesForVacation = sumNoDiscount - discount;
                    Console.WriteLine($"{expensesForVacation:f2}");
                }
            }
            else if (season == "Summer")
            {

                if (accType == "Hotel")
                {
                    sumNoDiscount = countOfDays * 50;
                    
                    expensesForVacation = sumNoDiscount - discount;
                    Console.WriteLine($"{expensesForVacation:f2}");
                }
                else if (accType == "Camping")
                {
                    sumNoDiscount = countOfDays * 30;
                    
                    expensesForVacation = sumNoDiscount - discount;
                    Console.WriteLine($"{expensesForVacation:f2}");
                }
            }
            else if (season == "Autumn")
            {

                if (accType == "Hotel")
                {
                    sumNoDiscount = countOfDays * 20;
                    discount = sumNoDiscount * 0.30;
                    expensesForVacation = sumNoDiscount - discount;
                    Console.WriteLine($"{expensesForVacation:f2}");
                }
                else if (accType == "Camping")
                {
                    sumNoDiscount = countOfDays * 15;
                    discount = sumNoDiscount * 0.30;
                    expensesForVacation = sumNoDiscount - discount;
                    Console.WriteLine($"{expensesForVacation:f2}");
                }
            }
            else if (season == "Winter")
            {

                if (accType == "Hotel")
                {
                    sumNoDiscount = countOfDays * 40;
                    discount = sumNoDiscount * 0.10;
                    expensesForVacation = sumNoDiscount - discount;
                    Console.WriteLine($"{expensesForVacation:f2}");
                }
                else if (accType == "Camping")
                {
                    sumNoDiscount = countOfDays * 10;
                    discount = sumNoDiscount * 0.10;
                    expensesForVacation = sumNoDiscount - discount;
                    Console.WriteLine($"{expensesForVacation:f2}");
                }
            }


        }
    }
}