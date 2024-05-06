
string[] rawArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int[] inputArray = new int[rawArray.Length];

for(int i = 0;i < rawArray.Length; i += 1)
{
    inputArray[i] = int.Parse(rawArray[i]);
}

int middleElementRight = inputArray.Length / 2;
int middleElementLeft = middleElementRight - 1;

double middleAverage = (inputArray[middleElementRight] + inputArray[middleElementLeft]) / 2.0;

Console.WriteLine($"{middleAverage:f2}");