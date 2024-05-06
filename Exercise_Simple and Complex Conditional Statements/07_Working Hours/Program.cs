namespace _07_Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourOfDay = int.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            if(dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday" || dayOfWeek == "Saturday")
            {
                if(hourOfDay >= 10 && hourOfDay <= 18)
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
            }
            else if(dayOfWeek == "Sunday")
            {
                Console.WriteLine("closed");
            }
        }
    }
}