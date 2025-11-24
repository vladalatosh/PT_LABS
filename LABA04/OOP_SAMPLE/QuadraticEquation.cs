namespace OOP_SAMPLE
{
    public class QuadraticEquation
    {
        private int a;

        public int A
        {
            get { return a; }
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Поле а со значением 0 недопустимо для квадратного уравнения.");
                }
                else
                {
                    a = value;
                }
            }
        }

        public int B
        {
            get; set;
        }


        public int C
        {
            get; set;
        }

        public QuadraticEquation(int a, int b, int c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Quadratic Equation: {A}x^2 + {B}x + {C} = 0");
        }

        public int GetsRootCount()
        {
            int discriminant = B * B - 4 * A * C;
            if (discriminant > 0)
            {
                return 2;
            }
            else if (discriminant == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public double[] GetRoots()
        {
            int discriminant = B * B - 4 * A * C;
            if (discriminant == 0)
            {
                double root = -B / (2.0 * A);
                return new double[] { root };
            }
            else if (discriminant > 0)
            {
                double root1 = (-B + Math.Sqrt(discriminant)) / (2.0 * A);
                double root2 = (-B - Math.Sqrt(discriminant)) / (2.0 * A);
                return new double[] { root1, root2 };
            }
            return Array.Empty<double>();
        }
    }
}