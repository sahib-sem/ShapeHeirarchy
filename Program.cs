namespace ShapeHeirarchy
{

    
    internal class Program
    {

        public static void printShape(IShape shape)
        {
            Console.WriteLine($"{shape.Name} with an Area of {shape.CalculateArea()}");
        }
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle("my_rectangle", 10.5, 13.2);
            Traingle trg = new Traingle("my_traingle", 5, 7);
            Circle crc = new Circle("my_circle", 10.0);

            List<IShape> shapes = new List<IShape>() { rec, trg , crc};

            foreach(IShape shape in shapes)
            {
                printShape(shape);
            }
        }
    }
}