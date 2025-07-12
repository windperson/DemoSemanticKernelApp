using Microsoft.SemanticKernel;

namespace DemoSkill.Plugins
{
    public class CalculatorPlugin
    {
        [KernelFunction("Add")]
        public double Add(double a, double b) => a + b;

        [KernelFunction("Subtract")]
        public double Subtract(double a, double b) => a - b;

        [KernelFunction("Multiply")]
        public double Multiply(double a, double b) => a * b;

        [KernelFunction("Divide")]
        public double Divide(double a, double b) => b != 0 ? a / b : double.NaN;
    }
}