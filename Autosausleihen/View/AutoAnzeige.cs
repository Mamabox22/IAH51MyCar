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
        int ivariante;
        int iSitzplätze;
        public AutoAnzeige()
        {
            InitializeComponent();
            InitializeAutoListbox();
            FillCombo();
        }

        void FillCombo()
        {
            string NameQuerry = "Select * from auto";
            MySqlConnection con = new MySqlConnection(MySQL.ConnectionString);
            MySqlCommand cmd = new MySqlCommand(NameQuerry, con);
            MySqlDataReader myReader;
            try
            {  
                con.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string sHersteller = myReader.GetString("Hersteller");
                    ComBHersteller.Items.Add(sHersteller);
                    string sModell = myReader.GetString("Modell");
                    ComBModell.Items.Add(sModell);
                    string sName = myReader.GetString("Name");
                    ComBName.Items.Add(sName);
                    string sBaujahr = myReader.GetString("Baujahr");
                    ComBBaujahr.Items.Add(sBaujahr);
                    string sSitzplatz = myReader.GetString("Sitzplätze");
                    ComBSitzplätze.Items.Add(sSitzplatz);
                    string sFarbe = myReader.GetString("Farbe");
                    ComBFarbe.Items.Add(sFarbe);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
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
        
        public void LvAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAutos.FocusedItem != null)
            {
                ListViewItem item = lvAutos.SelectedItems[0];
                TBAHersteller.Text = item.SubItems[0].Text;
                TBAModell.Text = item.SubItems[1].Text;
                TBAName.Text = item.SubItems[2].Text;
                TBABaujahr.Text = item.SubItems[3].Text;
                TBASitzplatz.Text = item.SubItems[4].Text;
                
            }
            string NameQuerry = "Select * from auto where Hersteller = '" + lvAutos.FocusedItem.Text + "' ";
            MySqlConnection con = new MySqlConnection(MySQL.ConnectionString);
            MySqlCommand cmd = new MySqlCommand(NameQuerry, con);
            MySqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string sHersteller = myReader.GetString("Hersteller");
                    string sModell = myReader.GetString("Modell");
                    string sName = myReader.GetString("Name");
                    string sBaujahr = myReader.GetInt32("Baujahr").ToString();
                    string sSitzplatz = myReader.GetInt32("Sitzplätze").ToString();
                    string sFarbe = myReader.GetString("Farbe");
                    TBAHersteller.Text = sHersteller;
                    TBAModell.Text = sModell;
                    TBAName.Text = sName;
                    TBABaujahr.Text = sBaujahr;
                    TBASitzplatz.Text = sSitzplatz;
                    TBAFarbe.Text = sFarbe;

                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        
        //In dieser Region werden Strings erstellt in welche die Werte für die Buchung aus ausgewählten Textboxen geschrieben werden
        
        private void BTMieten_Click(object sender, EventArgs e)
        {
            //Buchung buchung = new Buchung(TBAA_ID.Text);
            //buchung.Show();

        }

        private void BSuche_Click(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(MySQL.ConnectionString))
            {
                string FilterQuerry = "Select * from auto where Hersteller Like '%" + ComBHersteller + "%' AND Modell Like '%" + ComBModell + "%' AND Name Like '%" + ComBName + "%' AND Baujahr Like '%" + ComBBaujahr + "%' AND Sitzplätze Like '%" + ComBSitzplätze + "%' AND  Farbe Like '%" + ComBFarbe + "%' AND Variante Like '%" + ivariante + "%'";
                MySqlCommand cmd = new MySqlCommand(FilterQuerry, con);
                MySqlDataReader myReader;
                try
                {
                    con.Open();
                    myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        string sHersteller = myReader.GetString("Hersteller");
                        ComBHersteller.Items.Add(sHersteller);
                        string sModell = myReader.GetString("Modell");
                        ComBModell.Items.Add(sModell);
                        string sName = myReader.GetString("Name");
                        ComBName.Items.Add(sName);
                        string sBaujahr = myReader.GetString("Baujahr");
                        ComBBaujahr.Items.Add(sBaujahr);
                        string sSitzplatz = myReader.GetString("Sitzplätze");
                        ComBSitzplätze.Items.Add(sSitzplatz);
                        string sFarbe = myReader.GetString("Farbe");
                        ComBFarbe.Items.Add(sFarbe);
                    }
                }
                catch (Exception em)
                {
                    throw em;
                }
                con.Close();

                switch (iSitzplätze)
                        {
                            case 1:
                                TBASitzplatz.Text = "2";
                                break;
                            case 2:
                                TBASitzplatz.Text = "4";
                                break;
                            case 3:
                                TBASitzplatz.Text = "5";
                                break;
                            default:
                                TBASitzplatz.Text = ("FATALERROR404");
                                break;
                        }

                switch (ivariante)
                        {
                            case 1:
                                TBAVariante.Text = "Cabrio";
                                break;
                            case 2:
                                TBAVariante.Text = "Combie";
                                break;
                            case 3:
                                TBAVariante.Text = "Limousine";
                                break;
                            default:
                                TBAVariante.Text = ("FATALERROR404");
                                break;
                        }
            }
        }

        #region Variante
        private void CBCabrio_CheckedChanged(object sender, EventArgs e)
        {
            ivariante = 1;
        }

        private void CBCombie_CheckedChanged(object sender, EventArgs e)
        {
            ivariante = 2;
        }

        private void CBLimousine_CheckedChanged(object sender, EventArgs e)
        {
            ivariante = 3;
        }

        #endregion
    }
}
