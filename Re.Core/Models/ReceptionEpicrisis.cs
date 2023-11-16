using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private string[] skinCover1;
        private string[] skinCover2;
        private string[] skinCover3;

        public string[] Cyanosis { get; set; }
        public string[] Marbling { get; set; }
        public string[] PeripheralEdema { get; set; }

        public List<string[]> VeinsToBeCatheterized { get; set; }
        private string[] catheterType;
        private string[] catheterValue;

        public string[] InflammationInCatheter { get; set; }
        public string[] SpontaneousBreathing { get; set; }
        public string[] BreathingThrough { get; set; }
        public string[] BreathingDisorder { get; set; }
        public string Features { get; set; }
        public ReceptionEpicrisis()
        {
            Name = "Приемный статус";
            DeliveredFrom = new string[]
            {
                "операционной.", "премного отделения.", "поликлиники.",
                "1 отделения.", "2 отделения.", "3 отделения.",
                "4 отделения.", "5 отделения.", "6 отделения.",
                "7 отделения.", "8 отделения.", "9 отделения.",
                "10 отделения.", "11 отделения.", "12 отделения.",
                "13 отделения.", "14 отделения.", "15 отделения.",
                "16 отделения.", "17 отделения.", "18 отделения.",
                "19 отделения.", "20 отделения.", "бригадой СМП.",
            };

            AVLDueTransportation = new string[]
            {
                "нет.", "мешком AMBU.",
                "Dräger Oxylog.", "транспортным аппаратом ИВЛ."
            };

            Complaints = new string[]
            {
                "Жалоб нет.", "Жалобы не предъявляет из-за тяжести состояния.",
                "Не предъявляет жалоб из-за седации.", "Жалобы прежние.",
                "Предъявляет жалобы на", "Жалобы на боли в области операции."
            };

            Vash = new string[]
            {
                "1 б.", "2 б.", "3 б.", "4 б.", "5 б.",
                "6 б.", "7 б.", "8 б.", "9 б.", "10 б.",
            };

            Condition = new string[]
            {
                "удовлетворительное.", "средней тяжести.",
                "тяжелое.", "крайне тяжелое.",
                "терминальное.", "клинической смерти."
            };

            Conscience = new string[]
            {
                "ясное.", "оглушение.",
                "глубокое оглушение.", "сопор.",
                "кома I.","кома II.","кома III.",
                "медикаментозная седация."
            };

            Ramsey = new string[]
            {
                "-5 баллов по шкале RASS.", "-4 балла по шкале RASS.",
                "-3 балла по шкале RASS.", "-2 балла по шкале RASS.",
                "-1 балл по шкале RASS.", "0 баллов по шкале RASS.",
                "1 балл по шкале RASS.", "2 балла по шкале RASS.",
                "3 балла по шкале RASS.", "4 балла по шкале RASS.",
                "5 баллов по шкале RASS."
            };

            MuscleTone = new string[]
            {
                "не нарушен.", "снижен.", "медикаментозно угнетен."
            };

            skinCover1 = new string[]
            {
                "сухие,", "влажные,", "естественной влажности,"
            };
            skinCover2 = new string[]
            {
                "теплые,", "холодные,",
            };
            skinCover3 = new string[]
            {
                "естественной окраски.", "бледные.", "бледно-розовые."
            };
            SkinCovers = new List<string[]>()
            {
                skinCover1, skinCover2, skinCover3
            };

            Cyanosis = new string[]
            {
                "нет.", "губ.", "лица.", "шеи.",
                "верхней половины грудной клетки.", "конечностей.", "диффузный."
            };

            Marbling = new string[]
            {
                "нет.", "конечностей.", "грудной клетки.","живота.",
            };

            PeripheralEdema = new string[]
            {
                "нет.", "нижних конечностей.", "лица.",
                "боковых поверхностей туловища.", "анасакра."
            };

            catheterType = new string[] 
            {
                "периферическая вена.", "центральная вена.",
                "центральный венозный порт."
            };
            catheterValue = new string[]
            {
                "v.subclavia dext.",
                "v.subclavia sin.",
                "v.jugularis int. dext.",
                "v.jugularis in. sin.",
                "v.femoralis dext.",
                "v.femoralis sin."
            };
            VeinsToBeCatheterized = new List<string[]>() { catheterType, catheterValue, };

            InflammationInCatheter = new string[] { "есть.", "нет." };
            SpontaneousBreathing = new string[] { "эффективно.", "неэффективно." };
            BreathingThrough = new string[] 
            { 
                "естественные пути.", "эндотрахеальную трубку.",
                "ларингеальную маску.", "трахеостомическую канюлю.", "воздуховод.",
            };
            BreathingDisorder = new string[] 
            {  
                "нет.", "апноэ.", "трахипноэ.", "брадипноэ.", "периодизация." 
            };
        }
    }
}
