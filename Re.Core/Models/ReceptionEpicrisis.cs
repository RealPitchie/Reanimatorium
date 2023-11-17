using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace Re.Core.Models
{
    public class ReceptionEpicrisis
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Name { get; set; }
        public string[] DeliveredFrom { get; set; }
        public string[] AVLDueTransportation { get; set; }
        public string[] Complaints { get; set; }
        public string[] Vash { get; set; }
        public string[] Condition { get; set; }
        public string[] Conscience { get; set; }
        public string[] Ramsey { get; set; }
        public string[] MuscleTone { get; set; }
        public List<string[]> SkinCovers { get; set; }

        public string[] Cyanosis { get; set; }
        public string[] Marbling { get; set; }
        public string[] PeripheralEdema { get; set; }

        public List<string[]> VeinsToBeCatheterized { get; set; }

        public string[] InflammationInCatheter { get; set; }
        public string[] SpontaneousBreathing { get; set; }
        public string[] BreathingThrough { get; set; }
        public string[] BreathingDisorder { get; set; }
        public int RespiratoryRate { get; set; }
        public string? Features { get; set; }
    }
}
