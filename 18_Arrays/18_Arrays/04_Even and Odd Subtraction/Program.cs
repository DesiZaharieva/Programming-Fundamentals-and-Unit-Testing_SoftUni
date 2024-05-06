// See https://aka.ms/new-console-template for more information

int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

//1.Сумата на четнитечисла в масива
//2.Сумата на нечетните
//3.Изваждаме от сумата на четните - нечетните

int sumEven = 0;
int sumOdd = 0;

foreach(int number in numbers)
{
    if(number % 2 == 0)
    {
        sumEven += number;
    }
    else
    {
        sumOdd += number;
    }
}

Console.WriteLine(sumEven - sumOdd);