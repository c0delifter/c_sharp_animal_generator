using animal_generator.models.Interfaces;

namespace animal_generator.models
{
    public abstract class Animal : IAnimalNoise
    {
        private readonly string _name;

        public Animal(string name)
        {
            _name = name;
        }

        public abstract void MakeNoise();
    }
}