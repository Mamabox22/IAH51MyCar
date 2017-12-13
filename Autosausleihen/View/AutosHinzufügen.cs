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
    public partial class AutosHinzufügen : Form
    {

        public AutosHinzufügen()
        {
            InitializeComponent();
            InitializeAutoListbox();
        }

        private void InitializeAutoListbox()
        {
            using (var con = new MySqlConnection(MySQL.ConnectionString))
            {
                using (var dataAdapter = new MySqlDataAdapter("select name, modell,hersteller from auto", con))
                {
                    var autoTable = new DataTable();
                    dataAdapter.Fill(autoTable);
                    foreach (DataRow row in autoTable.Rows)
                    {
                        var listviewItem = new ListViewItem(row["hersteller"] as string);
                        listviewItem.SubItems.Add(row["modell"] as string);
                        listviewItem.SubItems.Add(row["name"] as string);

                        lvAutos.Items.Add(listviewItem);
                    }
                }
            }

        }

        private void lvAutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
