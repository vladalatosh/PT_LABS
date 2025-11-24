namespace OOP_SAMPLE
{
    public class Product
    {
        public string name;
        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Цена не может быть отрицательной.");
                }
                else
                {
                    price = value;
                }
            }
        }
        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Количество не может быть отрицательным.");
                }
                else
                {
                    quantity = value;
                }
            }
        }

        public Product(string name, double price, int quantity)
        {
            this.name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public double GetTotalValue()
        {
            return Price * Quantity;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Product: {name}, Price: {Price}, Quantity: {Quantity}, Total Value: {GetTotalValue()}");
        }
    }
}