using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re.Core.Models.Hemo
{
    public class HemoEpicrisis
    {
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public string Name { get; set; }
        public string FIO { get; set; } //больной(-ая)
        public string Age { get; set; } //возраст
        public string Number { get; set; } //история болезни
        public string[] GroupRh { get; set; } //группа крови и Rh-принадлежность 
        public string Diagnosis { get; set; } //диагноз
        public string[] Indications { get; set; } //показания к переливанию
        public string Hemotransfusion { get; set; } //ранее гемотрансфузии
        public string[] Doctor { get; set; } //доктор
    }
}
