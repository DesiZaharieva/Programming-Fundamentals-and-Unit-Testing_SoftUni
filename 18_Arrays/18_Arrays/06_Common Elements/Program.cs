// See https://aka.ms/new-console-template for more information
int[] array1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] array2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

foreach(int num1 in array1)
{
    foreach(int num2 in array2)
    {
        if(num1 == num2)
        {//общ елемент, който го има в двата масива
            Console.Write(num1 + " ");
            break;
        }
    }
}
