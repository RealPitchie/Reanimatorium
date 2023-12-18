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
using Re.Services.Services.Epicrisis;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

// Add services to the container.
services.AddRazorPages();
services.AddServerSideBlazor(); 
services.AddMudServices();

services.AddDbContext<DataContext>(options =>
    options.UseNpgsql("UserID=postgres;Password=passmein123;Server=localhost;Port=5432;Database=reanim;"), 
    ServiceLifetime.Transient
);
// connection to Epicrisis
// "UserID=postgres;Password=123qweQWE;Server=localhost;Port=6699;Database=reanim;"

// To add date
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

services.AddScoped<IRepo<StandardProtocol>, Repo<StandardProtocol>>();
services.AddTransient<ProtocolService>();

services.AddScoped<IRepo<ReceptionEpicrisis>, Repo<ReceptionEpicrisis>>();
services.AddScoped<IRepo<Transferable>, Repo<Transferable>>();
services.AddScoped<IRepo<СhestСavityRoentgen>, Repo<СhestСavityRoentgen>>();
services.AddScoped<IRepo<AbdominalCavityRoentgen>, Repo<AbdominalCavityRoentgen>>();
services.AddScoped<IRepo<TomographicExploration>, Repo<TomographicExploration>>();
services.AddTransient<ChestCavityService>();
services.AddTransient<ReceptEpicrisisService>();
services.AddTransient<TransferEpicrisisService>();
services.AddTransient<AbdominalCavityService>();
services.AddTransient<TomographicService>();

services.AddScoped<IRepo<Patient>, DrugRepo<Patient>>();
services.AddScoped<IRepo<PrescribedMedication>, DrugRepo<PrescribedMedication>>();
services.AddScoped<IRepo<Syndrom>, DrugRepo<Syndrom>>();
services.AddTransient<DrugService>();

services.AddScoped<IRepo<HemoEpicrisis>, HemoEpicrisisRepo>();
services.AddScoped<IRepo<ErythrocyteProtocol>, ErythrocyteRepo>();
services.AddScoped<IRepo<SZPProtocol>, SZPRepo>();
services.AddScoped<IRepo<ThrombocyteProtocol>, ThrombocyteRepo>();
services.AddTransient<HemoEpicrisisService>();
services.AddTransient<ErythrocyteProtocolService>();
services.AddTransient<SZPProtocolService>();
services.AddTransient<ThrombocyteProtocolService>();

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