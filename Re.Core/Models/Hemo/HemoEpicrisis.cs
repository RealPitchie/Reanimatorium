using System;
using Re.Core.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable

namespace Re.Core.Models.Hemo
{
    public class HemoEpicrisis
    {
        public string Id { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public string FIO { get; set; } //больной(-ая)
        public string Age { get; set; } //возраст
        public string Number { get; set; } //история болезни
        public string GroupRh { get; set; } //группа крови и Rh-принадлежность 
        public string Diagnosis { get; set; } //диагноз
        public string Indications { get; set; } //показания к переливанию
        public string Hemotransfusion { get; set; } //ранее гемотрансфузии
        public string danerit { get; set; } //кол-во эритроцит. взвеси
        public string EritGroup { get; set; } //группа эритроцит. взвеси
        public string danszp { get; set; } //кол-во свежезам. плазмы
        public string SZPGroup { get; set; } //группа свежезам. плазмы
        public string dantromb { get; set; } //кол-во тромбоцит. конц.
        public string TrombGroup { get; set; } //группа тромбоцит. конц.
        public Doctor Doctor { get; set; } //доктор
    }
}
