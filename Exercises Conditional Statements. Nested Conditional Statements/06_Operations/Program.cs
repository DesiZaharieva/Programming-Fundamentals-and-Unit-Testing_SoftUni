using System.ComponentModel.Design;

namespace _06_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            String operation = (Console.ReadLine());

            int result = 0;
            String modDiv = "";

            switch (operation)
            {
                case "*":
                case "-":
                case "+":
                    switch (operation)
                    {
                        case "-":
                            result = n1 - n2;
                            break;
                        case "+":
                            result = n1 + n2;
                            break;
                        case "*":
                            result = n1 * n2;
                            break;
                    }
                    if (result % 2 == 0)
                        modDiv = "even";
                    else
                        modDiv = "odd";
                    // 10 + 12 = 22 - even
                    Console.WriteLine($"{n1} {operation} {n2} = {result} - {modDiv}");
                    break;

                case "%":
                case "/":
                    if (n2 != 0)
                    {
                        if (operation == "/")
                        {
                            double dres = (n1 * 1.0) / n2;
                            Console.WriteLine($"{n1} / {n2} = {dres:f2}");
                        }
                        else
                            Console.WriteLine($"{n1} % {n2} = {n1 % n2}");


            }
                    else
                    {
                Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                break;
                   
            }

        } 
            
                    
            } 
                        
                      
        }






