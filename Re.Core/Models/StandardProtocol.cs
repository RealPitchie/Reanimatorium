using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable disable
namespace Re.Core.Models;

//базовый класс
public class StandardProtocol
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }
    public string Name { get; set; }
    
    public bool IsLocalAnesthesyNeeded { get; set; }
    public string LocalAnesthesyType { get; set; }
    public string[] LocalAnesthesyTypes { get; set; }
    public decimal LocalAnesthesyDose { get; set; }
    
    public string CatheterUsed { get; set; } //создать таблицу катетеров в ДБ
    public string[] CathetersUsed { get; set; } //создать таблицу катетеров в ДБ
    public int TriesNo { get; set; }
    public int CatheterInsertedCentimetres { get; set; }
    
    public string Features { get; set; }
    public string Complications { get; set; }
    
    public virtual Doctor Doctor { get; set; }

    
}
public class CentralVeinProtocol : StandardProtocol
{
    public virtual CentralVeinIndications Indications { get; set; }
    public string VeinToBeCatheterized { get; set; }
    public string[] VeinsToBeCatheterized { get; set; }
    public int CVD { get; set; } //ЦВД см.водн.ст
    public bool IsRgControlNeeded { get; set; }
    public DateOnly RgControlDate { get; set; }
    public CentralVeinProtocol()
    {
        Id = Guid.NewGuid().ToString();
        Indications = new();
        CathetersUsed = new string[] { "B|Braun Certofix mono S215", "B|Braun Certofix mono S220","B|Braun Certofix mono S315","B|Braun Certofix mono S330" };
        LocalAnesthesyTypes = new string[] { "Лидокаином 1%", "Новокаином 0,25%" };
        VeinsToBeCatheterized = new string[] {
            "v.subclavia dext.",
            "v.subclavia sin.",
            "v.jugularis int. dext.",
            "v.subclavia in. sin.",
            "v.femoralis dext.",
            "v.femoralis sin."
        };
        Name = "Протокол катетеризации центральной вены";


    }
}
public class ArteriaProtocol : StandardProtocol
{
    public virtual ArteriaIndications Indications { get; set; }
    public string ArteriaToBeCatheterized { get; set; }
    public string[] ArteriasToBeCatheterized { get; set; }
    public ArteriaProtocol()
    {
        Id = Guid.NewGuid().ToString();
        Indications = new();
        CathetersUsed = new string[] { "B|Braun Certofix mono S215", "B|Braun Certofix mono S220","B|Braun Certofix mono S315","B|Braun Certofix mono S330" };
        LocalAnesthesyTypes = new string[] { "Лидокаином 1%", "Новокаином 0,25%" };
        ArteriasToBeCatheterized = new string[] {
            "a.radialis dext.",
            "a.radialis sin.",
            "a.femoralis dext.",
            "a.femoralis sin."
        };
        Name = "Протокол катетеризации артерии";
    }
}
public class EpiduralSpaceProtocol : StandardProtocol
{
    public virtual EpiduralSpaceIndications Indications { get; set; }
    public string[] PunctionLevels { get; set; }
    public string PunctionLevel { get; set; }
    public string[] CathetersInserted { get; set; }
    public string CatheterInserted { get; set; }
    public string Notes { get; set; }
    public EpiduralSpaceProtocol()
    {
        Id = Guid.NewGuid().ToString();
        Indications = new();
        LocalAnesthesyTypes = new string[] { "Лидокаином 1%", "Новокаином 0,25%" };
        PunctionLevels = new string[] {
            "Th 1-2","Th 2-3","Th 3-4","Th 4-5","Th 5-6","Th 6-7","Th 7-8","Th 8-9","Th 9-10","Th 10-11",
            "Th 11 - L 1", "L 1-2","L 2-3","L 3-4"
        };
        CathetersInserted = new string[] { "краниально", "каудально" };
        CathetersUsed = new string[] { "набором B|Braun Perifix mono S215", "набором B|Braun Perifix mono S220","набором B|Braun Perifix mono S315","набором B|Braun Perifix mono S330" };
        Name = "Протокол катетеризации эпидурального пространства";
    }
}

public class CentralVeinIndications
{
    public string Id { get; set; }  = Guid.NewGuid().ToString();
    public bool AllowVenoseAccess { get; set; }
    public bool AllowInfusionTherapy { get; set; }
    public bool AllowParenteralNutrition { get; set; }
    public bool AllowHemocorrection { get; set; }
}
public class ArteriaIndications
{
    public string Id { get; set; }  = Guid.NewGuid().ToString();
    public bool AllowControl { get; set; } //КЩС, что бы это ни было
    public bool AllowPressureMonitoring { get; set; }
    public bool AllowPiccoMonitoring { get; set; }
}
public class EpiduralSpaceIndications
{
    public string Id { get; set; }  = Guid.NewGuid().ToString();
    public bool AllowPostoperativeAnesthesia { get; set; }
    public bool AllowPainSyndromeTreatment { get; set; }
    public bool AllowAcutePancreatitisTreatment { get; set; }
    public bool AllowIntestinalStimulation { get; set; }
}