internal class Program
{
    private static void Main(string[] args)
    {
        
    }

    static void CalculateTriangularArea(int a, int b, int c)
    {
        // Heron’s Formula (semiPerimeter = s)
        double s = (a + b + c) / 2;
        double triangularArea = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        Console.WriteLine($"Area of {a}-{b}-{c} triangle is: {triangularArea}\n");
    }
    
    static void CalculateRectangulerArea(int x, int y)
    {
        int rectArea = x * y;
        Console.WriteLine($"Area of {x}-{y} rectangle is: {rectArea}");
    }
    
    static void CalculateSquareArea(int side)
    {
        int square = side * side;
        Console.WriteLine($"Area of the square that's side is {side}: {square}");
    }
    
    static void CalculateCircularArea(int radius)
    {
        double circularArea = radius * 3.14;
        Console.WriteLine($"Area of the circle that's radius is {radius}: {circularArea}");
    }
}