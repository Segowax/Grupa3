using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WebApp.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("WonderfulApi", opt =>
{
    opt.BaseAddress = new Uri("https://my-wonderful-api-acgvdvaaa5d4b9ez.northeurope-01.azurewebsites.net/");
});

await builder.Build().RunAsync();
