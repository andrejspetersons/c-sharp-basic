using FluentAssertions;
using Moq;

namespace Hierarchy.Tests
{
    [TestClass]
    public class CatTest
    {
        private Cat cat;
        private Mock<Meat> meat;
        private Mock<Vegetable> vegetable;

        [TestInitialize]
        public void Setup()
        {
            cat = new Cat();
            meat = new Mock<Meat>();
            vegetable = new Mock<Vegetable>();
        }

        [TestMethod]
        public void CatMakeSound_AssignAnimalSound_Meow()
        {
            cat.makeSound();
            cat.animalVoice.Should().Be("Meow");
        }

        [TestMethod]
        public void CatEat_AnimalEatFood_VegetableAndMeat()
        {
            meat.Object.quantity = 5;
            cat.eat(meat.Object);
            Assert.AreEqual(meat.Object.quantity, cat.foodEaten);

            vegetable.Object.quantity = 10;
            cat.eat(vegetable.Object);
            Assert.AreEqual(vegetable.Object.quantity, cat.foodEaten);
        }

    }
}