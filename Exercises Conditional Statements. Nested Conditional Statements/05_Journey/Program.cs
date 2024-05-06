namespace _05_Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            String season = Console.ReadLine();

            String destination = "";
            String holidayType = "";
            double amountSpent = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    amountSpent = budget * 0.3;
                    holidayType = "Camp";
                }
                else 
                        {
                    amountSpent = budget * 0.7;
                    holidayType = "Hotel";

                }

            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    amountSpent = budget * 0.4;
                    holidayType = "Camp";
                }
                else 
                        {
                    amountSpent = budget * 0.8;
                    holidayType = "Hotel";
                }

            }
            else if (budget > 1000)
            {
                destination = "Europe";
                amountSpent = budget * 0.9;
                holidayType = "Hotel";

            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{holidayType} - {amountSpent:f2}");


        }
    }
}