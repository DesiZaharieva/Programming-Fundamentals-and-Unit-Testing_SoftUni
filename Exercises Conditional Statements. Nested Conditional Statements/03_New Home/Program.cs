using System.Diagnostics;

namespace _03_New_Home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double cost = 0;
            
            switch(flower)
            {
                case "Roses":
                    cost = count * 5.00;
                    if (count > 80)
                        cost = cost * 0.9;
                    break;
                case "Dahlias":
                    cost = count * 3.80;
                    if (count > 90)
                        cost = cost * 0.85;
                    break;
                case "Tulips":
                    cost = count * 2.80;
                    if (count > 80)
                        cost = cost * 0.85;
                    break;
                case "Narcissus":
                    cost = count * 3.00;
                    if (count < 120)
                        cost = cost * 1.15;
                    break;
                case "Gladiolus":
                    cost = count * 2.50;
                    if (count < 80)
                        cost = cost * 1.20;
                    break;


             }

            if (budget < cost)
            {
               double needMoney = cost - budget;
               Console.WriteLine($"Not enough money, you need {needMoney:f2} leva more.");
            }
            else 
            {
                double moneyLeft = budget - cost;

               Console.WriteLine($"Hey, you have a great garden with {count} {flower} and {moneyLeft:f2} leva left.");
            }



        }

        }
    }
