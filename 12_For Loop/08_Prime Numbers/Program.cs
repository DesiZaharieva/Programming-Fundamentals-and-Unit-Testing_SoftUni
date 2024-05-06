namespace _08_Prime_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            for(int i = startNum;i < endNum;i++)
            {

                bool isPrime = true;
                int divider = 2;

                while (divider < endNum)
                {
                    if(i == divider)
                    {
                        divider += 1;
                        continue;
                    }

                    if(i % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    divider++;
                }
                if(isPrime)
                {
                    Console.Write($"{i} ");
                }

            }

        }
    }
}