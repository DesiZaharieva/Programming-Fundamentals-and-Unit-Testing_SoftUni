

List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> output = new List<int>(); // масивът, който ще пълним

for(int i = 0;i < input.Count / 2; i++) // обхождаме входящия списък с числа, като стигаме до половината на елементите в листа
{
    int sum = input[0 + i] + input[input.Count - 1 - i]; // събираме first + last, first + 1 + last - 1, first + 2 + last - 2, … first + n, last – n

    output.Add(sum); // добавяме към новия списък
}

if(input.Count % 2 != 0) // ако числата във входящия лист са нечетен брой, се налага да намерим средното число
{
    int num = input[input.Count / 2];  // намираме средното число
    output.Add(num); // добавяме го към новия масив
}

Console.WriteLine(string.Join(" ", output)); 
