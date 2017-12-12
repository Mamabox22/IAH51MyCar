using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Autosausleihen.Controller;

namespace Autosausleihen
{
    

    public partial class Anmeldung : Form
    {
        bool AGB;
        public Anmeldung()
        {
            InitializeComponent();
        }
        private void RegistrierungController_CheckedChanged(object sender, EventArgs e)
        {
            AGB = true;
            //Muss noch abgeschaltet werden bei unchecken
        }

        private void AnmeldungController_Click(object sender, EventArgs e)
        {
            // Noch Pflichtfeld abgrage nötig
            if (!(string.IsNullOrWhiteSpace(TBRPasswort.Text) || string.IsNullOrEmpty(TBRPasswort.Text) ||
                string.IsNullOrWhiteSpace(TBRName.Text) || string.IsNullOrEmpty(TBRName.Text) ||
                string.IsNullOrWhiteSpace(TBRAdresse.Text) || string.IsNullOrEmpty(TBRAdresse.Text) ||
                string.IsNullOrWhiteSpace(TBRZahlung.Text) || string.IsNullOrEmpty(TBRZahlung.Text)))

            {


                if (TBRPasswort.Text == TBRPasswortW.Text)
                {


                    if (AGB == false)
                    {
                        MessageBox.Show("Du musst die AGB's bestätigen");
                    }
                    else
                    {
                        
                        MySQL.InsertUser(TBRName.Text, TBRVorname.Text, TBREmail.Text, TBRTelefon.Text, TBRAdresse, TBRPostleitzahl.Text, TBROrt, TBRUsername, TBRPasswort.Text);
                        AutoAnzeige Auswahl = new AutoAnzeige();
                        Auswahl.Show();
                        
                    }

                }
                else
                {
                    MessageBox.Show("Passwort muss gleich sein!");
                }
            }
            else
            {
                MessageBox.Show("Bitte alle Pflichfelder ausfüllen!");
            }

        }
    }
}
