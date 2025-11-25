namespace OOP_SAMPLE;

class Program
{
    static void Main(string[] args)
    {
        QuadraticEquation eq1 = new QuadraticEquation(1, -4, 4);
        eq1.PrintInfo();
        Console.WriteLine(eq1.GetsRootCount());
        QuadraticEquation eq2 = new QuadraticEquation(2, 4, -5);
        eq2.PrintInfo();
        Console.WriteLine(eq2.GetsRootCount());
        QuadraticEquation eq3 = new QuadraticEquation(1, 2, 3);
        eq3.PrintInfo();
        Console.WriteLine(eq3.GetsRootCount());

        Console.WriteLine("Gets root of equation 1: ");
        foreach (double root in eq1.GetRoots())
        {
            Console.WriteLine(root);
        }
        
        Console.WriteLine("Gets root of equation 2: ");
        foreach (double root in eq2.GetRoots())
        {
            Console.WriteLine(root);
        }       

        Console.WriteLine("Gets root of equation 3: ");
        foreach (double root in eq3.GetRoots())
        {
            Console.WriteLine(root);
        }

        Point p1 = new Point(3, 4);
        p1.PrintPoint();
        Console.WriteLine(p1.DistanceToOrigin());
        p1.MoveTo(5, 12);
        p1.PrintPoint();
        Console.WriteLine(p1.DistanceToOrigin());

        Rectangle rect1 = new Rectangle(5, 5);
        rect1.PrintInfo();
        Console.WriteLine(rect1.IsSquare());
        Rectangle rect2 = new Rectangle(3, 4);
        rect2.PrintInfo();
        Console.WriteLine(rect2.IsSquare());

        Box box1 = new Box(10, 8, 6, true);
        box1.PrintBox();
        Console.WriteLine(box1.isFit(5, 4, 3));
        Console.WriteLine(box1.isFit(11, 8, 6));
        Box box2 = new Box(2, 2, 2, false);
        box2.PrintBox();
        Console.WriteLine(box2.isFit(2, 2, 2));

        Product prod1 = new Product("Laptop", 999.99, 5);
        prod1.PrintInfo();
        Product prod2 = new Product("Mouse", 25.50, 20);
        prod2.PrintInfo();
        Product prod3 = new Product("Keyboard", 75.00, 10);
        prod3.PrintInfo();

        Date date1 = new Date(25, 11, 2025);
        date1.PrintDate();
        date1.AddDays(10);
        date1.PrintDate();
        Date date2 = new Date(31, 12, 2024);
        date2.PrintDate();
        date2.AddDays(5);
        date2.PrintDate();

        Car car1 = new Car("Toyota", "Camry", 2020);
        car1.PrintCarInfo();
        Car car2 = new Car("BMW", "X5", 1995);
        car2.PrintCarInfo();
        Car car3 = new Car("Mercedes", "C-Class", 2024);
        car3.PrintCarInfo();

        AProgression ap1 = new AProgression(2, 3);
        ap1.PrintInfo();
        ap1.PrintFirstN(5);
        Console.WriteLine(ap1.GetSum(5));
        AProgression ap2 = new AProgression(10, -2);
        ap2.PrintInfo();
        ap2.PrintFirstN(6);
        Console.WriteLine(ap2.GetSum(6));
    }
}