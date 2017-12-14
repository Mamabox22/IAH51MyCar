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
      
        int ValueTelefon;
        int ValuePLZ;
        public Anmeldung()
        {
            InitializeComponent();
            TBRInsert.Enabled = false;
        }

        public void RegistrierenButtonEnableDisable() //Diese Methode dient dazu den Registrierenbutton erst dann freizugeben wenn in alle Pflichtfelder etwas eingetragen wurde. Die Passwörter müssen auch gleich sein.
        {
            if (!string.IsNullOrWhiteSpace(TBRName.Text) & !string.IsNullOrWhiteSpace(TBREmail.Text) & !string.IsNullOrWhiteSpace(TBRPasswort.Text) & !string.IsNullOrWhiteSpace(TBRPasswortW.Text) & !string.IsNullOrWhiteSpace(TBRAdresse.Text) & !string.IsNullOrWhiteSpace(TBRZahlung.Text) & !string.IsNullOrWhiteSpace(TBRPostleitzahl.Text) & CBAGBs.Checked == true & TBRPasswort.Text == TBRPasswortW.Text)
            {
                TBRInsert.Enabled = true;
            }
            else
            {
                TBRInsert.Enabled = false;
            }
        }

        public void Passwortprufen() //Prüft ob die Passwörter gleich sind, falls nicht wird ein Label angezeigt und der RegistrierenButton kann nicht gedrückt werden.
        {
            if (TBRPasswort.Text != TBRPasswortW.Text)
            {
                LBpwprüfen.Visible = true;
                TBRInsert.Enabled = false;
            }
            else if (TBRPasswort.Text == TBRPasswortW.Text)
            {
                LBpwprüfen.Visible = false;
                RegistrierenButtonEnableDisable();
            }
        }

        //In der Region findet man alle Befehle die in Kraft treten wenn man den Inhalt der Textboxen verändert.
        #region Textboxen Textchanged 
        private void TBRAdresse_TextChanged(object sender, EventArgs e)
        {
            RegistrierenButtonEnableDisable();
        }

        private void TBRPostleitzahl_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TBRPostleitzahl.Text))
            {
                if (!Int32.TryParse(TBRPostleitzahl.Text, out ValuePLZ))
                {
                    MessageBox.Show("Postleitzahl ungültig. Bitte nur Zahlen verwenden.");
                    TBRPostleitzahl.Clear();
                }
                else
                {
                    RegistrierenButtonEnableDisable();
                }
            }
        }

        private void TBRZahlung_TextChanged(object sender, EventArgs e)
        {
            RegistrierenButtonEnableDisable();
        }

        private void TBRPasswortW_TextChanged(object sender, EventArgs e)
        {
            Passwortprufen();
        }

        private void TBRPasswort_TextChanged(object sender, EventArgs e)
        {
            Passwortprufen();
        }

        private void TBREmail_TextChanged(object sender, EventArgs e)
        {
            RegistrierenButtonEnableDisable();
        }

        private void TBRName_TextChanged(object sender, EventArgs e)
        {
            RegistrierenButtonEnableDisable();
        }

        private void TBRVorname_TextChanged(object sender, EventArgs e)
        {
            RegistrierenButtonEnableDisable();
        }

        private void TBRTelefon_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TBRTelefon.Text))
            {
                if (!Int32.TryParse(TBRTelefon.Text, out ValueTelefon))
                {
                    MessageBox.Show("Telefonnummer ungültig. Bitte nur Zahlen verwenden.");
                    TBRTelefon.Clear();
                }
                else
                {
                    RegistrierenButtonEnableDisable();
                }
            }
        }

        private void TBRUsername_TextChanged(object sender, EventArgs e)
        {
            RegistrierenButtonEnableDisable();
        }

        private void TBROrt_TextChanged(object sender, EventArgs e)
        {
            RegistrierenButtonEnableDisable();
        }
        #endregion
        private void CBAGBs_CheckedChanged(object sender, EventArgs e)
        {
            RegistrierenButtonEnableDisable();
        }

        private void TBRInsert_Click(object sender, EventArgs e)
        {

            if (TBRPasswort.Text == TBRPasswortW.Text)
            {

                MySQL.InsertUser(new Model.UserModel(TBRName.Text, TBRVorname.Text, TBREmail.Text, ValueTelefon, TBRAdresse.Text, ValuePLZ, TBROrt.Text, TBRUsername.Text, TBRPasswort.Text));
                AutoAnzeige Auswahl = new AutoAnzeige();
                Auswahl.Show();

            }
          
        }

    }

}
