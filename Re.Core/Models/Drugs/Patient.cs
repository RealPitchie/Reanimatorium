using System.ComponentModel;

namespace Re.Core.Models;

public class Patient{

    public int Id { get; set; }//ID
    [DisplayName("Дата")]
    public DateOnly Date { get; set; }
    [DisplayName("Время")]
    public TimeOnly Time { get; set; }
    [DisplayName("ФИО")]

    public string FIO { get; set; }//ФИО
    [DisplayName("Адрес")]

    public string Adress { get; set; }//Место?
    [DisplayName("Пульс")]

    public string Peculiarity { get; set; }//Особенности пульса
    [DisplayName("ВАШ")]

    public string VAS { get; set; }//ВАШ
    [DisplayName("Дополнительно")]
    public string Notes { get; set; }//Дополнительно
    [DisplayName("Систолическое давление")]

    public int ArtPresUp { get; set; }//Систолическое давление
    [DisplayName("Диастолическое давление")]

    public int ArtPresDown { get; set; }//Диастолическое давление
    [DisplayName("Пульс")]

    public int Pulse { get; set; }//Пульс
    [DisplayName("Насыщение кислородом")]

    public int SpO2 { get; set; }//Насыщение кислородом


}