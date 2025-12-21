namespace Task1
{
    // Птица
    public class Bird : Animal
    {
        public double WingSpan;

        public Bird(string species, int age, double weight, string habitat, bool isPredator, double wingSpan)
            : base(species, age, weight, habitat, isPredator)
        {
            WingSpan = wingSpan;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Species} чирикает или кричит!");
        }
        
        public void Fly()
        {
            Console.WriteLine($"{Species} летит, расправив крылья ({WingSpan} м).");
        }
    }
}