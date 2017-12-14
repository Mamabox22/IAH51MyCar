using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Autosausleihen.Model
{
    class UserModel
    {
        public UserModel(string name, string vorname, string email, int telefon, string adresse, int postleitzahl, string ort, string username,string passwort)
        {
            Name = name;
            Vorname = vorname;
            Email = email;
            Telefon = telefon;
            Adresse = adresse;
            Postleitzahl = postleitzahl;
            Ort = ort;
            Username = username;
            Passwort = passwort;


        }
        public string Name { get; set; }

        public string Vorname { get; set; }

        public string Email { get; set; }

        public int Telefon { get; set; }

        public string Adresse { get; set; }

        public int Postleitzahl { get; set; }

        public string Ort { get; set; }

        public string Username { get; set; }

        public string Passwort { get; set; }

        public bool Admin { get; set; }
        

    }
}
