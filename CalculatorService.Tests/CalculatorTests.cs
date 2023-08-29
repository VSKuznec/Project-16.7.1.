using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using CalculatorService;
using Project_16._7._1_;

namespace CalculatorService.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new Calculator();
        }

        [Test]
        public void AdditionalReturnsCorrectSum()
        {
            int result = calculator.Additional(10, 5);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void SubtractionReturnsCorrectDifference()
        {
            int result = calculator.Subtraction(15, 10);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void MiltiplicationReturnsCorrectValue()
        {
            int result = calculator.Miltiplication(5, 3);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void DivisionReturnsCorrectValue()
        {
            int result = calculator.Division(15, 3);
            Assert.AreEqual(5, result);
        }
    }
}
