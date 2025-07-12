using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.SemanticKernel;
using MySemanticKernelApp.Services;

namespace MySemanticKernelApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly SemanticKernelService _kernelService;

        public double Result { get; private set; }

        public IndexModel(SemanticKernelService kernelService)
        {
            _kernelService = kernelService;
        }

        public void OnGet()
        {
            var kernel = _kernelService.Kernel;
            // Call the plugin function
            Result = kernel.InvokeAsync<double>("calculator", "Add", new() { ["a"] = 5, ["b"] = 7 }).Result;
        }
    }
}