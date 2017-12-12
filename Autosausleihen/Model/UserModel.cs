using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autosausleihen.Model
{
    class UserModel
    {

        public string Name { get; set; }

        public string Vorname { get; set; }

        public string Email { get; set; }

        public string Telefon { get; set; }

        public string Adresse { get; set; }

        public string Postleitzahl { get; set; }

        public string Ort { get; set; }

        public string Username { get; set; }

        public string Passwort { get; set; }

        public bool Admin { get; set; }
        

    }
}
