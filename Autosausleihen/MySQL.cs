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

        internal void Insert(string Hersteller, string Modell, string Name, DateTime Baujahr)
        {
            // create SqlConnection object
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    // open connection to database
                    con.Open();
                    MessageBox.Show("Connected");
                    MySqlCommand com = new MySqlCommand("insert into autos (Hersteller, Modell, Name, Baujahr) values ('" + Hersteller + "','" + Modell + "' ,'" + Name + "', '" + Baujahr + "' '" + Baujahr + "')", con);
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
        
        /*
        string GetKundendaten()
        {

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                using (MySqlCommand command = con.CreateCommand())
                {
                    command.CommandText = "Select * FROM autohaus.Kunde";

                    using (MySqlDataReader myReader = command.ExecuteReader())
                    {
                        try
                        {
                            StringBuilder sb = new StringBuilder();

                            while (myReader.Read())
                            {
                                if (sb.Length > 0)
                                    sb.Append(Environment.NewLine);

                                for (int i = 0; i < myReader.FieldCount; i++)
                                    sb.AppendFormat("{0}    ", myReader[i]);
                            }

                            return sb.ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }

            return string.Empty;


        }

        internal string GetAutodaten()
        {

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                using (MySqlCommand command = con.CreateCommand())
                {
                    command.CommandText = "Select * FROM autohaus.Autos";

                    using (MySqlDataReader myReader = command.ExecuteReader())
                    {
                        try
                        {
                            StringBuilder sb = new StringBuilder();

                            while (myReader.Read())
                            {
                                if (sb.Length > 0)
                                    sb.Append(Environment.NewLine);

                                for (int i = 0; i < myReader.FieldCount; i++)
                                    sb.AppendFormat("{0}    ", myReader[i]);
                            }

                            return sb.ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }

            return string.Empty;
            

        }

        */
    }
}
