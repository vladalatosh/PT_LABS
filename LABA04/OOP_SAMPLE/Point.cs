namespace OOP_SAMPLE
{
    public class Point
    {
        public double x;
        public double y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void MoveTo(double newX, double newY)
        {
            x = newX;
            y = newY;
        }
        public double DistanceToOrigin()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public void PrintPoint()
        {
            Console.WriteLine($"Point({x}, {y})");
        }    
    }
}