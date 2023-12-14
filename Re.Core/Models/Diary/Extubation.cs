using Re.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable

namespace Re.Core.Models
{
    public class Extubation
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string MedSedation { get; set; } //мед седация
        public string MuscleTone { get; set; } //мышечный тонус
        public int Insuflation { get; set; } //инсуфляция
        public int Sat { get; set; } //Sat
        public int Ad { get; set; } //АД
        public int Chss { get; set; } //ЧСС
        public Doctor Doctor { get; set; } //доктор
    }
}
