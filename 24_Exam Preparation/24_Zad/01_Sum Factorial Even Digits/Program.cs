// See https://aka.ms/new-console-template for more information

int CalculateFactorial (int number) {

    int result = 1;

    while (number > 0)
    {
        result = result * number;
        number--;
    }

    return result;

}


int numberInput = int.Parse(Console.ReadLine());

int sumFactorialEven = 0;

while (numberInput != 0)
{
    int digit = numberInput % 10;
    if (digit % 2 == 0)
    {
        int sumFactorialDigit = CalculateFactorial(digit);
        sumFactorialEven = sumFactorialEven + sumFactorialDigit;
    }
    numberInput = numberInput / 10;
}

Console.WriteLine(sumFactorialEven);
