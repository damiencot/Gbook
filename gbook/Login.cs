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


namespace gbook
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Connexion_Click(object sender, EventArgs e)
        {
            //Essaie
            try
            {
                //Creation d'un nouvelle connexion 
                var dbCon = new ConnectionDB();
                //Ouverture de la connection a la base
                dbCon.OpenConection();
                //Requete stocké dans une variable qui prend en compte les valeurs des champs
                var drts = dbCon.DataTable("select * from utilisateurs where nom = '" + txt_nom.Text + "' and motDePasse = '" + txt_password.Text + "'");
                //Si une valeur correspondant aux champs est trouvé alors on rentre dans le IF
                if (drts.Rows.Count == 1)
                {
                    //On affiche la nouvelle page
                    this.Hide();
                    PageListe list = new PageListe();
                    list.Show();
                }
                else
                {
                    //Message d'erreur
                    MessageBox.Show("Identifiant Incorrect");
                }

                //Fermeture de la connection a la base
                dbCon.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
