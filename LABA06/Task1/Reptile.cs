namespace Task1
{
    public class Reptile : Animal
    {
        public bool HasShell;

        public Reptile(string species, int age, double weight, string habitat, bool isPredator, bool hasShell)
            : base(species, age, weight, habitat, isPredator)
        {
            HasShell = hasShell;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Species} шипит: Шшшш...");
        }
        public void Crawl()
        {
            Console.WriteLine($"{Species} ползает по земле.");
        }
    }
}