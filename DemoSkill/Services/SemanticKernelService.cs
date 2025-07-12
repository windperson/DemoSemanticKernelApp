using Microsoft.SemanticKernel;
using DemoSkill.Plugins;

namespace DemoSkill.Services
{
    public class SemanticKernelService
    {
        public Kernel Kernel { get; }

        public SemanticKernelService()
        {
            var builder = Kernel.CreateBuilder();
            builder.Plugins.AddFromObject(new CalculatorPlugin(), "calculator");
            Kernel = builder.Build();
        }
    }
}