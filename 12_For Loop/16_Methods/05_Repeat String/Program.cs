// See https://aka.ms/new-console-template for more information
static string RepeatString(string text, int count)
{
    string output = " ";
    for(int i= 0;i < count;i++)
    {
        output = output + text;
    }
    return output;
}

string textRepeat = Console.ReadLine();
int countRepeat = int.Parse(Console.ReadLine());

string result = RepeatString(textRepeat, countRepeat);
Console.WriteLine(result);
