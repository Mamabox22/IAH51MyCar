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
using Autosausleihen.Model;
using Autosausleihen.View;

namespace Autosausleihen
{
    public partial class AutoAnzeige : Form
    {

        public AutoAnzeige()
        {
            InitializeComponent();
            InitializeAutoListbox();
        }

        public void InitializeAutoListbox()
        {
            using (var con = new MySqlConnection( MySQL.ConnectionString))
            {
                using (var dataAdapter = new MySqlDataAdapter("select name, modell, hersteller from auto", con))
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
        
        public void lvAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAutos.FocusedItem != null)
                TBAModell.Text = lvAutos.FocusedItem.Text;

        }
        
        //In dieser Region werden Strings erstellt in welche die Werte für die Buchung aus ausgewählten Textboxen geschrieben werden
#region


        private void BTMieten_Click(object sender, EventArgs e)
        {
            Buchung buchung = new Buchung(TBAA_ID.Text);
            buchung.Show();

        }
        #endregion


    }
}
