using System;

#nullable disable
namespace Re.Core.Models
{
    public class ReceptionEpicrisis
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Name { get; set; }
        public string DeliveredFrom { get; set; }
        public string AVLDueTransportation { get; set; }
        public string Complaints { get; set; }
        public string Vash { get; set; }
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
        public string? Complaint { get; set; }
        public string Auscultatory { get; set; }
        public string[] ShortnessOfBreath { get; set; } = new string[2];
        public string[] Wheezes { get; set; } = new string[3];
        public string RespiratorySupport { get; set; }
        public string OxygenInsufflation {  get; set; }
        public int Volume { get; set; }

    }
}
