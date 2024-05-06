namespace _2_Equal_Sums_of_Even_and_Odd_Positions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNUm = int.Parse(Console.ReadLine()); // we start from here
            int secondNUm = int.Parse(Console.ReadLine()); // we finish here

            for(int i = firstNUm;i<=secondNUm;i++) //the main cicle
            {
                String currentNum = i.ToString(); // let`s make the current number to String
                int oddSum = 0; //we will accummulate the sum of all odd digits here
                int evenSum = 0; //we will accummulate the sum of all even digits here

                for (int j = 0;j < currentNum.Length;j++) // we will process each character....
                {
                    Char c = currentNum[j];
                    int currentDigit = int.Parse(c.ToString()); // get the current digit from...

                    if (j % 2 == 0) // add to the corresponding sum,depending on if the...
                        oddSum += currentDigit;
                    else
                        evenSum += currentDigit;
                }

                if (oddSum == evenSum)   // if both sums are equal, lets print the current num
                    Console.Write(i + " ");
            }
        }
    }
}