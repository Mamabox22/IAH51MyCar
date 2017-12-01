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
            // Noch Pflichtfeld abgrage nötig
            if (TBRPasswort.Text == TBRPasswortW.Text)
            {


                if (AGBs == false)
                {
                    MessageBox.Show("Du musst die AGB's bestätigen");
                }
                else
                {
                    // mysql.Insert(TBRName.Text, TBRVorname.Text, TBRAdresse.Text, TBROrt.Text, TBRPostleitzahl.Text, TBREmail, TBRTelefon.Text);
                    MessageBox.Show("Hat geklappt!");
                    AutoAnzeige Auswahl = new AutoAnzeige();
                    Auswahl.Show();
                    Close();
                }

            }
            else
            {
                MessageBox.Show("Passwort muss gleich sein!");
            }
            
        }

        private void CBAGBs_CheckedChanged(object sender, EventArgs e)
        {
            AGBs = true;
        }


        // Fehler! Wenn man die Checkbox anklickt und dann wieder aus ist der bool noch gesetzt
    }
}
