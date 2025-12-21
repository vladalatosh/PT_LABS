namespace Task1
{
    public class Mammal : Animal
    {
        public string FurColor;

        public Mammal(string species, int age, double weight, string habitat, bool isPredator, string furColor)
            : base(species, age, weight, habitat, isPredator)
        {
            FurColor = furColor;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Species} рычит или фыркает!");
        }

        public void Run()
        {
            Console.WriteLine($"{Species} быстро бежит по земле.");
        }
    }
}