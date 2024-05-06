namespace _02_Element_That_Equals_to_the_Sum_of_Others
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int biggestNumber = int.MinValue;
            int sumOfAll = 0;

            for (int i = 0; i < n; i ++)
            {
                int number = int.Parse(Console.ReadLine());

                if (biggestNumber < number)
                    biggestNumber = number;

                sumOfAll = sumOfAll + number;
            }

            sumOfAll = sumOfAll - biggestNumber;

            if(sumOfAll == biggestNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumOfAll}");
            }
            else
            {
                int diff = Math.Abs(sumOfAll - biggestNumber);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}