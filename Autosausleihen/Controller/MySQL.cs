using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Autosausleihen.Model;

    namespace Autosausleihen
    {
    class MySQL
    {
        //Connectionstring zur SQLDatenbank
        public static string ConnectionString = @"host=mysql8.db4free.net;user=iah51;password=gso-koeln;database=mycar;port=3307;";

        #region Auto
            internal static void InsertAuto(AutoModel automodel)
            {
                // create SqlConnection object
                using (MySqlConnection con = new MySqlConnection(ConnectionString))
                {
                    try
                    { 
                        // open connection to database
                        con.Open();
                        MessageBox.Show("Connected");
                        MySqlCommand com = new MySqlCommand("insert into auto (Hersteller, Modell, Name, Baujahr) values ('" + automodel.Hersteller + "','" + automodel.Modell + "' ,'" + automodel.Name + "', '" + automodel.Baujahr + "', '" + automodel.Sitzplätze + "', '" + automodel.Farbe + "', '" + automodel.Variante + "' )", con);
                        MessageBox.Show("Auto wurde erstellt");
                        // Insert CarModel in auto

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

            internal static void UpdateAuto(AutoModel automodel)
            {
                // create SqlConnection object
                using (MySqlConnection con = new MySqlConnection(ConnectionString))
                {
                    try
                    {
                        // open connection to database
                        con.Open();
                        MessageBox.Show("Connected");
                        MySqlCommand com = new MySqlCommand("Update into auto (Hersteller, Modell, Name, Baujahr) values ('" + automodel.Hersteller + "','" + automodel.Modell + "' ,'" + automodel.Name + "', '" + automodel.Baujahr + "', '" + automodel.Sitzplätze + "', '" + automodel.Farbe + "', '" + automodel.Variante + "' )", con);
                        MessageBox.Show("Auto wurde geupdated");
                        // Updates auto with Carmodel

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

            internal static void DeleteAuto(AutoModel automodel)
            {
                // create SqlConnection object
                using (MySqlConnection con = new MySqlConnection(ConnectionString))
                {
                    try
                    {
                        // open connection to database
                        con.Open();
                        MessageBox.Show("Connected");
                        MySqlCommand com = new MySqlCommand("Delete into auto (Hersteller, Modell, Name, Baujahr) values ('" + automodel.Hersteller + "','" + automodel.Modell + "' ,'" + automodel.Name + "', '" + automodel.Baujahr + "', '" + automodel.Sitzplätze + "', '" + automodel.Farbe + "', '" + automodel.Variante + "' )", con);
                        MessageBox.Show("Auto wurde gelöscht");
                        // Delete a Car

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
        #endregion

        #region Kunde
            internal static void InsertUser(UserModel kundenmodel)
        {
            // create SqlConnection object
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                try
                {
                    // open connection to database
                    con.Open();
                    MessageBox.Show("Connected");
                    MySqlCommand com = new MySqlCommand("insert into User (Name, Vorname, Email, Telefon, Adresse, Postleitzahl, Ort, Username, Passwort,) values ('" + kundenmodel.Name + "','" + kundenmodel.Vorname + "' ,'" + kundenmodel.Email + "', '" + kundenmodel.Telefon + "', '" + kundenmodel.Adresse + "', '" + kundenmodel.Postleitzahl + "', '" + kundenmodel.Ort + "', '" + kundenmodel.Username + "', '" + kundenmodel.Passwort + "' )", con);
                    MessageBox.Show("User wurde erstellt");
                    // Insert UserModel in User

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

            internal static void UpdateUser(UserModel kundenmodel)
        {
            // create SqlConnection object
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                try
                {
                    // open connection to database
                    con.Open();
                    MessageBox.Show("Connected");
                    MySqlCommand com = new MySqlCommand("Update into User (Name, Vorname, Email, Telefon, Adresse, Postleitzahl, Ort, Username, Passwort,) values ('" + kundenmodel.Name + "','" + kundenmodel.Vorname + "' ,'" + kundenmodel.Email + "', '" + kundenmodel.Telefon + "', '" + kundenmodel.Adresse + "', '" + kundenmodel.Postleitzahl + "', '" + kundenmodel.Ort + "', '" + kundenmodel.Username + "', '" + kundenmodel.Passwort + "' )", con);
                    MessageBox.Show("User wurde geupdated");
                    // Will Update a User

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

            internal static void DeleteUser(UserModel kundenmodel)
        {
            // create SqlConnection object
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                try
                {
                    // open connection to database
                    con.Open();
                    MessageBox.Show("Connected");
                    MySqlCommand com = new MySqlCommand("insert into User (Name, Vorname, Email, Telefon, Adresse, Postleitzahl, Ort, Username, Passwort,) values ('" + kundenmodel.Name + "','" + kundenmodel.Vorname + "' ,'" + kundenmodel.Email + "', '" + kundenmodel.Telefon + "', '" + kundenmodel.Adresse + "', '" + kundenmodel.Postleitzahl + "', '" + kundenmodel.Ort + "', '" + kundenmodel.Username + "', '" + kundenmodel.Passwort + "' )", con);
                    MessageBox.Show("User wurde gelöscht");
                    // Will delete a User

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
        #endregion
        
        }
    }

