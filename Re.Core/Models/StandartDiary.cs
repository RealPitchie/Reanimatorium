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

        public string[] condition { get; set; } // состояние
        public string[] complaints { get; set; } //жалобы
        public string[] conscience { get; set; } //сознание
        public string[] RASS { get; set; } //сознание
        public string[] skin { get; set; } //кожные покровы
        public string[] humidity { get; set; } //влажность кожных покровов
        public string[] colorskin { get; set; } //цвет кожных покровов
    }


    public class ConditionHuman : StandartDiary
    {
        public ConditionHuman()
        {

            condition = new string[] {
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
        }
        public class Skin : StandartDiary
        {
            public Skin()
            {
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
            }
        }
    }
}