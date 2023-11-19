using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable disable
namespace Re.Core.Models;

public class SLRProtocol
{
    public string Id { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }
    public string CallTo { get; set; }
    public string PatientName { get; set; }
    public int PatientAge { get; set; }
    public string SpontaneousBreathing { get; set; }
    public string PupilType { get; set; }
    public string PupilCondition { get; set; }
    public string EKGMonitor { get; set; }
    public bool WasBaseSLRCarriedOut { get; set; }
    public int TrachealIntubationNo { get; set; }
    public int TrachealIntubationTry { get; set; }
    public string Features { get; set; }
    public string VentilationThrough { get; set; }
    public string VentilationWith { get; set; }
    public string[] DefibrillationInfo { get; set; }
    public string[] IntravenousCatheterInfo { get; set; }
    public string AdditionalInfo { get; set; }
    public string ReanimationCancelReason { get; set; }
    public string ReanimationFeatures { get; set; }
    public Doctor Doctor { get; set; }
}