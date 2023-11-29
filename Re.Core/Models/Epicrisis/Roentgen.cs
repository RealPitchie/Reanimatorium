using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re.Core.Models.Epicrisis
{
    public class Roentgen
    {
        public string Id { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public string Name { get; set; }
        public string Other { get; set; }
        public string Location { get; set; }
        public string LocationPosition { get; set; }
        public Doctor Doctor { get; set; }
    }

    public class СhestСavityRoentgen : Roentgen
    {
        public bool AllowPostoperativeAnalysis { get; set; }
        public bool AllowHemopneumothoraxException { get; set; }
        public bool AllowPositionControl { get; set; }
        public bool AllowDiagnosticsChanges { get; set; }
        public bool AllowIdentificationInjuries { get; set; }
    }

    public class AbdominalCavityRoentgen : Roentgen
    {
        public bool AllowPostoperativeAnalysis { get; set; }
        public bool AllowGasAvailable { get; set; }
        public bool AllowPassageRating { get; set; }
        public bool AllowPositionControl { get; set; }
    }
    public class TomographicExploration : Roentgen
    {
        public string ExplorationType { get; set; }
        public bool IsContrasted { get; set; }
        public ScanArea ScanArea { get; set; }
        public string Indication { get; set; }
    }
    public class ScanArea
    {
        public bool IsHead { get; set; }
        public bool IsThoracicCavity { get; set; } 
        public bool IsAbdominalCavity { get; set; } 
        public bool IsCervicalSpine { get; set; } 
        public bool IsPelvicCavity { get; set; } 
    }
}
