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

namespace Autosausleihen
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void BTRegistrierung_Click(object sender, EventArgs e)
        {
            Anmeldung anmeldung = new Anmeldung();                          //Aus irgendwelchen Gründen wurde die Registrierung als Anmeldung benannt
            anmeldung.Show();
            Hide();

        }

        private void BTLogIN_Click(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(MySQL.ConnectionString))
            {
                using (var dataAdapter = new MySqlDataAdapter("select username from Kunde", con))
                {
                    var UsernameTable = new DataTable();
                    dataAdapter.Fill(UsernameTable);

                    foreach (var username in UsernameTable.AsEnumerable())
                    {

                    }

                }
            }
        }

        private void BTHinzufügen_Click(object sender, EventArgs e)
        {
            AutosHinzufügen hinzufügen = new AutosHinzufügen();
            hinzufügen.Show();
        }
    }
}
