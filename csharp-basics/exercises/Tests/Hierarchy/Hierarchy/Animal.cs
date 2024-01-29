namespace Hierarchy
{
    public abstract class Animal
    {
        public string animalName { get; set; }
        public string animalVoice { get; set; }
        public string animalType { get; set; }
        public double animalWeight { get; set; }
        public int foodEaten { get; set; }//if animal eat the food increase else 0
        public abstract void makeSound();
        public abstract void eat(Food f);


    }
}