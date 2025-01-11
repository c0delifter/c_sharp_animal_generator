using animal_generator.models;

namespace animal_generator.models
{
    public class Pig : Animal
    {
        static readonly string _name = "Pig";
        public Pig() : base(_name) { }

        public override void MakeNoise()
        {
            Console.WriteLine($"{_name} says Oink!");
        }
    }
}
