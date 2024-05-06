List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

int rotation = int.Parse(Console.ReadLine());

for(int i = 0;i < rotation; i++) // въртим до бря ротации
{
    int currentNum = numbers[0];  // винаги започваме от първото число, независимо на коя ротация сме
    numbers.RemoveAt(0);  // изтриваме го
    numbers.Add(currentNum); // добавяме го в края
    
}

Console.WriteLine(string.Join(" ", numbers));