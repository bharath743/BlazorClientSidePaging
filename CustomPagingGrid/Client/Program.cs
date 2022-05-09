using CustomPagingGrid.Client;
using CustomPagingGrid.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//Adding telerik to the IoC container
builder.Services.AddTelerikBlazor();

builder.Services.AddScoped<ServerService>();

await builder.Build().RunAsync();
