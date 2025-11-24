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
    }
}