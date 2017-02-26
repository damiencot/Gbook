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
    public partial class Ajouter : Form
    {

        public Ajouter()
        {
            InitializeComponent();

        }

        private void ClearData()
        {
            //Efface les données remplis dans le champ Titre
            txt_titre_pageAjouter.Text = "";
        }

        private void foundEditeurs()
        {
            // Variable qui stocke la requete SQL
            string sql = "SELECT id , nom FROM editeurs";
            //Creation d'un nouvelle connexion 
            var db = new ConnectionDB();
            //Appel de la fonction Datatable de la classe ConnectionDB
            var cmd = db.DataTable(sql);
            //Overture de la connection a la base
            db.OpenConection();

            //Liste de donnée
            DataRow[] foundEditeurs = cmd.Select("NOM Like '" + comboBox_editeur_pageAjouter.Text + "'");
            //Si foundEditeurs est different de 0
            if (foundEditeurs.Length != 0)
            {
            }
            //Sinon
            else
            {
                //Requete Insert un nouveau editeurs 
                db.ExecuteQueries("insert into editeurs(nom) values('" + comboBox_editeur_pageAjouter.Text + "');");

                // Recupere l id du dernier enregistrement dans la base de donnée
                string requete = "SELECT id, nom FROM editeurs ORDER BY id DESC LIMIT 1";
                //Sotcke dans une table
                var command = db.DataTable(requete);

                //Affiche l id et le nom correspondant dans la combobox
                comboBox_editeur_pageAjouter.DataSource = command;
                comboBox_editeur_pageAjouter.DisplayMember = "nom";
                comboBox_editeur_pageAjouter.ValueMember = "id";
                //Affichage d'un message
                MessageBox.Show("Editeurs sauvegarder");
            }

            //Fermeture de la connection a la base
            db.CloseConnection();

        }

        private void foundGenres()
        {
            string sql = "SELECT id , nom FROM genres";
            var db = new ConnectionDB();
            var cmd = db.DataTable(sql);
            db.OpenConection();

            DataRow[] foundGenres = cmd.Select("NOM Like '" + comboBox_genre_pageAjouter.Text + "'");
            if (foundGenres.Length != 0)
            {
            }
            else
            {
                db.ExecuteQueries("insert into genres(nom) values('" + comboBox_genre_pageAjouter.Text + "');");

                string requete = "SELECT id, nom FROM genres ORDER BY id DESC LIMIT 1";
                var command = db.DataTable(requete);

                comboBox_genre_pageAjouter.DataSource = command;
                comboBox_genre_pageAjouter.DisplayMember = "nom";
                comboBox_genre_pageAjouter.ValueMember = "id";
                MessageBox.Show("Genres sauvegarder");
            }
            db.CloseConnection();

        }

        private void foundAuteurs()
        {

            string sql = "SELECT id , nom FROM auteurs";
            var db = new ConnectionDB();
            var cmd = db.DataTable(sql);
            db.OpenConection();

            DataRow[] foundAuteurs = cmd.Select("NOM Like '" + comboBox_auteur_pageAjouter.Text + "'");
            if (foundAuteurs.Length != 0)
            {
            }
            else
            {
                db.ExecuteQueries("insert into auteurs(nom) values('" + comboBox_auteur_pageAjouter.Text + "');");

                string requete = "SELECT id, nom FROM auteurs ORDER BY id DESC LIMIT 1";
                var command = db.DataTable(requete);

                comboBox_auteur_pageAjouter.DataSource = command;
                comboBox_auteur_pageAjouter.DisplayMember = "nom";
                comboBox_auteur_pageAjouter.ValueMember = "id";
                MessageBox.Show("Auteurs sauvegarder");


            }

            db.CloseConnection();


        }

        private void btn_enregistre_pageAjouter_Click(object sender, EventArgs e)
        {



        }

        private void txt_Ajout_Genre_Click(object sender, EventArgs e)
        {

        }

        private void Ajouter_Load(object sender, EventArgs e)
        {
            // Fonction qui sont charge quand la page est appelé
            editeursCombo();
            genresCombo();
            auteursCombo();
        }

        private void comboBox_auteur_pageAjout_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void editeursCombo()
        {
            // Variable qui stocke la requete SQL
            string sql = "SELECT id , nom FROM editeurs";
            //Creation d'un nouvelle connexion 
            var dbCon = new ConnectionDB();
            //Appel de la fonction Datatable de la classe ConnectionDB
            var cmd = dbCon.DataTable(sql);
            dbCon.OpenConection();

            //Liaison des données de la combobox a la variable stockant les données de la table
            comboBox_editeur_pageAjouter.DataSource = cmd;
            //On affiche la propriété  "titre" de Datasource
            comboBox_editeur_pageAjouter.DisplayMember = "nom";
            //Définit la propriété à utiliser comme valeur réelle
            comboBox_editeur_pageAjouter.ValueMember = "id";

            //Fermeture de la connection a la base
            dbCon.CloseConnection();

        }

        private void genresCombo()
        {

            string sql = "SELECT id , nom FROM genres";
            var dbCon = new ConnectionDB();
            var cmd = dbCon.DataTable(sql);
            dbCon.OpenConection();

            comboBox_genre_pageAjouter.DataSource = cmd;
            comboBox_genre_pageAjouter.DisplayMember = "nom";
            comboBox_genre_pageAjouter.ValueMember = "id";

            dbCon.CloseConnection();
        }

        private void auteursCombo()
        {

            string sql = "SELECT id , nom FROM auteurs";
            var dbCon = new ConnectionDB();
            var cmd = dbCon.DataTable(sql);
            dbCon.OpenConection();

            comboBox_auteur_pageAjouter.DataSource = cmd;
            comboBox_auteur_pageAjouter.DisplayMember = "nom";
            comboBox_auteur_pageAjouter.ValueMember = "id";

            dbCon.CloseConnection();
        }

        private void comboBox_editeur_pageAjout_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_enregistre_pageAjouter_Click_1(object sender, EventArgs e)
        {
            //Appel de differente fonction
            foundEditeurs();
            foundGenres();
            foundAuteurs();

            //Si le champ titre est vide
            if (txt_titre_pageAjouter.Text != "")
            {
                //Essaie
                try
                {
                    //Creation d'un nouvelle connexion 
                    var dbCon = new ConnectionDB();
                    //Ouverture de la connection a la base
                    dbCon.OpenConection();
                    //Requete Insert qui prend en compte les valeurs des champs
                    dbCon.ExecuteQueries("insert into livres(titre,annee,idAuteurs,idEditeurs,idGenres) values('" + this.txt_titre_pageAjouter.Text + "','" + this.dateTime_pageAjouter.Text + "','" + this.comboBox_auteur_pageAjouter.SelectedValue + "','" + this.comboBox_editeur_pageAjouter.SelectedValue + "','" + this.comboBox_genre_pageAjouter.SelectedValue + "');");
                    //Affichage d'un message 
                    MessageBox.Show("Livres sauvegarder");
                    //Appel de la fonction ClearData
                    ClearData();
                    //Fermeture de la connection a la base
                    dbCon.CloseConnection();
                    this.Close();

                }
                catch (Exception ex)
                {
                    //Message d'erreur si le Try echoue
                    MessageBox.Show(ex.Message);
                }

            }
            //Sinon
            else
            {
                //Affichage d'un message 
                MessageBox.Show("Prière de fournir des détails!");
            }
        }
    }
}
