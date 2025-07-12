using Microsoft.SemanticKernel;

namespace MySemanticKernelApp.Plugins
{
    public class CalculatorPlugin
    {
        // The SKFunction attribute and Microsoft.SemanticKernel.Attributes namespace
        // were removed in Semantic Kernel v1.0+. Plugin methods are now discovered by convention.

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