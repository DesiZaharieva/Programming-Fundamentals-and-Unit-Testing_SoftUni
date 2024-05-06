namespace _05_Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int counter = 1;


            for(int row = 1;true;row++)
            {
                for(int col = 1;col <= row;col++)
                {
                    Console.Write($"{counter} ");
                    counter++;
                    if (counter > num)
                    {
                        break;
                    }
                    
                }
                Console.WriteLine();
                if (counter > num)
                {
                    break;
                }
            }

        }
    }
}