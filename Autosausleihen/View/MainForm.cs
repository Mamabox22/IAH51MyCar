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

namespace Autosausleihen
{
    public partial class MainForm : Form
    {
        int i;
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

            i = 0;
            MySqlConnection con = new MySqlConnection(MySQL.ConnectionString);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from user where Username='" + TBLUsername.Text + "' and Passwort='" + Passwort.EncryptMP5(TBLPasswort.Text) + "'";
            cmd.ExecuteNonQuery();  
                   
            DataTable userTable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(userTable);
            i = Convert.ToInt32(userTable.Rows.Count.ToString());

                    if (i == 0)
                    {
                        MessageBox.Show("Der Username oder das Passwort sind falsch!");
                    }
                    else
                    {
                        AutoAnzeige anzeige = new AutoAnzeige();
                        anzeige.Show();
                        Hide();
                    }
            con.Close();
        }

        private void BTHinzufügen_Click(object sender, EventArgs e)
        {
            AutosHinzufügen hinzufügen = new AutosHinzufügen();
            hinzufügen.Show();
        }
    }
}
