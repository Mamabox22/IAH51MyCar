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

namespace Autosausleihen
{
    public partial class Anmeldung : Form
    {
        MySQL mysql = new MySQL();
        bool AGBs = false;

        public Anmeldung()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            // Noch Pflichtfeld abgrage nötig#
            // && TBREmail is null && TBRAdresse is null && TBRPasswort is null && TBRZahlung is null

                if (TBRPasswort.Text == TBRPasswortW.Text)
                {


                    if (AGBs == false)
                    {
                        MessageBox.Show("Du musst die AGB's bestätigen");
                    }
                    else
                    {
                        // mysql.Insert(TBRName.Text, TBRVorname.Text, TBRAdresse.Text, TBROrt.Text, TBRPostleitzahl.Text, TBREmail, TBRTelefon.Text,TBRPasswort.Text,TBRPasswortW.Text);
                        AutoAnzeige Auswahl = new AutoAnzeige();
                        Auswahl.Show();
                        Close();
                    }

                }
                else
                {
                    MessageBox.Show("Passwort muss gleich sein!");
                }
            //}
            //else
            //{
            //    MessageBox.Show("Alle Pflichtfelder müssen ausgefüllt werden!");
            //}
        }

        private void CBAGBs_CheckedChanged(object sender, EventArgs e)
        {
            AGBs = true;
        }

        private void Anmeldung_Load(object sender, EventArgs e)
        {

        }


        // Fehler! Wenn man die Checkbox anklickt und dann wieder aus ist der bool noch gesetzt
    }
}
