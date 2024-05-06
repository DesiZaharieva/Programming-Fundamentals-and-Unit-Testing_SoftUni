// See https://aka.ms/new-console-template for more information

int num = int.Parse(Console.ReadLine());

Sign(num);

static void Sign(int num)
{
    if (num == 0)
    {
        Console.WriteLine($"The number {num} is zero.");
    }
    else if (num > 0)
    {
        Console.WriteLine($"The number {num} is positive.");
    }
    else if (num < 0)
    {
        Console.WriteLine($"The number {num} is negative.");
    }
}

