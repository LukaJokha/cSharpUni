namespace davaleba1_luka_jokhadze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure();

            Console.WriteLine("კვადრატი: " + figure.Perimeter(5));
            Console.WriteLine("მართკუთხედი: " + figure.Perimeter(4, 7));
            Console.WriteLine("სამკუთხედი: " + figure.Perimeter(3, 4, 5));
            Console.WriteLine("წრე: " + figure.Perimeter(2.5));
        }
    }

    class Figure
    {
        // კვადრატის პერიმეტრი
        public int Perimeter(int side)
        {
            return 4 * side;
        }

        // მართკუთხედის პერიმეტრი
        public int Perimeter(int width, int height)
        {
            return 2 * (width + height);
        }

        // სამკუთხედის პერიმეტრი
        public int Perimeter(int a, int b, int c)
        {
            return a + b + c;
        }

        // წრის სიგრძე
        public double Perimeter(double radius)
        {
            return 2 * Math.PI * radius;
        }
    }
}
