using System;

namespace _08_Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); // входни данни : "500" или "Еnd"


            double sumBalance = 0; // баланс по сметката

            while (input != "End")
            {
                // входни данни са число под формата на текст "500"
                //"500" -> double "500"
                double money = double.Parse(input); // парир които внасяме/теглим

                if (money > 0)
                {
                    //внасяне
                    sumBalance += money;
                    Console.WriteLine($"Increase: {money:f2}");
                }
                if (money < 0)
                {
                    //теглене
                    sumBalance = sumBalance - Math.Abs(money);
                    Console.WriteLine($"Decrease: {Math.Abs(money):f2}");
                }

                input = Console.ReadLine(); // отчитаме, че продължаваме да четем вход
            }

            //входни данни == "End" 
            Console.WriteLine($"Balance: {sumBalance:f2}");
}
    }
}