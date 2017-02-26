using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace gbook
{
    class ConnectionDB
    {
        // URL de ma BDD
        string ConnectionString = "Server=localhost; database=gbook; UID=; password=";

        //Représente une connexion ouverte à une base de données MySQL Server
        MySqlConnection con;


        public string getConnectionString()
        {
            return ConnectionString;
        }

        //Ouvre et Instancie une connection
        public void OpenConection()
        {
            con = new MySqlConnection(ConnectionString);
            con.Open();
            if (con.State == ConnectionState.Open) // if connection.Open was successful
            {
            }
            else
            {
                MessageBox.Show("La connexion a échoué.");
            }
        }

        //Ferme une connection
        public void CloseConnection()
        {
            con.Close();
        }

        //Execute une requete
        public void ExecuteQueries(string Query)
        {
            MySqlCommand cmd = new MySqlCommand(Query, con);
            cmd.ExecuteNonQuery();
        }


        //Lis les valeurs d'une table
        public MySqlDataReader DataReader(string Query)
        {
            MySqlCommand cmd = new MySqlCommand(Query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }


        //Stocke et lis les valeurs d'une table 
        public DataTable DataTable(string queryString)
        {
            DataTable results = new DataTable("Results");
            using (con = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand command = new MySqlCommand(queryString, con))
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                    using (MySqlDataReader reader = command.ExecuteReader())
                        results.Load(reader);
                }
            }
            return results;
        }



        //Appelez cette méthode pour afficher des données dans un DataGridView.
        public object ShowDataInGridView(string Query_)
        {
            MySqlDataAdapter dr = new MySqlDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }



    }
}
