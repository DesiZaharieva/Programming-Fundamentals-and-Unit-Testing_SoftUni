// See https://aka.ms/new-console-template for more information

int n = int.Parse(Console.ReadLine());

// четирицифрено число:
//{digit1}{digit2}{digit3}{digit4}
// обхождат се числата от 1000 до 9999
// digit1 [1;9]
// digit2 [0;9]
// digit3 [0;9]
// digit4 [0;9]

for (int digit1 = 1;digit1 <= 9; digit1++) // обход на всички стойности на първата цифра
{
    for(int digit2 = 0;digit2 <= 9; digit2++) // обход на всички стойности на втората цифра
    {
        for(int digit3 = 0;digit3 <= 9; digit3++) // обход на всички стойности на третата цифра
        {
            for (int digit4 = 0; digit4 <= 9; digit4++)  // обход на всички стойности на четвъртата цифра
                if (digit1 + digit2 == n && digit3 + digit4 == n) // прави се проверка на числото дали е "Happy"
                {
                    Console.Write($"{digit1}{digit2}{digit3}{digit4} "); // отпечатваме щастливите числа
                }
        }
    }
}