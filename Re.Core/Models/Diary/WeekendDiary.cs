using Re.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace Re.Core.Models
{
    public class WeekendDiary
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public Doctor Doctor { get; set; }
        public Doctor DoctorTwo { get; set; }
        public Doctor DoctorThree { get; set; }
        public Doctor DoctorFour { get; set; }
        public Doctor DoctorFive { get; set; }
        public string Patient { get; set; } //пациент
        public int Age { get; set; } //возраст
        public int Day { get; set; } //сутки
        public int OperationDay { get; set; } //после операции сутки
        public string Сonditions { get; set; } // состояние
        public string Сomplaints { get; set; } //жалобы
        public string ComplaintsAbout { get; set; } //жалобы на
        public string Conscience { get; set; } //сознание
        public string RassThis { get; set; } //RASS поле ввода
        public string Rass { get; set; } //RASS 
        public string Neurologist { get; set; } //Неврологический статус
        public string[] Skin { get; set; } = new string[3]; //кожные  покровы
        public string Breathing { get; set; } //дыхание
        public string Extubation { get; set; } //экстубация
        public int CddField { get; set; } //ЧДД
        public string InhalationO2 { get; set; } //ингаляция О2
        public int SpeedFlow { get; set; } //скорость потока
        public string Auscultatory { get; set; } //аускультативно
        public string[] ShortnessOfBreath { get; set; } = new string[2]; //ослабление дыхания 
        public string ShortnessOfBreathInput { get; set; } //ослабление дыхания поле ввода
        public string[] Wheezes { get; set; } = new string[3]; //хрипы
        public string RespiratorySupport { get; set; } //респираторная поддержка
        [NotMapped]
        public string[] RespiratorySupportMachine { get; set; } = new string[2]; //респираторная поддержка аппарат
        public int Do { get; set; } //ДО
        public int Cd { get; set; } //ЧД
        public int Pdkv { get; set; } //ПДКВ
        public int Fio2 { get; set; } //FiO2
        public int Dvdox { get; set; } //Двдох
        public int Dpod { get; set; } //Дпод
        public string Hemodynamics { get; set; } //Гемодинамика
        public string[] InotropicSupportOne { get; set; } = new string[2]; //инотропная поддержка 1
        public int InotropicSupportOneInput { get; set; } //инотропная поддержка 1 поле
        public int Ad { get; set; } //АД
        public int Сhss { get; set; } //ЧСС
        public int Spo2 { get; set; } //ЧСС
        public string Stomach { get; set; } //Живот
        public string Pain { get; set; } //Болезненность
        public string PainAbout { get; set; }
        public string[] AbdominalBloating { get; set; } = new string[2]; //Вздутие живота
        public string Peristalsis { get; set; } //Перистальтика
        public string[] Tongue { get; set; } = new string[2]; //Язык
        public int Diuresis { get; set; } //диурез
        public string Urine { get; set; } //Моча
        public int BodyTemperature { get; set; } //температура тела
        public string[] Drainage { get; set; } = new string[3]; //дренаж
        public string DrinageAbout { get; set; }
        public string[] DrainageTwo { get; set; } = new string[3]; //дренаж
        public string DrinageAboutTwo { get; set; }
        public string Additionally { get; set; } //дополнительно
        public string SeverityOfCondition { get; set; }
        public int Laboratory1 { get; set; }
        public int Laboratory2 { get; set; }
        public int Laboratory3 { get; set; }
        public int Laboratory4 { get; set; }
        public int Laboratory5 { get; set; }
        public int Laboratory6 { get; set; }
        public string Recommended { get; set; } //рекомендовано
        public int Analyses { get; set; } //Анализы
        public int AnalysesTwo { get; set; } //Анализы
        public int AnalysesThree { get; set; } //Анализы
        public int AnalysesFour { get; set; } //Анализы
        public int AnalysesFive { get; set; } //Анализы
        public int AnalysesSix { get; set; } //Анализы
        public int BioChemistry { get; set; } //Биохимия
        public int BioChemistry2 { get; set; } //Биохимия
        public int BioChemistry3 { get; set; } //Биохимия
        public int BioChemistry4 { get; set; } //Биохимия
        public int BioChemistry5 { get; set; } //Биохимия
        public int BioChemistry6 { get; set; } //Биохимия
        public int BioChemistry7 { get; set; } //Биохимия
        public int BioChemistry8 { get; set; } //Биохимия
        public int Hemostasis { get; set; } //гемостаз
        public int Hemostasis2 { get; set; } //гемостаз
        public int Hemostasis3 { get; set; } //гемостаз
        public int Kshs { get; set; } //КЩС
        public int Kshs2 { get; set; } //КЩС
        public int Kshs3 { get; set; } //КЩС
        public int Kshs4 { get; set; } //КЩС
        public int Kshs5 { get; set; } //КЩС
        public int Kshs6 { get; set; } //КЩС
        public int Kshs7 { get; set; } //КЩС
        public int Kshs8 { get; set; } //КЩС
        public int Kshs9 { get; set; } //КЩС
        public int Picco { get; set; } //PICCO-тест
        public int Picco2 { get; set; } //PICCO-тест
        public int Picco3 { get; set; } //PICCO-тест
        public int Picco4 { get; set; } //PICCO-тест
        public int Picco5 { get; set; } //PICCO-тест
        public int Picco6 { get; set; } //PICCO-тест
        public int Picco7 { get; set; } //PICCO-тест
        public int Picco8 { get; set; } //PICCO-тест
        public int Picco9 { get; set; } //PICCO-тест
        public int Picco10 { get; set; } //PICCO-тест
        public int Picco11 { get; set; } //PICCO-тест
        public int Analyses1 { get; set; } //Анализы
        public int Analyses2 { get; set; } //Анализы
        public int Analyses3 { get; set; } //Анализы
        public int Product { get; set; }
    }
}
