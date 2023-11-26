namespace Re.Core.Models;

public class Syndrom
{

    public int Id { get; set; }//ID

    public string Description { get; set; }//Описание синдрома

    public string VAS { get; set; }//ВАШ

    public int ArtPresUp { get; set; }//Систолическое давление

    public int ArtPresDown { get; set; }//Диастолическое давление

    public int Pulse { get; set; }//Пульс

    public int SpO2 { get; set; }//Насыщение кислородом

    public string Notes { get; set; }//Дополнительно

    public string Resuscitator { get; set; }//Дежурный реаниматолог

    public string Peculiarity { get; set; }//Особенности пульса


    public string Status { get; set; }//Состояние пациента
}