using animal_generator.models;

namespace animal_generator.models
{
    public class Dog : Animal
    {
        static readonly string _name = "Dog";
        public Dog() : base(_name) { }

        public override void MakeNoise()
        {
            Console.WriteLine($"{_name} says Woof!");
        }
    }
}
