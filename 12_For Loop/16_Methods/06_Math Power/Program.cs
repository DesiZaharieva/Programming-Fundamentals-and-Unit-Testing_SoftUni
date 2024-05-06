// See https://aka.ms/new-console-template for more information
static int MathPower(int baseNum, int powerNum)
{
    int result = baseNum;
    for(int i = 0;i < powerNum - 1;i++)
    {
        result *= baseNum;
    }

    return result;
}

int baseNum = int.Parse(Console.ReadLine());
int powerNum = int.Parse(Console.ReadLine());

int output = MathPower(baseNum, powerNum);

Console.WriteLine(output);