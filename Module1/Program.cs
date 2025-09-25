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
    }
}