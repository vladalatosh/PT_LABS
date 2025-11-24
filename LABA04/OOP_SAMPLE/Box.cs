using System.Collections.Concurrent;

namespace OOP_SAMPLE
{
    public class Box
    {
        private double l;
        private double w;
        private double h;
        public bool isClosable;

        public Double L
        {
            get { return l; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Длина должна быть положительным числом.");
                }
                else
                {
                    l = value;
                }
            }
        }

        public Double W
        {
            get { return w; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Ширина должна быть положительным числом.");
                }
                else
                {
                    w = value;
                }
            }
        }

        public Double H
        {
            get { return h; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Высота должна быть положительным числом.");
                }
                else
                {
                    h = value;
                }
            }
        }

        public Box(double length, double width, double height, bool isClosable)
        {
            L = length;
            W = width;
            H = height;
            this.isClosable = isClosable;
        }

        public bool isFit(double l, double w, double h)
        {
            return L >= l && W >= w && H >= h;
        }

        public void PrintBox()
        {
            Console.WriteLine($"Box(L={L}, W={W}, H={H}, isClosable={isClosable})");
        }
    }
}