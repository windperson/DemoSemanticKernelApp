using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using DemoSkill.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

// Register SemanticKernelService as a singleton or scoped service
builder.Services.AddSingleton<SemanticKernelService>();

var app = builder.Build();
app.MapRazorPages();
app.Run();