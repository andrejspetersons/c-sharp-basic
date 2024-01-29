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
    public class MouseTest
    {
        private Mouse mouse;
        private Mock<Meat> meat;
        private Mock<Vegetable> vegetable;

        [TestInitialize]
        public void Setup()
        {
            mouse = new Mouse();
            meat = new Mock<Meat>();
            vegetable = new Mock<Vegetable>();
            
        }

        [TestMethod]
        public void MouseMakeSound_AssignAnimalSound_Squick()
        {
            mouse.makeSound();
            mouse.animalVoice.Should().Be("Squick");
        }

        [TestMethod]
        public void MouseEat_AnimalEatFood_AcceptVegetables()
        {
            vegetable.Object.quantity = 5;
            mouse.eat(vegetable.Object);
            Assert.AreEqual(vegetable.Object.quantity, mouse.foodEaten);
        }

        [TestMethod]
        public void ZebraEat_AnimalEatFood_RejectMeat()
        {
            meat.Object.quantity = 5;
            mouse.eat(meat.Object);
            Assert.AreEqual(0, mouse.foodEaten);
        }
    }
}
