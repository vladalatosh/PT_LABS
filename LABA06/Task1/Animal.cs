namespace Task1
{
    public class Animal
    {
        public string Species { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Habitat { get; set; }
        public bool IsPredator { get; set; }

        public Animal(string species, int age, double weight, string habitat, bool isPredator)
        {
            Species = species;
            Age = age;
            Weight = weight;
            Habitat = habitat;
            IsPredator = isPredator;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Species} издает какой-то звук.");
        }

        public virtual void Eat()
        {
            string diet = IsPredator ? "мясо" : "растения";
            Console.WriteLine($"{Species} кушает. Рацион: {diet}.");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"[{Species}] Возраст: {Age}, Вес: {Weight}, Хищник: {IsPredator}");
        }
    }
}