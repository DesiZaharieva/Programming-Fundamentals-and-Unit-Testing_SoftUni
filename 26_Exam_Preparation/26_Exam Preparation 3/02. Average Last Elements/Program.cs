

int[] intArray = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();

int n = int.Parse(Console.ReadLine());
double sum = 0.0;

for(int i = intArray.Length - n;i < intArray.Length;i++)
{
    int num1 = intArray[i];
    sum = sum + num1;
    
}

double average = sum / n;

Console.WriteLine($"{average:f2}");