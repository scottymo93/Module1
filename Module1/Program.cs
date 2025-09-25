namespace Module1;

class Program
{
    static void Main(string[] args)
    {
        static double AreaOfCircle(double radius)
        {
            var squared = radius * radius;
            return Math.PI*squared;
        }
        
        Console.WriteLine("Lets find the area of a Circle.");
        Console.WriteLine("Enter the radius of the Circle:");
        var canIt = double.TryParse(Console.ReadLine(),out double radius);
        while (!canIt)
        {
            Console.WriteLine("Invalid input, try again.");
            canIt = double.TryParse(Console.ReadLine(),out radius);
        }
        Console.WriteLine($"The area of a circle with radius {radius}, is {AreaOfCircle(radius)}.");
        
        Console.WriteLine();
        Thread.Sleep(500);

        static double AreaOfTriangle(double baseLength, double height)
        {
            var mult = baseLength*height;
            return mult/2;
        }
        
        Console.WriteLine("Lets find the area of a right triangle.");
        Console.WriteLine("Enter the base length of the triangle:");
        var canItTriangle = double.TryParse(Console.ReadLine(),out double baseLength);
        while (!canItTriangle)
        {
            Console.WriteLine("Invalid input, try again.");
            canItTriangle = double.TryParse(Console.ReadLine(),out baseLength);
        }
        Console.WriteLine("Now enter the height of the triangle:");
        var canItTriangleHeight = double.TryParse(Console.ReadLine(),out double height);
        while (!canItTriangleHeight)
        {
            Console.WriteLine("Invalid input, try again.");
            canItTriangleHeight = double.TryParse(Console.ReadLine(),out height);
        }
        Console.WriteLine($"The area of a right triangle with the base length {baseLength} and height of {height}, is {AreaOfTriangle(baseLength, height)}.");
        
        Console.WriteLine();
        Thread.Sleep(500);
        
        static double AreaOfRectangle(double width, double height)
        {
            return width*height;
        }
        
        Console.WriteLine("Lets find the area of a rectangle.");
        Console.WriteLine("Enter the width of the rectangle:");
        var canItWidth = double.TryParse(Console.ReadLine(),out double width);
        while (!canItWidth)
        {
            Console.WriteLine("Invalid input, try again.");
            canItWidth = double.TryParse(Console.ReadLine(),out width);
        }
        Console.WriteLine("Now enter the height of the rectangle:");
        var canItHeightRectangle = double.TryParse(Console.ReadLine(),out height);
        while (!canItHeightRectangle)
        {
            Console.WriteLine("Invalid input, try again.");
            canItHeightRectangle = double.TryParse(Console.ReadLine(),out height);
        }
        Console.WriteLine($"The area of an rectangle with the width {width} and height {height} is {AreaOfRectangle(width, height)}.");

        Console.WriteLine();
        Thread.Sleep(500);
        
        static double AreaOfSquare(double side)
        {
            return side*side;
        }
        Console.WriteLine("Lets find the area of a square.");
        Console.WriteLine("Enter the side length of the square:");
        var canItSquare = double.TryParse(Console.ReadLine(),out double side);
        while (!canItSquare)
        {
            Console.WriteLine("Invalid input, try again.");
            canItSquare = double.TryParse(Console.ReadLine(),out side);
        }
        Console.WriteLine($"The area of a square with the side lengths of {side} is {AreaOfSquare(side)}.");
        Console.WriteLine();
        Thread.Sleep(500);
        Console.WriteLine("Goodbye!");
        
    }
}