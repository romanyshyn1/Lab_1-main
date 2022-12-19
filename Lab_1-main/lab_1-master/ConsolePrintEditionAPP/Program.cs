using System;
using Lab1;

namespace ConsolePrintEditionAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Швець О.Я. СН-41");
            Console.WriteLine();
            Console.WriteLine("================================================");
            Newspaper newspaper = new Newspaper("Газета", "978-5-91147-039-5", "м.Тернопiль, вул. Крушельницької 1а", "Олександр Стерненко", "село Досова, Хмельницька обл.", 1500, 1/30, "nova.te.ua/", "Нова", 15420, "8.05.2022");
            newspaper.PrintNewspaper();
            Console.WriteLine("================================================");
            Journal journal = new Journal("Журнал", "2708-3268-02", "Адреса вилавництва", "Благодiйний Семен", "Невiдома", 6200, 1/2, "forbes.ua/", "forbes", 25000, "Країна Героїв");
            journal.PrintJournal();
            Console.WriteLine("================================================");
            Bulletin bulletin = new Bulletin("Бюлетень", "978-617-7538-64-5", "м. Київ, вул. Льва Толстого, 14А", "Невiдомо", "Невiдома", 60000, 1/365, "-", "452168", "10.11.2017");
            bulletin.PrintBulletin();
        }
    }
}