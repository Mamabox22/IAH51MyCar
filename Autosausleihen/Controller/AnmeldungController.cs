using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autosausleihen
{
    class AnmeldungController : Controller.Controller
    {
        public AnmeldungController(Form view, MainForm mainForm) : base(view, new AnmeldungModel())
        {
            getControl("TBRInsert").Click += AnmeldungController_Click;

            ((AnmeldungModel)model).MainForm = mainForm;
            ((CheckBox)getControl("CBAGBs")).CheckedChanged += RegistrierungController_CheckedChanged;
        }

        private void RegistrierungController_CheckedChanged(object sender, EventArgs e)
        {
            ((AnmeldungModel)model).AGB = true;
            //Muss noch abgeschaltet werden bei unchecken
        }

        private void AnmeldungController_Click(object sender, EventArgs e)
        {
            // Noch Pflichtfeld abgrage nötig
            if (!(string.IsNullOrWhiteSpace(getControl("TBRPasswort").Text) || string.IsNullOrEmpty(getControl("TBRPasswort").Text) || 
                string.IsNullOrWhiteSpace(getControl("TBRName").Text) || string.IsNullOrEmpty(getControl("TBRName").Text) || 
                string.IsNullOrWhiteSpace(getControl("TBRAdresse").Text) || string.IsNullOrEmpty(getControl("TBRAdresse").Text) || 
                string.IsNullOrWhiteSpace(getControl("TBRZahlung").Text) || string.IsNullOrEmpty(getControl("TBRZahlung").Text)))

            {


                if (getControl("TBRPasswort").Text == getControl("TBRPasswortW").Text)
                {


                    if (((AnmeldungModel)model).AGB == false)
                    {
                        MessageBox.Show("Du musst die AGB's bestätigen");
                    }
                    else
                    {
                        // mysql.Insert(TBRName.Text, TBRVorname.Text, TBRAdresse.Text, TBROrt.Text, TBRPostleitzahl.Text, TBREmail, TBRTelefon.Text,TBRPasswort.Text,TBRPasswortW.Text);
                       // AutoAnzeige Auswahl = new AutoAnzeige(((AnmeldungModel)model).MainForm);
                       // Auswahl.Show();
                        view.Close();
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
