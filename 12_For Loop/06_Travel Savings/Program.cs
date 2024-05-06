namespace _06_Travel_Savings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                double sumTRupam = 0;

                while (sumTRupam < budget)
                {
                    double sum = double.Parse(Console.ReadLine());
                    sumTRupam = sumTRupam + sum;
                    Console.WriteLine($"Collected: {sumTRupam:f2}");
                }
                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }

        }
        }
    }
