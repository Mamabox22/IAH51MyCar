using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autosausleihen.Model
{
    class AutoModel
    {
        public AutoModel(string hersteller, string modell, string name, int baujahr, int sitzplätze, string farbe, int variante, double preis)
        {
            Hersteller = hersteller;
            Modell = modell;
            Name = name;
            Baujahr = baujahr;
            Sitzplätze = sitzplätze;
            Farbe = farbe;
            Variante = variante;
            Preis = preis;
        }

        public string Hersteller { get; set; }

        public string Modell { get; set; }

        public string Name { get; set; }

        public int Baujahr { get; set; }

        public int Sitzplätze { get; set; }

        public string Farbe { get; set; }

        public int Variante { get; set; }

        public double Preis { get; set; }
    }
}
