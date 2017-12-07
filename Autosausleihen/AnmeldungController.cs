using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autosausleihen
{
    class AnmeldungController : Controller
    {
        public AnmeldungController(Form view, MainForm mainForm) : base(view, new AnmeldungModel())
        {
            getControl("TBRInsert").Click += AnmeldungController_Click;
            ((AnmeldungModel)model).MainForm = mainForm;
            ((CheckBox)getControl("CBAGBs")).CheckedChanged += AnmeldungController_CheckedChanged;
        }

        private void AnmeldungController_CheckedChanged(object sender, EventArgs e)
        {
            ((AnmeldungModel)model).AGB = true;
        }

        private void AnmeldungController_Click(object sender, EventArgs e)
        {
            // Noch Pflichtfeld abgrage nötig#
            // && TBREmail is null && TBRAdresse is null && TBRPasswort is null && TBRZahlung is null

            if (getControl("TBRPasswort").Text == getControl("TBRPasswortW").Text)
            {


                if (((AnmeldungModel)model).AGB == false)
                {
                    MessageBox.Show("Du musst die AGB's bestätigen");
                }
                else
                {
                    // mysql.Insert(TBRName.Text, TBRVorname.Text, TBRAdresse.Text, TBROrt.Text, TBRPostleitzahl.Text, TBREmail, TBRTelefon.Text,TBRPasswort.Text,TBRPasswortW.Text);
                    AutoAnzeige Auswahl = new AutoAnzeige(((AnmeldungModel)model).MainForm);
                    Auswahl.Show();
                    view.Close();
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
    }
}
