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
        }
    }
}
