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
using Autosausleihen;

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
            if (!string.IsNullOrWhiteSpace(TBRName.Text) & !string.IsNullOrWhiteSpace(TBREmail.Text) & !string.IsNullOrWhiteSpace(TBRPasswort.Text) & !string.IsNullOrWhiteSpace(TBRPasswortW.Text) & !string.IsNullOrWhiteSpace(TBRAdresse.Text) & !string.IsNullOrWhiteSpace(TBRZahlung.Text) & !string.IsNullOrWhiteSpace(TBRPostleitzahl.Text) & !string.IsNullOrWhiteSpace(TBRUsername.Text) & CBAGBs.Checked == true & TBRPasswort.Text == TBRPasswortW.Text)
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
            if (TBRPasswort.Text != TBRPasswortW.Text | TBRPasswort.TextLength <= 5 )  //prüft ob passwörter ungleich sind oder die mindestlänge nicht erfüllt wurde
            {
                if (TBRPasswort.TextLength <= 5)    //wenn die mindestlänge nicht erfüllt wurde wird der kann der RegistrierenButton nicht gedrückt werden und ein label wird angezeigt
                {
                    LBpwlänge.Visible = true;
                    TBRInsert.Enabled = false;
                }
                else if (TBRPasswort.TextLength >= 5) //wenn die mindestlänge erfüllt wurde wird das label nicht angezeigt
                {
                    LBpwlänge.Visible = false;
                }

                if (TBRPasswort.Text != TBRPasswortW.Text) //hier wird geprüft ob die passwörter in 'TBRPasswort' und 'TBRPasswortW' ungleich sind. Wenn sie ungleich sind kann der RegistrierenButton nicht gedrückt werden und ein label wird angezeigt
                {
                    TBRInsert.Enabled = false;
                    LBpwprüfen.Visible = true;
                }
                else if (TBRPasswort.Text == TBRPasswortW.Text) //wenn die Passwörter übereinstimmen wird das label nicht angezeigt
                {
                    LBpwprüfen.Visible = false;
                }
            }
            else if (TBRPasswort.Text != TBRPasswortW.Text) //hier wird geprüft ob die passwörter in 'TBRPasswort' und 'TBRPasswortW' ungleich sind. Wenn sie ungleich sind kann der RegistrierenButton nicht gedrückt werden und ein label wird angezeigt
            {
                LBpwprüfen.Visible = true;
                TBRInsert.Enabled = false;
            }
            else if (TBRPasswort.Text == TBRPasswortW.Text) //wenn die Passwörter übereinstimmen wird das label nicht angezeigt
            {
                LBpwprüfen.Visible = false;
            }
            if (TBRPasswort.TextLength <= 5)     //wenn die mindestlänge nicht erfüllt wurde wird der kann der RegistrierenButton nicht gedrückt werden und ein label wird angezeigt
            {
                LBpwlänge.Visible = true;
                TBRInsert.Enabled = false;
            }
            else if (TBRPasswort.TextLength >= 5)   //wenn die mindestlänge erfüllt wurde wird das label nicht angezeigt
            {
                LBpwlänge.Visible = false;
            }
            else if (TBRPasswort.Text == TBRPasswortW.Text | TBRPasswort.TextLength >= 5) //prüft ob passwörter gleich sind oder länge richtig ist
            {
                if(TBRPasswort.TextLength >= 5) //wenn die mindestlänge erfüllt wurde wird das label nicht angezeigt
                {
                    LBpwlänge.Visible = false;
                }
                else if(TBRPasswort.Text == TBRPasswortW.Text) //wenn die Passwörter übereinstimmen wird das label nicht angezeigt
                {
                    LBpwprüfen.Visible = false;
                }
                if (TBRPasswort.TextLength >= 5 && TBRPasswort.Text == TBRPasswortW.Text) //Wenn das Passwort in Beiden Feldern richtig ist und die mindestlänge erfüllt wird werden keine label angezeigt und wenn die Pflichtfelder ausgefüllt sind kann man auf Registrieren klicken
                {

                    LBpwlänge.Visible = false;
                    LBpwprüfen.Visible = false;
                    RegistrierenButtonEnableDisable();
                }
                else if (TBRPasswort.TextLength <= 5) //wenn die mindestlänge nicht erfüllt wurde wird der kann der RegistrierenButton nicht gedrückt werden und ein label wird angezeigt
                {
                    LBpwlänge.Visible = true;
                    TBRInsert.Enabled = false;
                }

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
    /*        if(TBREmail.Text = MySql.Data.)
            {
                MessageBox.Show("Die E-Mail-Adresse wird schon verwendet. Bitte eine andere verwenden.");
            }
      */      if (TBRPasswort.Text == TBRPasswortW.Text)
            {
                
                
                MySQL.InsertUser(new Model.UserModel(TBRName.Text, TBRVorname.Text, TBREmail.Text, ValueTelefon, TBRAdresse.Text, ValuePLZ, TBROrt.Text, TBRUsername.Text, Passwort.EncryptMP5(TBRPasswort.Text)));
                // Registriert Kunden
                AutoAnzeige Auswahl = new AutoAnzeige();
                Auswahl.Show();
                //Verweist auf neue Form

            }
          
        }

        private void BTNAgb_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(1) Bitte die AGB von einer anderen Carsharing app durchlesen. Die AGB sind im Grunde dieselben.", "Allgemeine Geschäftsbedingungen");
        }

        private void Anmeldung_FormClosed(object sender, FormClosedEventArgs e)
        {

            MainForm mainform = new MainForm();
            mainform.Close();

        }
    }

}
