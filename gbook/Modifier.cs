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
    public partial class Modifier : Form
    {
        public Modifier()
        {
            InitializeComponent();
        }

        private void Modifier_Load(object sender, EventArgs e)
        {
            // Fonction qui sont charge quand la page est appelé
            editeursCombo();
            genresCombo();
            auteursCombo();
            livresListe();

        }


        private void livresListe()
        {
            // Variable qui stocke la requete SQL
            string sql = "SELECT id , titre FROM livres";
            //Creation d'un nouvelle connexion 
            var dbCon = new ConnectionDB();
            //Appel de la fonction Datatable de la classe ConnectionDB
            var cmdLivres = dbCon.DataTable(sql);

            //Liaison des données de la combobox a la variable stockant les données de la table
            listBoxLivres_pageModifier.DataSource = cmdLivres;
            //On affiche la propriété  "titre" de Datasource
            listBoxLivres_pageModifier.DisplayMember = "titre";
            //Définit la propriété à utiliser comme valeur réelle
            listBoxLivres_pageModifier.ValueMember = "id";

            //Fermeture de la connection a la base
            dbCon.CloseConnection();


        }

        private void dataGridViewSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void listBoxLivres_pageModifier_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Variable qui stocke la requete SQL - Requete sql qui selectionne les champs correspondant à notre selection dans la ListBox
            string sql = "SELECT id , titre , annee, idAuteurs, idEditeurs, idGenres FROM livres WHERE titre='" + listBoxLivres_pageModifier.Text + "'";
            //Creation d'une nouvelle connexion 
            var dbCon = new ConnectionDB();
            //Appel de la fonction Datatable de la classe ConnectionDB
            var cmdLivres = dbCon.DataTable(sql);

            //Stocke et Parcours les lignes de donnée
            foreach(DataRow dr in cmdLivres.Rows)
            {
                //Affiche les valeurs dans les differents champs correspondant
                txt_titre_pageModifier.Text = dr["titre"].ToString();
                dateTime_pageModifier.Text = dr["annee"].ToString();
                comboBox_auteur_pageModifier.SelectedValue = dr["idAuteurs"].ToString();
                comboBox_editeur_pageModifier.SelectedValue = dr["idEditeurs"].ToString();
                comboBox_genre_pageModifier.SelectedValue = dr["idGenres"].ToString();

            }

        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            string sql = "SELECT id , nom FROM editeurs";
            var db = new ConnectionDB();
            var cmd = db.DataTable(sql);
            db.OpenConection();

                try
                {
                    var dbCon = new ConnectionDB();
                    dbCon.OpenConection();
                    dbCon.ExecuteQueries("update livres set titre = '" + txt_titre_pageModifier.Text + "', annee = '" + dateTime_pageModifier.Text + "', idAuteurs = '" + comboBox_auteur_pageModifier.SelectedValue + "', idEditeurs = '" + comboBox_editeur_pageModifier.SelectedValue + "', idGenres = '" + comboBox_genre_pageModifier.SelectedValue + "' WHERE id ='" + listBoxLivres_pageModifier.SelectedValue + "'");
                    MessageBox.Show("Livres modifier");

                    dbCon.CloseConnection();
                    this.Close();

            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


        }


        private void editeursCombo()
        {
            string sql = "SELECT id , nom FROM editeurs";
            var dbCon = new ConnectionDB();
            var cmd = dbCon.DataTable(sql);
            dbCon.OpenConection();

            comboBox_editeur_pageModifier.DataSource = cmd;
            comboBox_editeur_pageModifier.DisplayMember = "nom";
            comboBox_editeur_pageModifier.ValueMember = "id";

        }

        private void genresCombo()
        {

            string sql = "SELECT id , nom FROM genres";
            var dbCon = new ConnectionDB();
            var cmd = dbCon.DataTable(sql);
            dbCon.OpenConection();

            comboBox_genre_pageModifier.DataSource = cmd;
            comboBox_genre_pageModifier.DisplayMember = "nom";
            comboBox_genre_pageModifier.ValueMember = "id";
        }

        private void auteursCombo()
        {

            string sql = "SELECT id , nom FROM auteurs";
            var dbCon = new ConnectionDB();
            var cmd = dbCon.DataTable(sql);
            dbCon.OpenConection();

            comboBox_auteur_pageModifier.DataSource = cmd;
            comboBox_auteur_pageModifier.DisplayMember = "nom";
            comboBox_auteur_pageModifier.ValueMember = "id";
        }

        public void searchData(string valueToSearch)
        {


        }


    }
}
