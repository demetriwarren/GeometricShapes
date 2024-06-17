namespace GeometricShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quad q1 = new Quad(3, 4, 5, 6);
            Console.WriteLine($"Perimeter of the quad1 is {q1.Perimeter()}");
            Quad q2 = new Quad(5, 5, 5, 5);
            Console.WriteLine($"Perimeter of the quad2 is {q2.Perimeter()}");

            Rectangle r1 = new Rectangle(5, 10);
            Console.WriteLine($"Perimeter of the rectangle is {r1.Perimeter()} and Area is {r1.Area()}");

            Square s1 = new Square(9);
            Console.WriteLine($"Perimeter of the square is {s1.Perimeter()} and Area is {s1.Area()}");
        }
    }
}
