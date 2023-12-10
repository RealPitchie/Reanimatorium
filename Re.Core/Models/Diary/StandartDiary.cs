﻿using Re.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace Re.Core.Models
{
    public class StandartDiary
    {
        public string Id { get; set; }
        public DateOnly Date { get; set; } //Дата
        public TimeOnly Time { get; set; } //Время

        public string[] Сonditions { get; set; } // состояние
        public string[] Сomplaints { get; set; } //жалобы
        public string ComplaintsAbout { get; set; } //жалобы на
        public string RassThis { get; set; } //RASS поле ввода
        public string[] Rass { get; set; } //RASS 
        public string[] Vash { get; set; } //ВАШ
        public string[] Conscience { get; set; } //сознание
        public string[] Skin { get; set; } = new string[3]; //кожные  покровы
        public string[] Breathing { get; set; } //дыхание
        public string[] Extubation { get; set; } //экстубация
        public string CddField { get; set; } //ЧДД
        public string[] InhalationO2 { get; set; } //ингаляция О2
        public string SpeedFlow { get; set; } //скорость потока
        public string[] Auscultatory { get; set; } //аускультативно
        public string[] ShortnessOfBreath { get; set; } = new string[2]; //ослабление дыхания 

        public string ShortnessOfBreathInput { get; set; } //ослабление дыхания поле ввода
        public string[] Wheezes { get; set; } = new string[3]; //хрипы
        public string[] RespiratorySupport { get; set; } //респираторная поддержка
        public string[] RespiratorySupportMachine { get; set; } = new string[2]; //респираторная поддержка аппарат
        public string[] InotropicSupportOne { get; set; } = new string[2]; //инотропная поддержка 1
        public string InotropicSupportOneInput { get; set; } //инотропная поддержка 1 поле
        public string[] InotropicSupportTwo { get; set; } = new string[2]; //инотропная поддержка 2
        public string[] Hemodynamics { get; set; } //Гемодинамика
        public string InotropicSupportTwoInput { get; set; } //инотропная поддержка 2 поле
        public int Do { get; set; } //ДО
        public int Cd { get; set; } //ЧД
        public string Pdkv { get; set; } //ПДКВ
        public string Fio2 { get; set; } //FiO2
        public string Dvdox { get; set; } //Двдох
        public string Dpod { get; set; } //Дпод
        public string Ad { get; set; } //АД
        public string Сhss { get; set; } //ЧСС
        public string Spo2 { get; set; } //ЧСС
        public string[] Stomach { get; set; } //Живот
        public string[] Pain { get; set; } //Болезненность
        public string PainAbout { get; set; } //ЧСС
        public string[] AbdominalBloating { get; set; } = new string[2]; //Вздутие живота
        public string[] Peristalsis { get; set; } //Перистальтика
        public string[] Tongue { get; set; } = new string[2]; //Язык
        public string Diuresis { get; set; } //диурез
        public string Intravenously { get; set; } //внутривенно
        public string[] Urine { get; set; } //Моча
        public string BodyTemperature { get; set; } //температура тела
        public string[] Drainage { get; set; } = new string[3]; //дренаж
        public string DrinageAbout { get; set; }
        public string Additionally { get; set; } //дополнительно
        public string Laboratory1 { get; set; }
        public string Laboratory2 { get; set; }
        public string Laboratory3 { get; set; }
        public string Laboratory4 { get; set; }
        public string Laboratory5 { get; set; }
        public string Laboratory6 { get; set; }
        public string[] Doctor { get; set; } //доктор
        public PiCCO Picco { get; set; }
        public PiCCO2 Picco2 { get; set; }
        public FioTrac FioTrac { get; set; }
        public EsCCO EsCCO { get; set; }
        public VoLEF VoLEF { get; set; }
        public int Analyses { get; set; } //Анализы
        public int AnalysesTwo { get; set; } //Анализы
        public int AnalysesThree { get; set; } //Анализы
        public int AnalysesFour { get; set; } //Анализы
        public int AnalysesFive { get; set; } //Анализы
        public int AnalysesSix { get; set; } //Анализы
    }
    public class PiCCO
    {
        public string Id { get; set; }
        public int? CI { get; set; }
        public int? ITBI { get; set; }
        public int? CFI { get; set; }
        public int? SVV { get; set; }
        public int? SVI { get; set; }
        public int? ELWI { get; set; }
        public int? MAP { get; set; }
        public int? GEDI { get; set; }
        public int? CVP { get; set; }
        public int? SVRI { get; set; }
        public string Description { get; set; }
    }
    public class PiCCO2
    {
        public string Id { get; set; }
        public int CI { get; set; }
        public int PVPI { get; set; }
        public int CFI { get; set; }
        public int SVV { get; set; }
        public int SVI { get; set; }
        public int ELWI { get; set; }
        public int MAP { get; set; }
        public int ScvO2 { get; set; }
        public int GEDI { get; set; }
        public int CVP { get; set; }
        public int SVRI { get; set; }
#nullable disable
        public string Description { get; set; }
    }
    public class FioTrac
    {
        public string Id { get; set; }
        public int CCO { get; set; }
        public int SVR { get; set; }
        public int SVV { get; set; }
        public int SV { get; set; }
        public int CVP { get; set; }
        public string Description { get; set; }
    }
    public class EsCCO
    {
        public string Id { get; set; }
        public int EsHCB { get; set; }
        public int EsYO { get; set; }
        public int EsHCI { get; set; }
        public int EsIYO { get; set; }
        public int EsCCC { get; set; }
        public int EsICCC { get; set; }
        public string Description { get; set; }
    }
    public class VoLEF
    {
        public string Id { get; set; }
        public int RHEDV { get; set; }
        public int PCWP { get; set; }
        public int RL { get; set; }
        public int RVEDV { get; set; }
        public int LHEDV { get; set; }
        public int PVR { get; set; }
        public int PAP { get; set; }
        public int CVP { get; set; }
        public int RVEF { get; set; }
        public string Description { get; set; }
    }
}