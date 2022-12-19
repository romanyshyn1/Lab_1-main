using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class PrintedEdition
    {
        private string type { get; set; }
        private string isbn { get; set; }
        private string address_edition { get; set; }
        private string name_editor { get; set; }
        private string address_editor { get; set; }
        private int circulation { get; set; }
        private int publication_frequency { get; set; }
        private string site_address { get; set; }
        
        public PrintedEdition(string type,
            string isbn,
            string address_edition,
            string name_editor,
            string address_editor,
            int circulation,
            int publication_frequency,
            string site_address)
        {
            this.type = type;
            this.isbn = isbn;
            this.address_edition = address_edition;
            this.name_editor = name_editor;
            this.address_editor = address_editor;
            this.circulation = circulation;
            this.publication_frequency = publication_frequency;
            this.site_address = site_address;
        }

        public void Print()
        {
            Console.WriteLine($"Тип: {type}");
            Console.WriteLine($"ISBN: {isbn}");
            Console.WriteLine($"Адреса редакцiї: {address_edition}");
            Console.WriteLine($"П.I.П.: {name_editor}");
            Console.WriteLine($"Адреса головного редактора: {address_editor}");
            Console.WriteLine($"Перiодичнiсть виходу друком: {circulation}");
            Console.WriteLine($"Тираж: {publication_frequency}");
            Console.WriteLine($"Iнтернет адреса: {site_address}");

        }
    }
}
