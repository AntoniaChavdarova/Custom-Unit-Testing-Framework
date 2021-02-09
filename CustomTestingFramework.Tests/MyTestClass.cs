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
    }
}
