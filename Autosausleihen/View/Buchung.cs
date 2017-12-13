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
    }
}
