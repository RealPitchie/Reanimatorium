using Re.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace Re.Core.Models
{
    public class StandartDiary
    {
        public DateOnly Date { get; set; } //Дата
        public TimeOnly Time { get; set; } //Время

        public string[] Сonditions { get; set; } // состояние
        public string[] Сomplaints { get; set; } //жалобы
        public string ComplaintsAbout { get; set; } //жалобы на
        public string RassThis { get; set; } //RASS поле ввода
        public string[] Rass { get; set; } //RASS 
        public string[] Vash { get; set; } //ВАШ
        public string[] Conscience { get; set; } //сознание
        public List<string[]> Skin { get; set; } //кожные  покровы
        public string[] Breathing { get; set; } //дыхание
        public string[] Extubation { get; set; } //экстубация
        public string CddField { get; set; } //ЧДД
        public string[] InhalationO2 { get; set; } //ингаляция О2
        public string SpeedFlow { get; set; } //скорость потока
        public string[] Auscultatory { get; set; } //аускультативно
        public List<string[]> ShortnessOfBreath { get; set; } //ослабление дыхания 
        public string ShortnessOfBreathInput { get; set; } //ослабление дыхания поле ввода
        public List<string[]> Wheezes { get; set; } //хрипы
        public string[] RespiratorySupport { get; set; } //респираторная поддержка
        public List<string[]> InotropicSupportOne { get; set; } //инотропная поддержка 1
        public string InotropicSupportOneInput { get; set; } //инотропная поддержка 1 поле
        public List<string[]> InotropicSupportTwo { get; set; } //инотропная поддержка 2
        public string InotropicSupportTwoInput { get; set; } //инотропная поддержка 2 поле
    }

}
