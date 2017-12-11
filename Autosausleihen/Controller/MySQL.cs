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
          //Connectionstring zur SQLDatenbank

            /*internal void Insert(string Hersteller, string Modell, string Name, DateTime Baujahr)
            {
                // create SqlConnection object
                using (MySqlConnection con = new MySqlConnection(ConnectionString))
                {
                    try
                    {
                        // open connection to database
                        con.Open();
                        MessageBox.Show("Connected");
                        MySqlCommand com = new MySqlCommand("insert into auto (Hersteller, Modell, Name, Baujahr) values ('" + Hersteller + "','" + Modell + "' ,'" + Name + "', '" + Baujahr + "' '" + Baujahr + "')", con);
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

            internal void Update(string Hersteller, string Modell, string Name, DateTime Baujahr)
            {
                // create SqlConnection object
                using (MySqlConnection con = new MySqlConnection(ConnectionString))
                {
                    try
                    {
                        // open connection to database
                        con.Open();
                        MessageBox.Show("Connected");
                        MySqlCommand com = new MySqlCommand("Update into auto (Hersteller, Modell, Name, Baujahr) values ('" + Hersteller + "','" + Modell + "' ,'" + Name + "', '" + Baujahr + "' '" + Baujahr + "')", con);
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

            internal void Delete(string Hersteller, string Modell, string Name, DateTime Baujahr)
            {
                // create SqlConnection object
                using (MySqlConnection con = new MySqlConnection(ConnectionString))
                {
                    try
                    {
                        // open connection to database
                        con.Open();
                        MessageBox.Show("Connected");
                        MySqlCommand com = new MySqlCommand("Delete into auto (Hersteller, Modell, Name, Baujahr) values ('" + Hersteller + "','" + Modell + "' ,'" + Name + "', '" + Baujahr + "' '" + Baujahr + "')", con);
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
            */
        }
    }

