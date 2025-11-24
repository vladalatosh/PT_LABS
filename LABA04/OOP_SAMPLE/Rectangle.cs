namespace OOP_SAMPLE
{
    public class Rectangle
    {
        private double length;
        private double width;

        public double Length
        {
            get { return length; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Длина должна быть положительным числом.");
                }
                else
                {
                    length = value;
                }
            }
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Ширина должна быть положительным числом.");
                }
                else
                {
                    width = value;
                }
            }
        }
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double GetArea()
        {
            return Length * Width;
        }

        public double GetPerimeter()
        {
            return 2 * (Length + Width);
        }

        public bool IsSquare()
        {
            return Length == Width;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Rectangle: Length = {Length}, Width = {Width}, Area = {GetArea()}, Perimeter = {GetPerimeter()}");
        }
    }
}