// See https://aka.ms/new-console-template for more information
string valueType = Console.ReadLine();



static int GreaterNumber(int num1, int num2)
{
    if(num1 > num2)
    {
        return num1;
    }
    else
    {
        return num2;
    }
}


static char GreaterChar(char ch1, char ch2)
{
    if(ch1 > ch2)
    {
        return ch1;
    }
    else
    {
        return ch2;
    }
}

static string GreaterString(string str1, string str2)
{
    if(str1.CompareTo(str2) > 0)
    {
        return str1;
    }
    else
    {
        return str2;
    }
}

if (valueType == "int")
{
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());

    Console.WriteLine(GreaterNumber(num1, num2));

   }
else if (valueType == "char")
{
    char ch1 = char.Parse(Console.ReadLine());
    char ch2 = char.Parse(Console.ReadLine());
    

    Console.WriteLine(GreaterChar(ch1, ch2));
}
else if (valueType == "string")
{
    string str1 = Console.ReadLine();
    string str2 = Console.ReadLine();
    


    Console.WriteLine(GreaterString(str1, str2));
}

