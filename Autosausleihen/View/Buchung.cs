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
        public readonly MySqlDataReader reader;

        public Buchung()
        {
            InitializeComponent();

        //In Dieser Region sind die vorher benutzen SQL Anweisungen welche jeweils Werte abfragen (Wurde probehalber ersetzt)
#region
            /* Wurde hauptsächlich ersetzt durch den Bereich in Zeile 112-126 dieser Form
            using (var con = new MySqlConnection(MySQL.ConnectionString)) //Werte werden aus der Datenbank gelesen und in die Textboxen geschrieben.
            {
                using (var cmdHersteller = new MySqlCommand("select hersteller from auto", con))
                {
                    reader = cmdHersteller.ExecuteReader();

                    while (reader.Read())
                    {
                        TBHersteller.Text = Convert.ToString(reader);
                    }
                }

                using (var cmdModell = new MySqlCommand("select modell from auto", con))
                {
                    reader = cmdModell.ExecuteReader();

                    while (reader.Read())
                    {
                        TBModell.Text = Convert.ToString(reader);
                    }


                }

                using (var cmdName = new MySqlCommand("select name from auto", con))
                {
                    reader = cmdName.ExecuteReader();

                    while (reader.Read())
                    {
                        TBName.Text = Convert.ToString(reader);
                    }


                }

                using (var cmdBauhjahr = new MySqlCommand("select baujahr from auto", con))
                {
                    reader = cmdBauhjahr.ExecuteReader();

                    while (reader.Read())
                    {
                        TBBaujahr.Text = Convert.ToString(reader);
                    }


                }

                using (var cmdFarbe = new MySqlCommand("select farbe from auto", con))
                {
                    reader = cmdFarbe.ExecuteReader();

                    while (reader.Read())
                    {
                        TBFarbe.Text = Convert.ToString(reader);
                    }


                }

                using (var cmdPreis = new MySqlCommand("select preis from auto", con))
                {
                    reader = cmdPreis.ExecuteReader();

                    while (reader.Read())
                    {
                        TBPreis.Text = Convert.ToString(reader);
                    }


                }

                using (var cmdA_ID = new MySqlCommand("select A_ID from auto", con))
                {
                    reader = cmdA_ID.ExecuteReader();

                    while (reader.Read())
                    {
                        TBA_ID.Text = Convert.ToString(reader);
                    }


                }


            }*/
#endregion
        }

        // Anstatt die Werte aus der Datenbank zu nehmen werden die Werte aus der vorherigen Form übernommen
        #region
        public string Herstellerstring { get; set; } 
        public string Namestring { get; set; }
        public string Modellstring { get; set; }
        public string Baujahrstring { get; set; }
        public string Farbestring { get; set; }
        public string IDstring { get; set; }


        private void Buchung_Load(object sender, EventArgs e)
        {
            TBHersteller.Text = Herstellerstring;
            TBName.Text = Namestring;
            TBModell.Text = Modellstring;
            TBBaujahr.Text = Baujahrstring;
            TBFarbe.Text = Farbestring;
            TBA_ID.Text = IDstring;
        }
        #endregion
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

        private void TBA_ID_TextChanged(object sender, EventArgs e)
        {
            BuchungButtonEnableDisable();
        }
        #endregion

        private void BTNBuchen_Click(object sender, EventArgs e) //Werte werden aus der Textbox geholt und mit einem Insert Befehl
        {                                                        //in die Datenbank geschrieben
            using (var con = new MySqlConnection(MySQL.ConnectionString))
            {
                using (var cmdEinfuegen = new MySqlCommand("INSERT INTO reservierung`(`hersteller`, `modell`, `name`, `baujahr`, `farbe`, `preis`, `a_id`) VALUES (@hersteller, @modell, @name, @baujahr, @farbe, @preis, @a_id)", con))
                {
                    cmdEinfuegen.Parameters.AddWithValue("@hersteller", TBHersteller.Text);
                    cmdEinfuegen.Parameters.AddWithValue("@modell", TBModell.Text);
                    cmdEinfuegen.Parameters.AddWithValue("@name", TBName.Text);
                    cmdEinfuegen.Parameters.AddWithValue("@baujahr", TBBaujahr.Text);
                    cmdEinfuegen.Parameters.AddWithValue("@farbe", TBFarbe.Text);
                    cmdEinfuegen.Parameters.AddWithValue("@preis", TBPreis.Text);
                    cmdEinfuegen.Parameters.AddWithValue("@a_id", TBA_ID.Text);
                }
            }
        }

    }
}
