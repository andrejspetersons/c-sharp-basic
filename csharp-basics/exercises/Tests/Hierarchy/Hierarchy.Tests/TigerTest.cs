using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy.Tests
{
    [TestClass]
    public class TigerTest
    {
        private Tiger tiger;
        private Mock<Meat> meat;
        private Mock<Vegetable> vegetable;

        [TestInitialize]
        public void Setup()
        {
            tiger = new Tiger();
            meat= new Mock<Meat>();
            vegetable = new Mock<Vegetable>();
        }

        [TestMethod]
        public void TigerMakeSound_AssignAnimalSound_Rrrr()
        {
            tiger.makeSound();
            tiger.animalVoice.Should().Be("Rrrr");
        }

        [TestMethod]
        public void TigerEat_AnimalEatFood_AcceptMeat()
        {
            meat.Object.quantity = 10;
            tiger.eat(meat.Object);
            Assert.AreEqual(meat.Object.quantity,tiger.foodEaten);
        }

        [TestMethod]
        public void TigerEat_AnimalEatFood_RejectVegetables()
        {
            vegetable.Object.quantity = 10;
            tiger.eat(vegetable.Object);
            Assert.AreEqual(0, tiger.foodEaten);
        }
    }
}
