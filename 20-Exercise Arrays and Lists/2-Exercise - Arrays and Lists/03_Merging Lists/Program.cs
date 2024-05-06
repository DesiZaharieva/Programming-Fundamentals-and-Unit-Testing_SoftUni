List<int> numbers1 = Console.ReadLine().Split().Select(int.Parse).ToList(); // четем списък 1
List<int> numbers2 = Console.ReadLine().Split().Select(int.Parse).ToList(); // четем списък 

List<int> output = new List<int>(); // създаваме нов списък с нова подредба от елементите на предходните 2 списъка

int longerCount = Math.Max(numbers1.Count, numbers2.Count); // полззваме функция за намиране на по-дългия списък и го запаметяваме в променлива

for(int i = 0; i < longerCount; i++) // обхождаме дължината на най-дългия списък
{
    if(i < numbers1.Count)    // добавяме текущият елемент от първия списък  !!! ПРАВИМ СИ ПРОВЕРКА ЗА ДЪЛЖИНАТА, ЗАЩОТО ТРЯБВА ДА ДОБАВИМ ОСТАВАЩИТЕ ЧИСЛА ОТ ПО - ДЪЛГИЯ
    {Р
        output.Add(numbers1[i]);
    }
    if(i < numbers2.Count)   // добавяме текущият елемент от втория списък
    {
        output.Add(numbers2[i]);
    }
}

Console.WriteLine(string.Join(" ", output));

