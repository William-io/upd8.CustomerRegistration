using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using upd8.CustomerRegistration.App;
using upd8.CustomerRegistration.Infrastructure.Data;
using upd8.CustomerRegistration.Infrastructure.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddDbContext<DataContext>(options => options.UseInMemoryDatabase("upd8DB"));

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<ICustomerService, CustomerService>();

await builder.Build().RunAsync();
