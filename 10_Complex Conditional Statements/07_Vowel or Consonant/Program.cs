namespace _07_Vowel_or_Consonant;
class Program
{
    static void Main(string[] args)
    {
        string ch = Console.ReadLine();
        bool isVowel = ch == "A" || ch == "a"
                    || ch == "E" || ch == "e"
                    || ch == "I" || ch == "i"
                    || ch == "O" || ch == "o"
                    || ch == "U" || ch == "u";

                    if(isVowel)
        {
            Console.WriteLine("Vowel");
        }
                    else
        {
            Console.WriteLine("Consonant");
        }
    }
}




