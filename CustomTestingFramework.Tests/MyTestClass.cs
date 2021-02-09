using System;
using CustomTestingFramework.Asserts;
using CustomTestingFramework.Attributes;
using MyProgram;

namespace CustomTestingFramework.Tests
{
    [TestClass()]
    public class MyTestClass
    {
        [TestMethod()]
        public void ShouldSumSuccesfullyTwoValues()
        {
            int a = 10;
            int b = 20;
            int expectedResult = 30;

            Calculator calculator = new Calculator();
            var actualResult = calculator.Sum(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void ShouldDivideSuccesfullyTwoValues()
        {
            int a = 10;
            int b = 5;
            int expectedResult = 2;

            Calculator calculator = new Calculator();
            var actualResult = calculator.Divide(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void ShouldMultiplySuccesfullyTwoValues()
        {
            int a = 10;
            int b = 5;
            int expectedResult = 50;

            Calculator calculator = new Calculator();
            var actualResult = calculator.Multiplication(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void ShouldSubtractSuccesfullyTwoValues()
        {
            int a = 10;
            int b = 5;
            int expectedResult = 5;

            Calculator calculator = new Calculator();
            var actualResult = calculator.Subtraction(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void ShouldThrowExceptionWhenSubtract()
        {
            int a = 10;
            int b = 5;
            int expectedResult = 50;

            Calculator calculator = new Calculator();
            var actualResult = calculator.Subtraction(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void ShouldThrowExceptionWhenDivide()
        {
            int a = 10;
            int b = 5;
            int expectedResult = 200;

            Calculator calculator = new Calculator();
            var actualResult = calculator.Divide(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
