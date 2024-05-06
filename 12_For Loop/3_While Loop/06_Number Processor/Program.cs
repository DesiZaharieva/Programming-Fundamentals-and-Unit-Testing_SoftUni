namespace _06_Number_Processor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialNumber = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            

            while(command != "End")
            {
                
                if(command == "Inc")
                {
                    initialNumber = initialNumber + 1;
                    
                }
                else if(command == "Dec" )
                {
                    initialNumber = initialNumber - 1;
                    
                }

                command = Console.ReadLine();


            }
            Console.WriteLine(initialNumber);


        }
    }
}