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

        public string[] conditions { get; set; } // состояние
        public string[] complaints { get; set; } //жалобы
        public string complaintAbout { get; set; } //жалобы на
        public string RASSthis { get; set; } //RASS
        public string[] VASH { get; set; } //жалобы
        public string[] conscience { get; set; } //сознание
        public string[] RASS { get; set; } //сознание
        public string[] skin { get; set; } //кожные покровы
        public string[] humidity { get; set; } //влажность кожных покровов
        public string[] colorskin { get; set; } //цвет кожных покровов
        public string[] breathing { get; set; } //дыхание
        public string[] extubation { get; set; } //экстубация
        public string CDDField { get; set; } //ЧДД
        public string[] inhalationO2 { get; set; } //ингаляция О2
        public string SpeedFlow { get; set; } //скорость потока
        public string[] auscultatory { get; set; } //аускультативно
        public string[] ShortnessOfBreath { get; set; } //ослабление дыхания
        public string[] ShortnessOfBreathParties { get; set; } //стороны ослабления дыхания
        public string shortnessBreaths { get; set; } //ослабление дыхания поле ввода
        public string[] Wheezes { get; set; } //хрипы
        public string[] WheezesParties { get; set; } //стороны хрипов
        public string[] WheezesDescription { get; set; } //описание хрипов
        public StandartDiary()
        {

            conditions = new string[] {
                "удовлетворительное.",
                "средней тяжести.",
                "тяжелое.",
                "крайне тяжелое.",
                "терминальное.",
                "клинической смерти."
            };

            complaints = new string[] {
                "Жалоб нет.",
                "Жалобы не предъявляет из - за тяжести состояния.",
                "Не предъявляет жалоб из - за седации.",
                "Жалобы прежние.",
                "Предъявляет жалобы на",
                "Жалобы на боли в области операции."
            };

            VASH = new string[] {
            "1 б.",
            "2 б.",
            "3 б.",
            "4 б.",
            "5 б.",
            "6 б.",
            "7 б.",
            "8 б.",
            "9 б.",
            "10 б.",
            };
            conscience = new string[] {
                "ясное.",
                "оглушение.",
                "глубокое оглушение.",
                "сопор.",
                "кома I.",
                "кома II.",
                "кома III.",
                "медикаментозная седация."
            };

            RASS = new string[] {
                "- 5 баллов по шкале RASS.",
                "- 4 балла по шкале RASS.",
                "- 3 балла по шкале RASS.",
                "- 2 балла по шкале RASS.",
                "- 1 балл по шкале RASS.",
                "0 баллов по шкале RASS.",
                "+ 1 балл по шкале RASS.",
                "+ 2 балла по шкале RASS.",
                "+ 3 балла по шкале RASS.",
                "+ 4 балла по шкале RASS."
            };

            RASSthis = " С целью потенцирования эффекта анальгетической терапии вводится в/в микроструйно Дексмедетомидин в дозировке 0.7 мкг/кг/час.";

            skin = new string[]
            {
                "теплые.",
                "холодные."
            };

            humidity = new string[]
            {
                "сухие,",
                "влажные,",
                "естественной влажности,"
            };

            colorskin = new string[]
           {
                "естественной окраски.",
                "бледные.",
                "бледно-розовые."
           };

            breathing = new string[]
            {
                "естественные дыхательные пути.",
                "эндотрахеальную трубку.",
                "ларингеальную маску.",
                "трахеостомическую канюлю.",
                "воздуховод."
            };
            extubation = new string[]
            {
                ",",
                "а,"
            };

            inhalationO2 = new string[]
            {
                "носовые канюли.",
                "HFOT аппаратом. Airvo 2",
                "лицевую маску.",
                "CPAP - клапан.",
                "'искусственнный нос'",
            };

            auscultatory = new string[]
            {
                "дыхание жесткое.",
                "дыхание везикулярное.",
                "дыхание пуэрильное."
            };

            ShortnessOfBreath= new string[]
           {
                "есть,",
                "нет."
           };

            ShortnessOfBreathParties = new string[]
          {
                "с двух сторон.",
                "справа.",
                "слева"
          }; 
            
            Wheezes = new string[]
          {
                "есть,",
                "нет."
          };

            WheezesParties = new string[]
          {
                "с двух сторон.",
                "справа.",
                "слева"
          };
            WheezesDescription = new string[]
          {
                "нет.",
                "сухие",
                "влажные",
                "крепитирующие",
                "проводные"
          };

        }

    }

}
