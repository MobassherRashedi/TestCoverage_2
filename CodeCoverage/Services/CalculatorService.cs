namespace CodeCoverage.Services
{
    public class CalculatorService : ICalculatorService
    {
        public int Add(int a, int b) => a + b;
        public int Substract(int a, int b) => a - b;
        public int Multiplication(int a, int b) => a * b;
        public int Division(int a, int b) => a / b;
    }
}
