public class RectangleArea
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введіть координати прямокутника (x, y):");
            Console.Write("x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y: ");
            double y = double.Parse(Console.ReadLine());
            RectangleArea rect = new RectangleArea(x, y);
            Console.WriteLine(rect.GetInfo());
            Console.WriteLine("Площа прямокутника: " + rect.CalculateArea());
        }
    }

    private double x1;
    private double y1;

    public RectangleArea(double x1, double y1)
    {
        this.x1 = x1;
        this.y1 = y1;
    }

   
    public string GetInfo()
    {
        return $"Координати точки: x1 = {x1}, y1 = {y1}";
    }

    public double CalculateArea()
    {
        return Math.Abs(x1 * y1);
    }
}
