namespace Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double volumeLiters = lenght * width * height * 0.001;

            double waterPerc = (100 - percentage) / 100;

            Console.WriteLine( "{0:0.00}" , volumeLiters * waterPerc);
            Console.Read();
        }
    }
}