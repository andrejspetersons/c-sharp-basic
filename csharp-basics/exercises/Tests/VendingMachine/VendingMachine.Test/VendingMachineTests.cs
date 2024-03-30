using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Tests
{
    [TestClass]
    public class VendingMachineTests
    {
        private VendingMachine _vm;

        [TestInitialize]
        public void Setup()
        {
            _vm = new VendingMachine("Test");
        }

        [TestMethod]
        public void InsertCoin_InvalidCoin_ReturnInvalid()
        {
            Money m = new Money { Euros = 3, Cents = 50 };
            _vm.InsertCoin(m);
            Assert.AreEqual(m,_vm.Amount);
        }

        [TestMethod]
        public void InsertCoin_ValidCoin_ReturnZero()
        {
            Money m = new Money { Euros = 2, Cents = 50 };
            _vm.InsertCoin(m);
            Assert.AreEqual(new Money { Euros = 0, Cents = 0 }, _vm.Amount);
        }

        [TestMethod]
        public void InsertCoin_ValidCoin_ThrowExceptionIfNegative()
        {
            Money m= new Money { Euros = -1, Cents = -50 };
            Assert.ThrowsException<NegativeMoneyException>(() => _vm.InsertCoin(m));
        }

        [TestMethod]
        public void ReturnMoney_CorrectMoney_ShouldReturnZero()
        {
            Money m = new Money { Euros = 2, Cents = 50 };
            _vm.InsertCoin(m);
            Money returnMoney = _vm.ReturnMoney();
            Assert.AreEqual(new Money { Euros = 0, Cents = 0 }, returnMoney);
        }

        [TestMethod]
        public void ReturnMoney_WrongMoney_ShouldReturnMoney()
        {
            Money m = new Money { Euros = 3, Cents = 50 };
            _vm.InsertCoin(m);
            Money returnMoney = _vm.ReturnMoney();
            Assert.AreEqual(m, returnMoney);
        }
    }
}
