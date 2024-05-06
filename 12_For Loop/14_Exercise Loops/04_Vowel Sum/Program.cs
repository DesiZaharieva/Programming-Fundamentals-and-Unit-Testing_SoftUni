namespace _04_Vowel_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for(int i = 1;i <= n;i++)
            {
                string vowel = Console.ReadLine();

                if(vowel == "a")
                {
                    sum = sum + 1;
                }
                if (vowel == "e")
                {
                    sum = sum + 2;
                }
                if (vowel == "i")
                {
                    sum = sum + 3;
                }
                if (vowel == "o")
                {
                    sum = sum + 4;
                }
                if (vowel == "u")
                {
                    sum = sum + 5;
                }
            }
            Console.WriteLine(sum);
        }
    }
}