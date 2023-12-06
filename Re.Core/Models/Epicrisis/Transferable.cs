using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace Re.Core.Models.Epicrisis
{
    public class Transferable
    {
        public string Id { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Diagnosis { get; set; }
        public string ReasonsHere { get; set; }
        public string OngoingTherapy { get; set; }
        public string DynamicsState { get; set; }
        public string Department { get; set; }
        public string AgreedWith { get; set; }
        public string Condition { get; set; }
        public int Temperature { get; set; }
        public string Conscience { get; set; }
        public string[] SkinCovers { get; set; } = new string[3];
        public string Breathing { get; set; }
        public int RespiratoryRate { get; set; }
        public string Hemodynamics { get; set; }
        public int[] ArtherialPressure { get; set; } = new int[2];
        public int Ps {  get; set; }
        public int VentricularReduce {  get; set; }
        public string Auscultatory { get; set; }
        public string[] Wheezes { get; set; } = new string[3];
        public string Abdomen { get; set; } // живот
        public string Diuresis { get; set; }
        public string Drainage { get; set; }
        public string TransferCavacatheter {  get; set; }
        public string InflammationSigns { get; set; }
        public string TransferEpiduralCavacatheter { get; set; }
        public string Recomended { get; set; }
        public Doctor Doctor { get; set; }
        public Doctor Chief {  get; set; }
    }
}
