using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Autosausleihen.Controller
{
    class AutoAnzeigeController
    {
        public void InitializeAutoListbox()
        {
            using (var con = new MySQL.MySqlConnection(mysql.ConnectionString))
            {
                using (var dataAdapter = new MySQL.MySqlDataAdapter("select name, modell,hersteller from auto", con))
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

        public void AutoAnzeige_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Close();
        }


    }
}
