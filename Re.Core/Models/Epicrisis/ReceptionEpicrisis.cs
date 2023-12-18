using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable
namespace Re.Core.Models
{
    public class ReceptionEpicrisis
    {
        public string Id { get; set; }
        [DisplayName("Дата")]
        public DateOnly Date { get; set; }
        [DisplayName("Время")]
        public TimeOnly Time { get; set; }
        [DisplayName("Доставлен из")]
        public string DeliveredFrom { get; set; }
        [DisplayName("ИВЛ при транспортировке")]
        public string AVLDueTransportation { get; set; }

        [DisplayName("Жалобы")]
        public string Complaints { get; set; }

        [DisplayName("Жалобы(пояснения)")]
        public string ComplaintText { get; set; }

        [DisplayName("ВАШ")]
        public string VAS { get; set; }

        [DisplayName("Состояние")]
        public string Condition { get; set; }

        [DisplayName("Сознание")]
        public string Conscience { get; set; }

        [DisplayName("Ramsey")]
        public string Ramsey { get; set; }

        [DisplayName("Тонус мышц")]
        public string MuscleTone { get; set; }

        [DisplayName("Кожные покровы")]
        public string[] SkinCovers { get; set; } = new string[3];

        [DisplayName("Цианоз")]
        public string Cyanosis { get; set; }

        [DisplayName("Мраморность")]
        public string Marbling { get; set; }

        [DisplayName("Периферические отеки")]
        public string PeripheralEdema { get; set; }

        [DisplayName("В/в катетер")]
        public string[] VeinsToBeCatheterized { get; set; } = new string[2];

        [DisplayName("Воспаления в области установки катетера")]
        public string InflammationInCatheter { get; set; }

        [DisplayName("Спонтанное дыхание")]
        public string SpontaneousBreathing { get; set; }

        [DisplayName("Дыхание через")]
        public string BreathingThrough { get; set; }

        [DisplayName("Нарушение дыхания")]
        public string BreathingDisorder { get; set; }

        [DisplayName("Частота дыхания")]
        public int RespiratoryRate { get; set; }

        [DisplayName("Аускультативно")]
        public string Auscultatory { get; set; }

        [DisplayName("Ослабление дыхания")]
        public string[] BreathingRate { get; set; } = new string[2];

        [DisplayName("Хрипы")]
        public string[] Wheezes { get; set; } = new string[3];

        [DisplayName("Респираторная поддержка")]
        public string RespiratorySupport { get; set; }

        [DisplayName("Инсуфляция кислорода через")]
        public string OxygenInsufflation { get; set; }

        [DisplayName("V")]
        public int Volume { get; set; }

        [DisplayName("Аппаратом")]
        public string Device { get; set; }

        [DisplayName("Режим")]
        public string Mode { get; set; }

        [DisplayName("ДО")]
        public int Till { get; set; }

        [DisplayName("Инотропы/вазопрессоры")]
        public string Inotropes { get; set; }

        [DisplayName("Инотропы(значение)")]
        public int InotropesValue { get; set; }

        [DisplayName("Единица измерения")]
        public string InotropesUnits { get; set; }

        [DisplayName("Инотропы(описание)")]
        public string InotropesDescription { get; set; }

        [DisplayName("ЧД апп.")]
        public int BR { get; set; }

        [DisplayName("Pinsp")]
        public int Pinsp { get; set; }

        [DisplayName("Psupp")]
        public int Psupp { get; set; }

        [DisplayName("PEEP")]
        public int PEEP { get; set; }

        [DisplayName("FiO2")]
        public int FiO2 { get; set; }

        [DisplayName("Гемодинамика")]
        public string Hemodynamics { get; set; }

        [DisplayName("Артериальное давление")]
        public int[] ArtherialPressure { get; set; } = new int[2];

        [DisplayName("Пульс")]
        public int Pulse { get; set; }

        [DisplayName("Ритм пульса")]
        public string PulseRhythm { get; set; }

        [DisplayName("Частота сердечных сокращений")]
        public int HeartRate { get; set; }

        [DisplayName("SpO2")]
        public int SpO2 { get; set; }

        [DisplayName("Живот")]
        public string Abdomen { get; set; }

        [DisplayName("Живот(описание)")]
        public string AbdomenText { get; set; }

        [DisplayName("Болезненности")]
        public string Pain { get; set; }

        [DisplayName("Болезненности(описание)")]
        public string PainText { get; set; }

        [DisplayName("Живот вздут")]
        public string Distension { get; set; }

        [DisplayName("Вздут(описание)")]
        public string DistensionText { get; set; }

        [DisplayName("Перистальтика")]
        public string Peristalsis { get; set; }

        [DisplayName("Язык")]
        public string[] Tongue { get; set; } = new string[2];

        [DisplayName("Диурез")]
        public double Diuresis { get; set; }

        [DisplayName("Моча")]
        public string Urine { get; set; }

        [DisplayName("Дренажи")]
        public string Drainage { get; set; }

        [DisplayName("Лабораторные данные")]
        public string LaboratoryData { get; set; }

        [DisplayName("Дополнительно")]
        public string Addition { get; set; }

        [DisplayName("Тяжесть состояния обусловлена")]
        public string SeverityOfCondition { get; set; }

        [DisplayName("План лечения")]
        public string TreatmentPlan { get; set; }

        [DisplayName("Врач")]
        public virtual Doctor Doctor { get; set; }
    }
}
