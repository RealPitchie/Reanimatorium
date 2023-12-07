using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Hosting.StaticWebAssets; 
using MudBlazor.Services;
using Microsoft.EntityFrameworkCore;
using Re.Data;
using Re.Data.Repo;
using Re.Services.Services;
using Re.Core.Models;
using Re.Core.Models.Epicrisis;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

// Add services to the container.
services.AddRazorPages();
services.AddServerSideBlazor(); 
services.AddMudServices();

services.AddDbContext<DataContext>(options =>
    options.UseNpgsql("UserID=postgres;Password=123qweQWE;Server=localhost;Port=6699;Database=Reanimatorium;"), 
    ServiceLifetime.Transient
);
// connection to Epicrisis
// "UserID=postgres;Password=123qweQWE;Server=localhost;Port=6699;Database=Reanimatorium;"

services.AddScoped<IRepo<StandardProtocol>, Repo>();
services.AddScoped<IRepo<Transferable>, TransferableRepo>();
services.AddScoped<IRepo<ReceptionEpicrisis>, ReceptEpicrisisRepo>();
services.AddTransient<ProtocolService>();
services.AddTransient<ReceptEpicrisisService>();
services.AddTransient<TransferEpicrisisService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();