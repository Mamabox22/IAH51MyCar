﻿using System;
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

        private void RegistrierungController_CheckedChanged(object sender, EventArgs e)
        {
            AGB = true;
            //Muss noch abgeschaltet werden bei unchecken
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
            if (!(  string.IsNullOrWhiteSpace(TBRPasswort.Text) || string.IsNullOrEmpty(TBRPasswort.Text) ||
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

                        TBRPasswort.Text = Passwortkodiert;
                        Passwort.EncryptMP5(Passwortkodiert);
                        Test.Text = Passwortkodiert;

                        //MySQL.InsertUser(TBRName.Text, TBRVorname.Text, TBREmail.Text, TBRTelefon.Text, TBRAdresse, TBRPostleitzahl.Text, TBROrt, TBRUsername, TBRPasswort.Text);
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
