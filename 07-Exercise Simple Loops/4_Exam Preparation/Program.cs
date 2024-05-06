namespace _4_Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxPoorGrades = int.Parse(Console.ReadLine());
            string lastProblem = "";

            int gradesNum = 0; // брой оценки
            double gradesTotal = 0; // сумата от всички оценки
            int numberOfPoorGrades = 0;

            while (numberOfPoorGrades < maxPoorGrades)
            {
                string curProblem = Console.ReadLine();
                if (curProblem == "Enough")
                    break; // тук е единият изход от цикъла
                lastProblem = curProblem;
                int curGrade = int.Parse(Console.ReadLine());
                gradesTotal = gradesTotal + curGrade; // accumulate his total score
                gradesNum++;

                if (curGrade <= 4) // if the grade is low
                    numberOfPoorGrades++; // increase the number of sequential poor grades;
            }

            if (numberOfPoorGrades >= maxPoorGrades)
            {
                //too many sequential poor grades
                Console.WriteLine($"You need a break, {numberOfPoorGrades} poor grades.");
            }
            else
                //succeeded;
                Console.WriteLine($"Average score: {gradesTotal / gradesNum:f2}");
                Console.WriteLine($"Number of problems: {gradesNum}");
                Console.WriteLine($"Last problem: {lastProblem}");
        }
    }
}