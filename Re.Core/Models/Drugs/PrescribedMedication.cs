using System.ComponentModel;

namespace Re.Core.Models;

public class PrescribedMedication
{

    public int Id { get; set; }//ID
    [DisplayName("Дата")]
    public DateOnly Date { get; set; }
    [DisplayName("Время")]
    public TimeOnly Time { get; set; }
    [DisplayName("Кол-во мл")]

    public int Volume { get; set; }//Кол-во мл
    [DisplayName("Насыщение кислородом")]

    public int Аmpoule { get; set; }//Кол-во ампул
    [DisplayName("Кол-во ампул")]

    public int Tablet { get; set; }//Кол-во таблеток
    [DisplayName("Кол-во таблеток")]

    public int TTC { get; set; }//Кол-во TTC
    [DisplayName("Кол-во TTC")]

    public string Purpose { get; set; }//Показание 
    [DisplayName("Показание ")]

    public string Medication { get; set; }//Препарат 
    [DisplayName("Препарат ")]

    public string Injection { get; set; }//Путь введения
    [DisplayName("Путь введения")]

    public string Doctor { get; set; }//Врач 

    //public Doctor Doctor { get; set; }//Врач 

    public PrescribedMedication(){
       
        Purpose = "";
        Medication = "";
        Injection = "";
        Doctor = "";
    }

}