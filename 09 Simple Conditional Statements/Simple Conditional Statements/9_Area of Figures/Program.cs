namespace _9_Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = 0;

            if(figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
                Console.WriteLine($"{area:f2}");
            }
            else if (figure == "rectangle")
            {
                
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
                Console.WriteLine($"{area:f2}");
             }
            else if (figure == "circle")
            {

                double r = double.Parse(Console.ReadLine());
                area = Math.PI * r * r;
                Console.WriteLine($"{area:f2}");
            }
            else
            {
                Console.WriteLine("Invalid figure.");
            }
        }
    }
}