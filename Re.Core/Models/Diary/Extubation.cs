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
        public string MedSedation { get; set; } //мед седация
        public string MuscleTone { get; set; } //мышечный тонус
        public string Insuflation { get; set; } //инсуфляция
        public string Sat { get; set; } //Sat
        public string Ad { get; set; } //АД
        public string Chss { get; set; } //ЧСС
        public Doctor Doctor { get; set; }
    }
}
