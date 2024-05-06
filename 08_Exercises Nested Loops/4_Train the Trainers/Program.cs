namespace _4_Train_the_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryMembers = int.Parse(Console.ReadLine());
            double totalGradeSum = 0;
            int presentationCount = 0;

            while(true)
            {
                string presName = Console.ReadLine();
                if (presName == "Finish")
                    break;
                presentationCount++;

                double presentationAverage = 0;

                for(int juryMember = 1; juryMember <= juryMembers;juryMember++)
                {
                    double curGrade = double.Parse(Console.ReadLine());
                    presentationAverage += curGrade;
                    totalGradeSum += curGrade;

                }
                Console.WriteLine($"{presName} - {presentationAverage/juryMembers:f2}.");
            }
            Console.WriteLine($"Student's final assessment is {totalGradeSum/(presentationCount * juryMembers):f2}.");
        }
    }
}