using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable

namespace Re.Core.Models.Hemo
{
    public class HemoProtocol
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string FIO { get; set; } //фио реципиента
        public int Number { get; set; } //№ карты
        public string Group { get; set; } //группа крови реципиента
        public string Phenotype { get; set; } //фенотип
        public string Place { get; set; } //где определяли
        public string Indication { get; set; } //показания
        public string Anamnesis { get; set; } //анамнез
        public string Component { get; set; } //компонент
        public string Mfr { get; set; } //изготовитель
        public int NumberCont { get; set; } //номер контейнера
        public int Volume { get; set; } //объем
        public int Code { get; set; } //код донора
        public string GroupDonor { get; set; } //группа крови донора
        public string Reagents { get; set; } //реактивы
        public string Compatibility { get; set; } //совместимость
        public string BiologicalSample { get; set; } //биологическая проба
        public string Transfusion { get; set; } //способ трансфузии
        public string Complications { get; set; } //осложнения
        public string AD { get; set; } //АД перед переливанием
        public string ADhafter { get; set; } //АД через 1 час
        public string AD2hafter { get; set; } //АД через 2 часа
        public string HR { get; set; } //ЧСС перед переливанием
        public string HRhafter { get; set; } //ЧСС через 1 час
        public string HR2hafter { get; set; } //ЧСС через 2 часа
        public string T { get; set; } //Т перед переливанием
        public string Thafter { get; set; } //T через 1 час
        public string T2hafter { get; set; } //T через 2 часа
        public string Diuresis { get; set; } //диурез,цвет мочи перед переливанием
        public string Diuresishafter { get; set; } //диурез,цвет мочи через 1 час
        public string Diuresis2hafter { get; set; } //диурез,цвет мочи через 2 часа
        public Doctor Doctor { get; set; }
    }

    public class ErythrocyteProtocol : HemoProtocol
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class SZPProtocol : HemoProtocol
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class ThrombocyteProtocol : HemoProtocol
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


    }
}