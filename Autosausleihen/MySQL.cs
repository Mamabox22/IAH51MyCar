using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Autosausleihen
{
    class MySQL
    {
        private string connectionString = @"host=localhost;user=root;database=autohaus"; //Connectionstring zur SQLDatenbank

        internal void Insert(string Hersteller, string Modell, string Name,DateTime Baujahr)
        {
                // create SqlConnection object
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    try
                    {
                        // open connection to database
                        con.Open();
                        MessageBox.Show("Connected");
                        MySqlCommand com = new MySqlCommand("insert into autos (Hersteller, Modell, Name, Baujahr) values ('" + Hersteller + "','" + Modell + "' ,'" + Name + "', '" + Baujahr + "' '"+ Baujahr + "')", con);
                        MessageBox.Show("User wurde erstellt");
                    // INTERACTION WITH DATABASE COMES HERE

                        com.ExecuteNonQuery();
                
                }
                    catch (Exception e)
                    {
                        throw e;
                    }
                    finally
                    {
                        // close connection to database
                        con.Close();
                    }
                }
            

        }


    }
}
