using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autosausleihen.Model
{
    class AutoModel
    {
        public AutoModel(string Hersteller, string Modell, string Name, string Farbe) //int Sitzplätze, int Variante, int Buajahr
        {
            this.Hersteller = Hersteller;
            this.Modell = Modell;
            this.Name = Name;
            //this.Baujahr = Baujahr;
            //this.Sitzplätze = Sitzplätze;
            this.Farbe = Farbe;
            //this.Variante = Variante;
        }

        public string Hersteller { get; set; }

        public string Modell { get; set; }

        public string Name { get; set; }

        public int Baujahr { get; set; }

        public int Sitzplätze { get; set; }

        public string Farbe { get; set; }

        public int Variante { get; set; }
    }
}
