using System.Drawing;

namespace _04_Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            for(int iFloor = floors; iFloor >= 1;iFloor--)
            {
              for(int iNumber = 0;iNumber < number; iNumber++)
                {
                    if(iFloor == floors)
                    {
                        type = "L";
                        Console.Write($"{type}{iFloor}{iNumber} ");
                    }
                    else if(iFloor % 2 != 0)
                    {
                        type = "A";
                        Console.Write($"{type}{iFloor}{iNumber} ");
                    }
                    else if (iFloor % 2 == 0)
                    {
                        type = "O";
                        Console.Write($"{type}{iFloor}{iNumber} ");
                    }
                }
                Console.WriteLine();
            }

            



            //•	Identifiers consist of: {type}{floor}{number}, e.g. L65, A12, O24
            //Нечетните етажи съдържат апартаменти (тип А), напр. A10, A11, A12,
            //• Четните етажи съдържат офиси (тип O), напр. O20, O21, O22, …
            //• На последния етаж има големи апартаменти (тип L), напр. L60, L61, L62
        }
    }
}