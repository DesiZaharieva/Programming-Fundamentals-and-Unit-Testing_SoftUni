namespace _09_Smallest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {

          namespace _08_The_Greatest_Number
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                string command = Console.ReadLine();
                int min = int.MaxValue;

                while (command != "Stop")
                {
                    int number = int.Parse(command);
                    if (number < min)
                    {
                        min = number;
                    }
                    command = Console.ReadLine();
                }
                Console.WriteLine(min);
            }
        }
    }
}     








    