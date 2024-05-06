namespace _06_Grades_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 5.50)
            {
                Console.WriteLine("Exellent!");
            }
            else
            {
                {
                    Console.WriteLine("Not exellent.");
                }
            }
        }
    }
}