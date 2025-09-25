namespace Module1;

class Program
{
    static void Main(string[] args)
    {
        static double AreaOfCircle(double radius)
        {
            return Math.PI*radius*radius;
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
        
    }
}