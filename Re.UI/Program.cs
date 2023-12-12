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
using Re.Data.Repo.Diary;
using Re.Core.Models.Hemo;
using Re.Data.Repo.Hemo;
using Re.Services.Services.Hemo;
using Re.Data.Repo.Epicrisis;
using Re.Services.Services.Epicrisis;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

// Add services to the container.
services.AddRazorPages();
services.AddServerSideBlazor(); 
services.AddMudServices();

services.AddDbContext<DataContext>(options =>
    options.UseNpgsql("UserID=postgres;Password=123qweQWE;Server=localhost;Port=6699;Database=reanim;"), 
    ServiceLifetime.Transient
);
// connection to Epicrisis
// "UserID=postgres;Password=passmein123;Server=localhost;Port=5432;Database=reanim;"

// To add date
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

services.AddScoped<IRepo<StandardProtocol>, Repo>();

services.AddScoped<IRepo<Transferable>, TransferableRepo>();
services.AddScoped<IRepo<ReceptionEpicrisis>, ReceptEpicrisisRepo>();
services.AddScoped<IRepo<ÑhestÑavityRoentgen>, ChestCavityRepo>();
services.AddTransient<ChestCavityService>();
services.AddTransient<ProtocolService>();
services.AddTransient<ReceptEpicrisisService>();
services.AddTransient<TransferEpicrisisService>();
services.AddScoped<IRepo<AbdominalCavityRoentgen>, AbdominalRepo>();
services.AddTransient<AbdominalCavityService>();
services.AddScoped<IRepo<TomographicExploration>, TomographicRepo>();
services.AddTransient<TomographicService>();

services.AddScoped<IRepo<Patient>, DrugRepo>();
services.AddScoped<IRepo<PrescribedMedication>, DrugRepo>();
services.AddScoped<IRepo<Syndrom>, DrugRepo>();
services.AddTransient<DrugService>();

services.AddScoped<IRepo<HemoEpicrisis>, HemoEpicrisisRepo>();
services.AddTransient<HemoEpicrisisService>();

services.AddScoped<IRepo<StandartDiary>, DiaryStandartRepo>();
services.AddScoped<IRepo<WeekendDiary>, DiaryWeekendRepo>();
services.AddScoped<IRepo<Extubation>, DiaryExtubationRepo>();
services.AddTransient<StandartDiaryService>();
services.AddTransient<WeekendDiaryService>();
services.AddTransient<ExtubationDiaryService>();

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