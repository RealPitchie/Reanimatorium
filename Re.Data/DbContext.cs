using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Re.Core.Models;
using Re.Core.Models.Epicrisis;

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
            optionsBuilder.UseNpgsql("UserID=postgres;Password=123qweQWE;Server=localhost;Port=6699;Database=Reanimatorium;");
            
            // connection to Epicrisis
            // "UserID=postgres;Password=123qweQWE;Server=localhost;Port=6699;Database=Reanimatorium;"
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
}