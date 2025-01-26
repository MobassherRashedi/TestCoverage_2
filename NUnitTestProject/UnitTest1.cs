using CodeCoverage.Services;

namespace NUnitTestProject
{
    public class CalculatorServiceTests
    {
        private CalculatorService _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new CalculatorService();
        }

        [Test]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange 
            int a = 10;
            int b = 2;

            // Act
            var result = _calculator.Add(a, b);

            // Assert
            Assert.That(12, Is.EqualTo(result));

        }

        [Test]
        public void Substract_ShouldReturnCorrectResult()
        {
            // Arrange 
            int a = 10;
            int b = 2;

            // Act
            var result = _calculator.Substract(a, b);

            // Assert
            Assert.That(8, Is.EqualTo(result));


        }
    }
}
