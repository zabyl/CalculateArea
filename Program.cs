internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please choose an option to calculate different areas:");
        Console.WriteLine("1.Triangular area \n2.Rectangular area \n3.Square area \n4.Circular area");
        string choice = Console.ReadLine();

        if (String.IsNullOrEmpty(choice))
        {
            Console.WriteLine("Choice can not be null or empty!");
        }
        else
        {
            switch (choice)
            {
                case "1":
                CalculateTriangularArea();
                break;

                case "2":
                CalculateRectangularArea();
                break;

                case "3":
                CalculateSquareArea();
                break;

                case "4":
                CalculateCircularArea();
                break;
                
                default:
                Console.WriteLine("Please enter a valid option!");
                break;
            }
        }
    }
    static void CalculateTriangularArea(int a = 1, int b = 1, int c = 1)
    {
        Console.WriteLine("Please enter first side of the triangle:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter second side of the triangle:");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter third side of the triangle:");
        c = Convert.ToInt32(Console.ReadLine());

        // Heron’s Formula (semiPerimeter = s)
        double s = (a + b + c) / 2;
        double triangularArea = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        Console.WriteLine($"Area of {a}-{b}-{c} triangle is: {triangularArea}\n");
    }
    
    static void CalculateRectangularArea(int x = 1, int y = 1)
    {
        Console.WriteLine("Please enter first side of the rectangle:");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter second side of the rectangle:");
        y = Convert.ToInt32(Console.ReadLine());

        int rectArea = x * y;
        Console.WriteLine($"Area of {x}-{y} rectangle is: {rectArea}");
    }
    
    static void CalculateSquareArea(int side = 1)
    {
        Console.WriteLine("Please enter side length of the square:");
        side = Convert.ToInt32(Console.ReadLine());

        int square = side * side;
        Console.WriteLine($"Area of the square that's side is {side}: {square}");
    }
    
    static void CalculateCircularArea(int radius = 1)
    {
        Console.WriteLine("Please enter radius of the circle:");
        radius = Convert.ToInt32(Console.ReadLine());

        double circularArea = radius * 3.14;
        Console.WriteLine($"Area of the circle that's radius is {radius}: {circularArea}");
    }
}