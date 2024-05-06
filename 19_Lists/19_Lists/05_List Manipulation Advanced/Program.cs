List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine();

while(command != "end")
{
    //"Contains {number}" – check if the list contains the number and if so - print "Yes", otherwise print "No such number"

    if (command.StartsWith("Contains"))
    {
        int containsNumber = int.Parse(command.Split(" ")[1]);
        numbers.Contains(containsNumber);
        if (numbers.Contains(containsNumber))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (command == "PrintEven")
    {
        //2. command = "PrintEven"
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine(); //нов ред след списъка с четни числа
    }
    else if (command == "PrintOdd")
    {
        //"PrintOdd" – print all the odd numbers, separated by a space
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine(); //нов ред след списъка с четни числа

    }
    else if (command == "GetSum")
    {
        //"GetSum" – print the sum of all the numbers

        Console.WriteLine(numbers.Sum());
    }
    else if (command.StartsWith("Filter"))
    {
        // "Filter {condition} {number}" – left in the list all the numbers that fulfill the given condition. The condition will be either '<', '>', ">=", "<="
        string condition = command.Split(" ")[1]; //условие: '<', '>', ">=", "<="
        int number = int.Parse(command.Split(" ")[2]);
        switch (condition)
        {
            case "<":
                numbers.RemoveAll(numberInList => numberInList >= number);
                break;
            case ">":
                numbers.RemoveAll(numberInList => numberInList <= number);
                break;
            case "<=":
                numbers.RemoveAll(numberInList => numberInList > number);
                break;
            case ">=":
                numbers.RemoveAll(numberInList => numberInList < number);
                break;
        }
    }



    command = Console.ReadLine();
}



    


Console.WriteLine(string.Join(" ", numbers));

