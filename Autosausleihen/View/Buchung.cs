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

namespace Autosausleihen.View
{
    public partial class Buchung : Form
    {
        public Buchung()
        {

            using (var con = new MySqlConnection(MySQL.ConnectionString))
            {
                using (var dataAdapter = new MySqlDataAdapter("select hersteller, modell, name, baujahr, farbe, preis from auto", con))
                {

                }
            }

        }
        public void BuchungButtonEnableDisable() //Diese Methode dient dazu den Buchenbutton erst dann freizugeben wenn in alle Pflichtfelder etwas eingetragen wurde
        {
            if (!string.IsNullOrWhiteSpace(TBBaujahr.Text) & !string.IsNullOrWhiteSpace(TBFarbe.Text) &!string.IsNullOrWhiteSpace(TBHersteller.Text) &!string.IsNullOrWhiteSpace(TBModell.Text) &!string.IsNullOrWhiteSpace(TBName.Text) &!string.IsNullOrWhiteSpace(TBPreis.Text))
            {
                BTNBuchen.Enabled = true;
            }
            else
            {
                BTNBuchen.Enabled = false;
            }
        }
        #region Textbox Textchanged
        private void TBHersteller_TextChanged(object sender, EventArgs e)
        {
            BuchungButtonEnableDisable();
        }

        private void TBModell_TextChanged(object sender, EventArgs e)
        {
            BuchungButtonEnableDisable();
        }

        private void TBName_TextChanged(object sender, EventArgs e)
        {
            BuchungButtonEnableDisable();
        }

        private void TBBaujahr_TextChanged(object sender, EventArgs e)
        {
            BuchungButtonEnableDisable();
        }

        private void TBFarbe_TextChanged(object sender, EventArgs e)
        {
            BuchungButtonEnableDisable();
        }

        private void TBPreis_TextChanged(object sender, EventArgs e)
        {
            BuchungButtonEnableDisable();
        }
        #endregion
    }
}
