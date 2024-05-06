namespace _8_Ticket_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tickeType = Console.ReadLine();
            double priceTicket = 0;

            if(tickeType == "student")
            {
                priceTicket = 1.00;
                Console.WriteLine($"${priceTicket:f2}");
            }
            else if(tickeType == "regular")
            {
                priceTicket = 1.60;
                Console.WriteLine($"${priceTicket:f2}");
            }
            else
            {
                Console.WriteLine("Invalid ticket type!");
            }
        }
    }
}