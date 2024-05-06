// See https://aka.ms/new-console-template for more information

//комбинация {letter1}{letter2}{letter3}


char startLetter = char.Parse(Console.ReadLine()); // четем стартова буква
char endLetter = char.Parse(Console.ReadLine());   // четем крайна буква
char excludeLetter = char.Parse(Console.ReadLine()); // четем буква, която трябва да иззключим

int count = 0; // брой валидни комбинации

// обхождаме от стартова до крайна буква

for (char letter1 = startLetter;letter1 <= endLetter;letter1++)
{
    for(char letter2 = startLetter;letter2 <= endLetter;letter2++)
    {
        for(char letter3 = startLetter;letter3 <= endLetter;letter3++)
        {
            if(letter1 != excludeLetter && letter2 != excludeLetter && letter3 != excludeLetter) // комбинации, които трябва да изключим
            {   
                Console.Write($"{letter1}{letter2}{letter3} "); // принтираме всички валидни комбинации
                count++; // увеличаваме брой валидни комбинации
            }
        }
    }
}
Console.WriteLine(); // сваляме курсора на долния ред
Console.WriteLine(count); // отпечатваме брой валидни комбинации