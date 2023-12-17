namespace Re.Core.Models;

public class Patient{

    public int Id { get; set; }//ID
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }

    public string FIO { get; set; }//ФИО

    public string Adress { get; set; }//Место?

    public string Peculiarity { get; set; }//Особенности пульса

    public string VAS { get; set; }//ВАШ

  

    public string Notes { get; set; }//Дополнительно

    public int ArtPresUp { get; set; }//Систолическое давление

    public int ArtPresDown { get; set; }//Диастолическое давление

    public int Pulse { get; set; }//Пульс

    public int SpO2 { get; set; }//Насыщение кислородом


}