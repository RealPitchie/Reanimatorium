using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Re.Core.Models;

#nullable disable

namespace Re.Data;


public class DataContext : DbContext
{
    public DbSet<Patient> Patients { get; set; } 
    
    public DataContext() {}
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    { } 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
    { 
        if (!optionsBuilder.IsConfigured) 
        {
            optionsBuilder.UseNpgsql("UserID=postgres;Password=123qweQWE;Server=localhost;Port=6699;Database=Reanimatorium;");
        } 
    }

    //Протоколы
    public DbSet<StandardProtocol> Protocols { get; set; }
    public DbSet<SLRProtocol> SLRProtocols { get; set; }
    public DbSet<CentralVeinProtocol> CentralVeinProtocols { get; set; }
    public DbSet<ArteriaProtocol> ArteriaProtocols { get; set; }

    //Эпикризы
    public DbSet<ReceptionEpicrisis> ReceptionEpicrises { get; set; }
}