// See https://aka.ms/new-console-template for more information

int[] array1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] array2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

bool isIdentical = true; //isIdentical = true -> масивитие са еднакви
                        //isIdentical = false -> масивите не са еднакви


for (int index = 0;index <= array1.Length - 1; index++)
{
    if (array1[index] != array2[index])
    { //имаме различни елементи на еднакви позиции -> масивите не са еднакви
        isIdentical = false;
        Console.WriteLine("Arrays are not identical.");
        break;
    }

}

if (isIdentical)
{
    Console.WriteLine("Arrays are identical.");
}
