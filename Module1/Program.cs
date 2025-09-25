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
        
        static double AreaOfTriangle(double baseLength, double height)
        {
            var mult = baseLength*height;
            return mult/2;
        }
        
        static double AreaOfRectangle(double width, double height)
        {
            return width*height;
        }
        
        static double AreaOfSquare(double side)
        {
            return side*side;
        }
        
        Console.WriteLine("Hello! Type the shape you want to find the area of:");
        Console.WriteLine(" Circle, Triangle, Rectangle or Square. ");
        var userInput = Console.ReadLine().ToLower();

        switch (userInput)
        {
            case "circle":
                Console.WriteLine("Lets find the area of a Circle.");
                Console.WriteLine("Enter the radius of the Circle:");
                var canIt = double.TryParse(Console.ReadLine(),out double radius);
                while (!canIt || radius < 0)
                {
                    Console.WriteLine("Invalid input, try again.");
                    canIt = double.TryParse(Console.ReadLine(),out radius);
                }
                Console.WriteLine($"The area of a circle with radius {radius}, is {AreaOfCircle(radius)}.");
                break;
                
            case "triangle":
                Console.WriteLine("Lets find the area of a right triangle.");
                Console.WriteLine("Enter the base length of the triangle:");
                var canItTriangle = double.TryParse(Console.ReadLine(),out double baseLength);
                while (!canItTriangle || baseLength < 0)
                {
                    Console.WriteLine("Invalid input, try again.");
                    canItTriangle = double.TryParse(Console.ReadLine(),out baseLength);
                }
                Console.WriteLine("Now enter the height of the triangle:");
                var canItTriangleHeight = double.TryParse(Console.ReadLine(),out double height);
                while (!canItTriangleHeight || height < 0)
                {
                    Console.WriteLine("Invalid input, try again.");
                    canItTriangleHeight = double.TryParse(Console.ReadLine(),out height);
                }
                Console.WriteLine($"The area of a right triangle with the base length {baseLength} and height of {height}, is {AreaOfTriangle(baseLength, height)}.");
                break;
            
            case "rectangle":
                Console.WriteLine("Lets find the area of a rectangle.");
                Console.WriteLine("Enter the width of the rectangle:");
                var canItWidth = double.TryParse(Console.ReadLine(),out double width);
                while (!canItWidth || width < 0)
                {
                    Console.WriteLine("Invalid input, try again.");
                    canItWidth = double.TryParse(Console.ReadLine(),out width);
                }
                Console.WriteLine("Now enter the height of the rectangle:");
                var canItHeightRectangle = double.TryParse(Console.ReadLine(),out height);
                while (!canItHeightRectangle || height < 0)
                {
                    Console.WriteLine("Invalid input, try again.");
                    canItHeightRectangle = double.TryParse(Console.ReadLine(),out height);
                }
                Console.WriteLine($"The area of an rectangle with the width {width} and height {height} is {AreaOfRectangle(width, height)}.");
                break;
                
            case "square":
                Console.WriteLine("Lets find the area of a square.");
                Console.WriteLine("Enter the side length of the square:");
                var canItSquare = double.TryParse(Console.ReadLine(),out double side);
                while (!canItSquare || side < 0)
                {
                    Console.WriteLine("Invalid input, try again.");
                    canItSquare = double.TryParse(Console.ReadLine(),out side);
                }
                Console.WriteLine($"The area of a square with the side lengths of {side} is {AreaOfSquare(side)}.");
                break;
            
            default:
                Console.WriteLine("Lets just try a square this time...");
                Console.WriteLine("Enter the side length of the square:");
                canItSquare = double.TryParse(Console.ReadLine(),out  side);
                while (!canItSquare || side < 0)
                {
                    Console.WriteLine("Invalid input, try again.");
                    canItSquare = double.TryParse(Console.ReadLine(),out side);
                }
                Console.WriteLine($"The area of a square with the side lengths of {side} is {AreaOfSquare(side)}.");
                break;
            
        }
        
        Console.WriteLine();
        Thread.Sleep(500);
        Console.WriteLine("Goodbye!");
        
    }
}