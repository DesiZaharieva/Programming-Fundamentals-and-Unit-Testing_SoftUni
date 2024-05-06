namespace _06_Exam_Countdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());

            for(int currentDay = d;currentDay > 0; currentDay -= 1)
            {
                Console.WriteLine($"{currentDay} days before the exam");
            }
            Console.WriteLine("The exam has come");
        }
    }
}