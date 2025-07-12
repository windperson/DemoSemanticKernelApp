using Microsoft.Extensions.DependencyInjection;
using MySemanticKernelApp.Services;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddRazorPages();
        services.AddSingleton<SemanticKernelService>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Boilerplate omitted...
        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapRazorPages();
        });
    }
}