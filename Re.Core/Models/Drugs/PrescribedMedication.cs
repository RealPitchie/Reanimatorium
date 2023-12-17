namespace Re.Core.Models;

public class PrescribedMedication
{

    public int Id { get; set; }//ID
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }

    public int Volume { get; set; }//Кол-во мл

    public int Аmpoule { get; set; }//Кол-во ампул

    public int Tablet { get; set; }//Кол-во таблеток

    public int TTC { get; set; }//Кол-во TTC

    public string Purpose { get; set; }//Показание 

    public string Medication { get; set; }//Препарат 

    public string Injection { get; set; }//Путь введения

    public string Doctor { get; set; }//Врач 

    //public Doctor Doctor { get; set; }//Врач 

    public PrescribedMedication(){
       
        Purpose = "";
        Medication = "";
        Injection = "";
        Doctor = "";
    }

}