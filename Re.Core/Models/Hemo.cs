using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re.Core.Models
{
    public class Hemo
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
        public Hemo()
        {
            Name = "ЭПИКРИЗ НА ПЕРЕЛИВАНИЕ КОМПОНЕНТОВ КРОВИ";
            GroupRh = new string[]
            {
                "0(I) Rh- (отрицательный)",
                "A(II) Rh- (отрицательный)",
                "A₂(II) Rh- (отрицательный)",
                "B(III) Rh- (отрицательный)",
                "AB(IV) Rh- (отрицательный)",
                "0(I) Rh+ (положительный)",
                "A(II) Rh+ (положительный)",
                "A₂(II) Rh+ (положительный)",
                "B(III) Rh+ (положительный)",
                "AB(IV) Rh+ (положительный)",
            };
            Indications = new string[]
            {
                "анемия тяжелой степени",
                "дефицит факторов свертывания",
                "анемия тяжелой степени и деф. факторов свертывания",
                "тромбоцитопения"
            };
            Doctor = new string[]
            {
                "Розенгард С.А.",
                "Глущенко В.А.",
                "Алиева А.Э.",
                "Борзых И.С.",
                "Веденин Я.О.",
                "Горохов Л.В.",
                "Груздов М.С.",
                "Гурин М.Н.",
                "Зубайдов М.М.",
                "Ишкараев В.Э.",
                "Караваев А.В.",
                "Кононец Ф.А.",
                "Кремзель Е.Г,",
                "Митрохина М.В.",
                "Нюхлов Е.С.",
                "Пазюк К.И.",
                "Пастухова А.А.",
                "Попель И.В.",
                "Раевская О.А.",
                "Сапронова Т.Н.",
                "Семенов А.Н.",
                "Склярова В.О.",
                "Хестанова Н.З.",
                "Шабут А.М."
            };
        }
    }
}
