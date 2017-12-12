using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autosausleihen.Model;

namespace Autosausleihen
{
    public partial class LogIn : Form
    {
        //string Passwort;


        public LogIn()
        {
            InitializeComponent();
        }

        private void BTLEinlogen_Click(object sender, EventArgs e)
        {
            //TBLUsername.Text = Passwort;

            using (var con = new MySqlConnection(new MySqlModel().ConnectionString))
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
            /*if ()
            {
                //Anzeige.Show();
                Close();
            }*/
            
        }

        private void BTLRegistrierung_Click(object sender, EventArgs e)
        {
            Anmeldung anmeldung = new Anmeldung();
            anmeldung.Show();
            Close();
        }
    }
}
