using System.ComponentModel;

namespace Re.Core.Models;

public class Syndrom
{

    public int Id { get; set; }//ID
    [DisplayName("Дата")]
    public DateOnly Date { get; set; }
    [DisplayName("Время")]
    public TimeOnly Time { get; set; }
    [DisplayName("Описание синдрома")]

    public string Description { get; set; }//Описание синдрома
    [DisplayName("ВАШ")]

    public string VAS { get; set; }//ВАШ
    [DisplayName("Систолическое давление")]

    public int ArtPresUp { get; set; }//Систолическое давление
    [DisplayName("Диастолическое давление")]

    public int ArtPresDown { get; set; }//Диастолическое давление
    [DisplayName("Пульс")]

    public int Pulse { get; set; }//Пульс
    [DisplayName("Насыщение кислородом")]

    public int SpO2 { get; set; }//Насыщение кислородом
    [DisplayName("Дополнительно")]

    public string Notes { get; set; }//Дополнительно

    [DisplayName("Дежурный реаниматолог")]

    public string Resuscitator { get; set; }//Дежурный реаниматолог
    [DisplayName("Особенности пульса")]

    public string Peculiarity { get; set; }//Особенности пульса

    [DisplayName("Состояние пациента")]
    public string Status { get; set; }//Состояние пациента
}