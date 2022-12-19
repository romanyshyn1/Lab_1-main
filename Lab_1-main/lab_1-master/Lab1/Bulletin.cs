using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Bulletin : PrintedEdition
    {
        public string ballot_number { get; set; }
        public string data_release { get; set; }


        public Bulletin(string type,
            string isbn,
            string address_edition,
            string name_editor,
            string address_editor,
            int circulation,
            int publication_frequency,
            string site_address,
            string ballot_number,
            string data_release) : base(type, isbn, address_edition, name_editor,
                 address_editor, circulation, publication_frequency, site_address)
        {
            this.ballot_number = ballot_number;
            this.data_release = data_release;


        }
        public void PrintBulletin()
        {
            base.Print();
            Console.WriteLine($"Назва: {ballot_number}");
            Console.WriteLine($"Дата релiзу: {data_release}");
        }
    }
}
