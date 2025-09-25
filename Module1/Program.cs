namespace Module1;

class Program
{
    static void Main(string[] args)
    {
        static double AreaOfCircle(double radius)
        {
            return Math.PI*radius*radius;
        }

        static double AreaOftriangle(double baseLength, double height)
        {
            var mult = baseLength*height;
            return mult/2;
        }
        
    }
}