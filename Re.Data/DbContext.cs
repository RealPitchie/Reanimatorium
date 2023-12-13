using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Re.Core.Models;
using Re.Core.Models.Epicrisis;
using Re.Core.Models.Hemo;

#nullable disable

namespace Re.Data;


public class DataContext : DbContext
{
    public DataContext() {}
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    { } 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
    { 
        if (!optionsBuilder.IsConfigured) 
        {
            optionsBuilder.UseNpgsql("UserID=postgres;Password=passmein123;Server=localhost;Port=5432;Database=reanim;");

            // connection to Epicrisis
            // "UserID=postgres;Password=123qweQWE;Server=localhost;Port=6699;Database=reanim;"
        }
    }

    //Наркотики
    public DbSet<Patient> Patients { get; set; }
    public DbSet<PrescribedMedication> Medications { get; set; }
    public DbSet<Syndrom> Syndroms { get; set; }

    //Протоколы
    public DbSet<StandardProtocol> Protocols { get; set; }
    public DbSet<SLRProtocol> SLRProtocols { get; set; }
    public DbSet<CentralVeinProtocol> CentralVeinProtocols { get; set; }
    public DbSet<ArteriaProtocol> ArteriaProtocols { get; set; }

    //Эпикризы
    public DbSet<ReceptionEpicrisis> ReceptionEpicrises { get; set; }
    public DbSet<Transferable> TransferableEpicrisis { get; set; }
    public DbSet<СhestСavityRoentgen> ChestСavityRoentgens { get; set; }
    public DbSet<AbdominalCavityRoentgen> AbdominalRoentgens { get; set; }
    public DbSet<TomographicExploration> TomographicExplorations { get; set; }

    //Дневники
    public DbSet<StandartDiary> StandartDiaries { get; set; }
    public DbSet<WeekendDiary> WeekendDiaries { get; set; }
    public DbSet<Extubation> ExtubationDiaries { get; set; }

    //Гемотрансфузии
    public DbSet<HemoEpicrisis> HemoEpicrises { get; set; }
}