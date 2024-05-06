namespace _10_Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperature = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            string clothing = ""; 
            string shoes = ""; 

            if (timeOfDay == "Evening" || timeOfDay == "Afternoon" && temperature <= 18 && temperature >= 10 || timeOfDay == "Morning" && temperature <= 24 && temperature > 18)
            {
                
                 clothing = "Shirt";
                 shoes = "Moccasins";

                 Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
            }
            else if(timeOfDay == "Morning" && temperature <= 18 && temperature >= 10)
            {
                clothing = "Sweatshirt";
                shoes = "Sneakers";

                Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
            }
            else if (timeOfDay == "Morning" && temperature >= 25 || timeOfDay == "Afternoon" && temperature <= 24 && temperature > 18)
            {
                clothing = "T-Shirt";
                shoes = "Sandals";

                Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
            }
            else
            {
                clothing = "Swim Suit";
                shoes = "Sandals";

                Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
            }
        }
    }
}

