namespace _03_Old_books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favorite = Console.ReadLine();
            string currentBooks = Console.ReadLine();

            int checkedBooks = 0;

            while(currentBooks != favorite && currentBooks != "No more books")
            {
                checkedBooks++;
                currentBooks = Console.ReadLine();
            }

            if (currentBooks == favorite)
                Console.WriteLine($"You checked {checkedBooks} books and found it.");
            else
                Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {checkedBooks} books.");
        }
    }
}