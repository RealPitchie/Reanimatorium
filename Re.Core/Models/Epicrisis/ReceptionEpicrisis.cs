using System;
using System.ComponentModel.DataAnnotations;

#nullable disable
namespace Re.Core.Models
{
    public class ReceptionEpicrisis
    {
        public string Id { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        [Display(Name = "Доставлен из")]
        public string DeliveredFrom { get; set; }
        public string AVLDueTransportation { get; set; }
        public string Complaints { get; set; }
        public string ComplaintText { get; set; }
        public string VAS { get; set; }
        public string Condition { get; set; }
        public string Conscience { get; set; }
        public string Ramsey { get; set; }
        public string MuscleTone { get; set; }
        public string[] SkinCovers { get; set; } = new string[3];

        public string Cyanosis { get; set; }
        public string Marbling { get; set; }
        public string PeripheralEdema { get; set; }

        public string[] VeinsToBeCatheterized { get; set; } = new string[2];
        public string InflammationInCatheter { get; set; }
        public string SpontaneousBreathing { get; set; }
        public string BreathingThrough { get; set; }
        public string BreathingDisorder { get; set; }
        public int RespiratoryRate { get; set; }
        public string Auscultatory { get; set; }
        public string[] BreathingRate { get; set; } = new string[2];
        public string[] Wheezes { get; set; } = new string[3];
        public string RespiratorySupport { get; set; }
        public string OxygenInsufflation {  get; set; }
        public int Volume { get; set; }
        public string Device { get; set; }
        public string Mode { get; set; }
        public int Till {  get; set; }
        public string Inotropes { get; set; }
        public int InotropesValue { get; set; }
        public string InotropesUnits { get; set; }
        public string InotropesDescription { get; set; }
        public int BR { get; set; } // Breathing rate (ЧД апп.)
        public int Pinsp { get; set; }
        public int Psupp { get; set; }
        public int PEEP { get; set; }
        public int FiO2 { get;set; }
        public string Hemodynamics { get; set; }
        public int[] ArtherialPressure { get; set; } = new int[2];
        public int Pulse { get; set; }
        public string PulseRhythm { get; set; }
        public int HeartRate { get; set; }
        public int SpO2 { get; set; }
        public string Abdomen { get; set; } // живот
        public string AbdomenText { get; set; }

        public string Pain { get; set; }
        public string PainText { get; set; }

        public string Distension { get; set; }
        public string DistensionText { get; set; }

        public string Peristalsis { get; set; }

        public string[] Tongue { get; set; } = new string[2];

        public double Diuresis { get; set; }
        public string Urine { get; set; }
        public string Drainage { get; set; }
        public string LaboratoryData { get; set; }
        public string Addition { get; set; }
        public string SeverityOfCondition { get; set; }
        public string TreatmentPlan { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
