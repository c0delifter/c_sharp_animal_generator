using animal_generator.models;

namespace animal_generator.models
{
    public class Cat : Animal
    {
        static readonly string _name = "Cat";
        public Cat() : base(_name) { }

        public override void MakeNoise()
        {
            Console.WriteLine($"{_name} says Meow!");
        }
    }
}
