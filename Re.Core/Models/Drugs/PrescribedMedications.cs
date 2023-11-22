namespace Re.Core.Models;

public class PrescribedMedications
{
   
    public int Id { get; set; }//ID

    public int Volume { get; set; }//Кол-во мл

    public int Аmpoule { get; set; }//Кол-во ампул

    public string Purpose { get; set; }//Показание 

    public string Medication { get; set; }//Препарат 

    public string Injection { get; set; }//Путь введения

    
    public Doctor Doctor { get; set; }//Врач 



}