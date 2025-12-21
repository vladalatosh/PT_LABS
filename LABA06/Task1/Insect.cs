namespace Task1
{
    public class Insect : Animal
    {
        public int LegsCount;

        public Insect(string species, int age, double weight, string habitat, bool isPredator, int legsCount)
            : base(species, age, weight, habitat, isPredator)
        {
            LegsCount = legsCount;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Species} жужжит или стрекочет.");
        }
        public void Crawl()
        {
            Console.WriteLine($"{Species} ползает на {LegsCount} ногах.");
        }
    }
}