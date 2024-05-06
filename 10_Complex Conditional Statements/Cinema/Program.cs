using System.Runtime.ConstrainedExecution;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfMovie = (Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            int seatsPerRow = int.Parse(Console.ReadLine());
            double priceSum = 0;

            if(typeOfMovie == "Premiere")
            {
                priceSum = rows * seatsPerRow * 12.00;
                Console.WriteLine($"{priceSum:f2}");

            }
            else if (typeOfMovie == "Normal")
            {
                priceSum = rows * seatsPerRow * 7.50;
                Console.WriteLine($"{priceSum:f2}");

            }
            else if (typeOfMovie == "Discount")
            {
                priceSum = rows * seatsPerRow * 5.00;
                Console.WriteLine($"{priceSum:f2}");

            }



        }
    }
}





//Type of the movie will be one of the following: "Premiere" 12.00, "Normal" 7.70 and "Discount" 5.00