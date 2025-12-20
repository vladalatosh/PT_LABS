namespace Task1
{
    public class Reptile : Animal
    {
        public bool HasShell { get; set; }

        public Reptile(string species, int age, double weight, string habitat, bool isPredator, bool hasShell)
            : base(species, age, weight, habitat, isPredator)
        {
            HasShell = hasShell;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Species} шипит: Шшшш...");
        }
    }
}