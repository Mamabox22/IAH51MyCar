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
        string Passwortkodiert;
        public Anmeldung()
        {
            InitializeComponent();
            TBRInsert.Enabled = false;
        }

        public void RegistrierenButtonEnableDisable() //Diese Methode dient dazu den Registrierenbutton erst dann freizugeben wenn in alle Pflichtfelder etwas eingetragen wurde
        {
            if (!string.IsNullOrWhiteSpace(TBRName.Text) & !string.IsNullOrWhiteSpace(TBREmail.Text) & !string.IsNullOrWhiteSpace(TBRPasswort.Text) & !string.IsNullOrWhiteSpace(TBRPasswortW.Text) & !string.IsNullOrWhiteSpace(TBRAdresse.Text) & !string.IsNullOrWhiteSpace(TBRZahlung.Text) & !string.IsNullOrWhiteSpace(TBRPostleitzahl.Text) & CBAGBs.Checked == true)
            {
                TBRInsert.Enabled = true;
            }
            else
            {
                TBRInsert.Enabled = false;
            }
        }

   
        #region Textboxen Textchanged
        private void TBRAdresse_TextChanged(object sender, EventArgs e)
        {
            RegistrierenButtonEnableDisable();
        }

        private void TBRPostleitzahl_TextChanged(object sender, EventArgs e)
        {
            RegistrierenButtonEnableDisable();
        }

        private void TBRZahlung_TextChanged(object sender, EventArgs e)
        {
            RegistrierenButtonEnableDisable();
        }

        private void TBRPasswortW_TextChanged(object sender, EventArgs e)
        {
            RegistrierenButtonEnableDisable();
        }

        private void TBRPasswort_TextChanged(object sender, EventArgs e)
        {
            RegistrierenButtonEnableDisable();
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
            RegistrierenButtonEnableDisable();
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
            if (TBRPasswort.Text == TBRPasswortW.Text)      //Hier müssen noch die Daten in die Datenbank eingetragen werden
            {
                
                //MySQL.InsertUser(TBRName.Text, TBRVorname.Text, TBREmail.Text, TBRTelefon.Text, TBRAdresse, TBRPostleitzahl.Text, TBROrt, TBRUsername, TBRPasswort.Text);
                AutoAnzeige Auswahl = new AutoAnzeige();
                Auswahl.Show();
                
            }
            else
                {
                MessageBox.Show("Sie haben ihr Passwort nicht korrekt wiederholt eingegeben.");
                TBRPasswort.Clear();
                TBRPasswortW.Clear();
                }
        }

    }

}
