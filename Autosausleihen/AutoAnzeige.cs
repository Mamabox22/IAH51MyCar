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

        MySQL mysql = new MySQL();
        
        public AutoAnzeige()
        {
            InitializeComponent();

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
            mysql.Insert(TBSucheHersteller.Text, TBSucheName.Text, TBSucheModell.Text, dateTimePicker1.Value.Date);
            
                
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
    }
}
