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
    public class ZebraTest
    {
        private Zebra zebra;
        private Mock<Meat> meat;
        private Mock<Vegetable> vegetable;

        [TestInitialize]
        public void Setup()
        {
            zebra = new Zebra();
            meat = new Mock<Meat>();
            vegetable = new Mock<Vegetable>();
        }

        [TestMethod]
        public void ZebraMakeSound_AssignAnimalSound_Squeal()
        {
            zebra.makeSound();
            zebra.animalVoice.Should().Be("Squeal");
        }

        [TestMethod]
        public void ZebraEat_AnimalEatFood_AcceptVegetables()
        {
            vegetable.Object.quantity = 10;
            zebra.eat(vegetable.Object);
            Assert.AreEqual(vegetable.Object.quantity, zebra.foodEaten);
        }

        [TestMethod]
        public void ZebraEat_AnimalEatFood_RejectMeat()
        {
            meat.Object.quantity = 5;
            zebra.eat(meat.Object);
            Assert.AreEqual(0, zebra.foodEaten);
        }
    }
}
