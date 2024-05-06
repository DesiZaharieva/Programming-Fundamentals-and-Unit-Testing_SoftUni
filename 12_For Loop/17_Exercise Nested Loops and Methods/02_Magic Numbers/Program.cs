// See https://aka.ms/new-console-template for more information
int num = int.Parse(Console.ReadLine());

//числата са от 100 до 99
//първа цифра {1:9}
//втора цифра {0:9}
//трета цифра {0:9}

//обходът започва от първата цифра
for(int digit1 = 1;digit1 <= 9; digit1++)
{
    for(int digit2 = 0;digit2 <= 9;digit2++)
    {
        for(int digit3 = 0;digit3 <= 9;digit3++)
        {
            if(digit1 * digit2 * digit3 == num)
            {
                Console.Write($"{digit1}{digit2}{digit3} ");
            }
        }
    }
}