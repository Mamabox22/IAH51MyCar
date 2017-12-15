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
        //In dieser Region wird "Versucht" den String aus den jeweiligen Textboxen in Ints zu konvertieren
        #region
        private void TBSitzplätze_TextChanged(object sender, EventArgs e)
        {
            string Sitzplätze = Convert.ToString(1);
            TBSitzplätze.Text = Sitzplätze.ToString();
        }
        private void TBBaujahr_TextChanged(object sender, EventArgs e)
        {
            string Baujahr = Convert.ToString(1);
            TBSitzplätze.Text = Baujahr.ToString();
        }
        private void Variante_TextChanged(object sender, EventArgs e)
        {
            string Variante = Convert.ToString(1);
            TBSitzplätze.Text = Variante.ToString();
        }
#endregion
        private void BTNHinzufügen_Click(object sender, EventArgs e)
        {

            //MySQL.InsertAuto(new Model.AutoModel(TBHersteller.Text, TBModell.Text, TBName.Text, TBBaujahr.Text, TBSitzplätze.Text, TBFarbe.Text, variante /*Preis*/));

        }

        /* Muss noch ne If anweisung rein das Variante bei CheckboxCabrio.checked
         * variable = 1 ist usw.
         */

    }
}
