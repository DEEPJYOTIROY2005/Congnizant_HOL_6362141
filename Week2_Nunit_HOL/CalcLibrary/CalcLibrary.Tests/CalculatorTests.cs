using CalcLibrary; // This is the reference to the project you added
using NUnit.Framework;
using System;

namespace CalcLibrary.Tests
{
    // [TestFixture] attribute marks a class that contains test methods.
    // It acts as a container for related tests.
    [TestFixture]
    public class CalculatorTests
    {
        private SimpleCalculator _calculator;

        // [SetUp] is an attribute that marks a method to be run BEFORE
        // each and every test method within this fixture.
        // This is ideal for initializing objects needed by the tests.
        [SetUp]
        public void Setup()
        {
            // We are initializing our calculator object here.
            _calculator = new SimpleCalculator();
            Console.WriteLine("Setup: Initializing SimpleCalculator.");
        }

        // [TearDown] is an attribute that marks a method to be run AFTER
        // each and every test method within this fixture.
        // This is ideal for cleanup activities, like closing connections or
        // disposing of resources.
        [TearDown]
        public void Teardown()
        {
            // In this simple case, we just set the object to null.
            _calculator = null;
            Console.WriteLine("Teardown: Cleaning up resources.");
        }

        // [Test] attribute marks a simple test method.
        [Test]
        public void Addition_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            double number1 = 5;
            double number2 = 10;
            double expectedResult = 15;

            // Act
            double actualResult = _calculator.Addition(number1, number2);

            // Assert
            // Assert.That is the NUnit way to check conditions.
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        // [TestCase] is a powerful attribute for parameterized testing.
        // It allows you to run the same test method with different input data.
        // This single method will run 3 times with the different values provided.
        // The parameters are passed in the order they are defined in the method signature.
        [TestCase(10, 5, 15)]
        [TestCase(0, 0, 0)]
        [TestCase(-5, 5, 0)]
        [TestCase(1.5, 2.5, 4.0)]
        public void Addition_VariousNumbers_ReturnsCorrectSum(double a, double b, double expected)
        {
            // Act
            double actual = _calculator.Addition(a, b);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // [Ignore] attribute marks a test method that should not be executed.
        // You must provide a reason in NUnit 3+.
        [Test]
        [Ignore("This test is temporarily disabled because of a known bug.")]
        public void Subtraction_BuggedTest_IsIgnored()
        {
            // This code will not be executed by the test runner.
            Assert.Fail("This test should not run!");
        }
    }
}