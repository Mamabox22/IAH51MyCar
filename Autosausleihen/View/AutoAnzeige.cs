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
    public partial class AutoAnzeige : Form
    {
        MainForm form;
        MySQL mysql = new MySQL();
        
        public AutoAnzeige(MainForm form)
        {
            InitializeComponent();
            InitializeAutoListbox();
            this.form = form;
        }

        private void InitializeAutoListbox()
        {
            using (var con = new MySqlConnection(mysql.ConnectionString))
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TBSucheHersteller_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBSucheModell_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBSucheName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BHinzufügen_Click(object sender, EventArgs e)
        {
            //mysql.Insert(TBSucheHersteller.Text, TBSucheName.Text, TBSucheModell.Text);
            
                
            ////using (var myCommand = new MySqlCommand("INSERT INTO ",mysql))
            ////{
            ////    myCommand.ExecuteNonQuery();
            ////}

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //   dateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd";
        }

        private void BTSuche_Click(object sender, EventArgs e)
        {
            //TBSucheHersteller.Text = mysql.GetAutodaten(Hersteller);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BTMieten_Click(object sender, EventArgs e)
        {

        }

        private void lvAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvAutos.FocusedItem != null)
            TBAModell.Text = lvAutos.FocusedItem.Text;   
        }

        private void AutoAnzeige_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Close();
        }
    }
}
