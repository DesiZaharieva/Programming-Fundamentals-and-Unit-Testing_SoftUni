namespace _02_Summer_Clothing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            string clothing = Console.ReadLine();
            string shoes = Console.ReadLine();

            if ( 10 <= temp && temp <= 18 )
            {
                if (timeOfDay == "Morning")
                {
                    clothing = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (timeOfDay == "Afternoon")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeOfDay == "Evening")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }

            }
            else if (18 <= temp && temp <= 24)
            {
                if (timeOfDay == "Morning")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeOfDay == "Afternoon")
                {
                    clothing = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfDay == "Evening")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }

            }
            else if (temp >= 25)
            {
                if (timeOfDay == "Morning")
                {
                    clothing = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfDay == "Afternoon")
                {
                    clothing = "Swim Suit";
                    shoes = "Barefoot";

                }
                else if (timeOfDay == "Evening")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }

            }

            Console.WriteLine($"It's {temp} degrees, get your {clothing} and {shoes}.");
            

        }
    }
}