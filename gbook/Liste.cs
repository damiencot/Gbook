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
    public partial class PageListe : Form
    {

        public PageListe()
        {
            InitializeComponent();

        }

        private void btn_check_pageListe_Click(object sender, EventArgs e)
        {

            var dbCon = new ConnectionDB();
            dbCon.OpenConection();
            var data = dbCon.DataTable("SELECT titre as Titre, annee as Annee , A.nom as 'Nom Auteur', G.nom as Genre, E.nom as Editeur FROM livres as L , auteurs as A, genres as G, editeurs as E WHERE idAuteurs = A.id AND idEditeurs = E.id AND idGenres = G.id");
            if (data != null)
            {
                dataGridView_pageListe.DataSource = data;
            }
            else
            {
                MessageBox.Show("Problèmes lors de l'actualisation");
            }
            dbCon.CloseConnection();

        }


        private void PageListe_Load(object sender, EventArgs e)
        {
            var dbCon = new ConnectionDB();
            dbCon.OpenConection();
            var data = dbCon.ShowDataInGridView("SELECT titre as Titre, annee as Annee , A.nom as 'Nom Auteur', G.nom as Genre, E.nom as Editeur FROM livres as L , auteurs as A, genres as G, editeurs as E WHERE idAuteurs = A.id AND idEditeurs = E.id AND idGenres = G.id");
            if (data != null)
            {

                dataGridView_pageListe.DataSource = data;
            }
            else
            {
                MessageBox.Show("Problèmes lors du chargements des livres");
            }
            dbCon.CloseConnection();
        }





        private void showList()
        {

            
        }



        private void dataGridView_pageListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refresh()
        {

        }


        private void btn_Insert_Click(object sender, EventArgs e)
        {

        }



        private void btn_update_pageListe_Click(object sender, EventArgs e)
        {

            Modifier modifier2 = new Modifier();
            modifier2.ShowDialog();


        }

        private void btn_delete_pageListe_Click(object sender, EventArgs e)
        {
            
            Supprimer delete = new Supprimer();
            delete.ShowDialog();
 
        }

        private void btn_ajout__pageListe_Click(object sender, EventArgs e)
        {
            Ajouter ajout2 = new Ajouter();
            ajout2.ShowDialog();
        }

        private void txt_titre_pageListe_TextChanged(object sender, EventArgs e)
        {

        }



        private void comboBox_auteur_pageListe_SelectedIndexChanged(object sender, EventArgs e)
        {

    
        }

        private void comboBox_editeur_pageListe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_genre_pageListe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Genre genre2 = new Genre();
            genre2.ShowDialog();
        }

        private void btn_auteurs_pageListe_Click(object sender, EventArgs e)
        {
            Auteur auteur2 = new Auteur();
            auteur2.ShowDialog();
        }


        private void btn_editeurs_pageListe_Click_1(object sender, EventArgs e)
        {
            Editeur editeur2 = new Editeur();
            editeur2.ShowDialog();
        }

        private void btn_profil_pageListe_Click(object sender, EventArgs e)
        {
            Profil profil2 = new Profil();
            profil2.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }


}
