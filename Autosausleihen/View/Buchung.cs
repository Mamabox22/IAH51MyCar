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
        private readonly MySqlDataReader reader;

        public Buchung()
        {
            using (var con = new MySqlConnection(MySQL.ConnectionString))
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
            }

        }

        private void BTNBuchen_Click(object sender, EventArgs e)
        {

        }
    }
}
