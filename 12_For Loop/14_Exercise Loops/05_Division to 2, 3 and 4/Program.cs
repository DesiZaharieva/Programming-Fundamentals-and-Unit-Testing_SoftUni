namespace _05_Division_to_2__3_and_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broiChisla = int.Parse(Console.ReadLine());

            int sumChisla2 = 0;
            int sumChisla3 = 0;
            int sumChisla4 = 0;

            for(int num = 1;num <= broiChisla;num++)
            {
                int poredno = int.Parse(Console.ReadLine());

                if(poredno % 2 == 0)
                {
                    sumChisla2 = sumChisla2 + 1;
                }
                if (poredno % 3 == 0)
                {
                    sumChisla3 = sumChisla3 + 1;
                }
                if (poredno % 4 == 0)
                {
                    sumChisla4 = sumChisla4 + 1;
                }
            }

            double sumProcent2 = sumChisla2 * 1.0 / broiChisla * 100;
            double sumProcent3 = sumChisla3 * 1.0 / broiChisla * 100;
            double sumProcent4 = sumChisla4 * 1.0 / broiChisla * 100;

            Console.WriteLine($"{sumProcent2:f2}%");
            Console.WriteLine($"{sumProcent3:f2}%");
            Console.WriteLine($"{sumProcent4:f2}%");
        }
    }
}