using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW212_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            double sum = num1 + num2;
            Assert.AreEqual(sum, SimpleMath.Add(num1, num2));
        }

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(3, 17)]
        [DataRow(2, 1)]
        [DataRow(0, 0)]
        [DataRow(1, 0)]

        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            double result = num1 * num2;
            Assert.AreEqual(result, SimpleMath.Multiply(num1, num2));
        }

        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(1, 0)]
        [DataRow(2, 0)]
        [DataRow(3, 0)]
        public void Divide_DenominatorZero_ThrowsArgumentException(double num1, double num2)
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"
            Assert.ThrowsException<ArgumentException>(() => SimpleMath.Divide(num1, num2));
        }

        // TODO: Test Divide method with two valid numbers
        [TestMethod]
        [DataRow(0, 1)]
        [DataRow(10, 3)]
        [DataRow(200, 12)]
        [DataRow(16, 4)]
        public void Divide_TwoValidNumbers_ReturnsProduct(double num1, double num2)
        {
            double result = num1 / num2;
            Assert.AreEqual(result, SimpleMath.Divide(num1, num2));
        }

        // TODO: Test subtract method with two valid numbers
        [TestMethod]
        [DataRow(5, 4)]
        [DataRow(5, 6)]
        [DataRow(12, 4)]
        [DataRow(99, 47)]
        public void Subtract_TwoValidNumbers(double num1, double num2)
        {
            double result = num1 - num2;
            Assert.AreEqual(result, SimpleMath.Subtract(num1, num2));
        }
    }
}