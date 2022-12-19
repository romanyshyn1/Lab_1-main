using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Journal : PrintedEdition
    {
        public string name { get; set; }
        public int output_number { get; set; }
        public string series { get; set; }


        public Journal(string type,
            string isbn,
            string address_edition,
            string name_editor,
            string address_editor,
            int circulation,
            int publication_frequency,
            string site_address,
            string name,
            int output_number,
            string series) : base(type, isbn, address_edition, name_editor,
                address_editor, circulation, publication_frequency, site_address)
        {
            this.name = name;
            this.output_number = output_number;
            this.series = series;

        }
        public void PrintJournal()
        {
            base.Print();
            Console.WriteLine($"Назва: {name}");
            Console.WriteLine($"Номер: {output_number}");
            Console.WriteLine($"Серiя: {series}");
        }
    }
}
