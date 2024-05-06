namespace _04_Mandatory_Literature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfpages = int.Parse(Console.ReadLine());
            int pagesReadsPerOur = int.Parse(Console.ReadLine());
            int daysEnd = int.Parse(Console.ReadLine());

            int totalHours = numOfpages / pagesReadsPerOur;
            int requiredHoursPerDay = totalHours / daysEnd;

            Console.WriteLine(requiredHoursPerDay);
        }
    }
}