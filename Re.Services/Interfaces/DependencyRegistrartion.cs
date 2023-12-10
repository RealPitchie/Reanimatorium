
using Microsoft.Extensions.DependencyInjection;
using Re.Core.Models;
using Re.Data.Repo;
using Re.Data.Repo.Diary;
using Re.Services.Services;


namespace Re.Services.Interfaces
{
    public static class DependencyRegistrartion
    {

        public static void RegisterDependencies(this IServiceCollection services)
        {
            services.AddScoped<IRepo<StandardProtocol>, Repo>();
            services.AddScoped<IRepo<ReceptionEpicrisis>, ReceptEpicrisisRepo>();
            services.AddTransient<ProtocolService>();
            services.AddTransient<ReceptEpicrisisService>();

            services.AddScoped<IRepo<Patient>, DrugRepo>();
            services.AddScoped<IRepo<PrescribedMedication>, DrugRepo>();
            services.AddScoped<IRepo<Syndrom>, DrugRepo>();
            services.AddTransient<DrugService>();

            services.AddScoped<IRepo<StandartDiary>, DiaryStandartRepo>();
            services.AddScoped<IRepo<WeekendDiary>, DiaryWeekendRepo>();
            services.AddScoped<IRepo<Extubation>, DiaryExtubationRepo>();
            services.AddTransient<StandartDiaryService>();
            services.AddTransient<WeekendDiaryService>();
            services.AddTransient<ExtubationDiaryService>();
        }

    }
}
