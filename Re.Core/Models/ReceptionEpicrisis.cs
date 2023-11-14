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
        }
    }
}
