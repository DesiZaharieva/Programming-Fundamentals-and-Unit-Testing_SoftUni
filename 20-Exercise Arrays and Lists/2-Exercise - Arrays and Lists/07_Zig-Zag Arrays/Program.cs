

int n = int.Parse(Console.ReadLine()); // четем броя на редовете с по две числа, които ше постъпят


List<int> ListsPoz1 = new List<int>(); // масив за изход първи ред
List<int> ListsPoz2 = new List<int>(); // масив за изход втори ред

for (int i = 1;i <= n;i++) // обхождаме общата бройка редове, които ще постъпят
{
    List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList(); // редът се разглежда като списък

    int num1 = numbers[0]; // първото число
    int num2 = numbers[1]; // второто число

    if (i % 2 != 0) // ако имаме нечетен ред
    {
        ListsPoz1.Add(num1); // добавяме първото число в първия изходящ списък
        ListsPoz2.Add(num2); // добавяме второто число във втория изходящ списък
    }
    else
    {
        ListsPoz1.Add(num2);
        ListsPoz2.Add(num1);

    }
}

Console.WriteLine(string.Join(" ", ListsPoz1));
Console.WriteLine(string.Join(" ", ListsPoz2));

