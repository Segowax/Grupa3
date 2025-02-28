using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WebApp.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
string? httpClientName = "sensory";
ArgumentException.ThrowIfNullOrEmpty(httpClientName);

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});
builder.Services.AddHttpClient(httpClientName, client =>
{
    client.BaseAddress = new Uri("https://my-wonderful-api-acgvdvaaa5d4b9ez.northeurope-01.azurewebsites.net");
    client.DefaultRequestHeaders.UserAgent.ParseAdd("dotnet-docs");

});

await builder.Build().RunAsync();
