using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gbook
{
    public partial class Profil : Form
    {
        public Profil()
        {
            InitializeComponent();
        }


        private void ClearData()
        {
            //Efface les données remplis dans le champ Titre
            txt_mdp_pageProfil.Text = "";
            txt_mdpActuel_pageProfil.Text = "";
        }

        private void btn_enregistre_pageProfil_Click(object sender, EventArgs e)
        {
            string sql = "SELECT motDePasse FROM utilisateurs ";
            var db = new ConnectionDB();
            var cmd = db.DataTable(sql);
            db.OpenConection();
            

            DataRow[] foundUtilisateurs = cmd.Select("motDePasse Like '" + txt_mdpActuel_pageProfil.Text + "'");
            if (foundUtilisateurs.Length != 0)
            {

                db.ExecuteQueries("update utilisateurs set nom = '" + comboBox_utilisateur_pageProfil.Text + "', motDePasse = '" + txt_mdp_pageProfil.Text + "' WHERE id ='" + comboBox_utilisateur_pageProfil.SelectedValue + "'");
                ClearData();
                MessageBox.Show("Utilisateurs mise à jour");

                db.CloseConnection();
                this.Close();
            }
            else
            {

                MessageBox.Show("Mot de passe actuel incorrect, Veuillez réessayer");
            }
            db.CloseConnection();

        }

        private void Profil_Load(object sender, EventArgs e)
        {
            UtilisateursCombo();
        }

        private void UtilisateursCombo()
        {
            string sql = "SELECT id, nom, motDePasse, role FROM utilisateurs WHERE role = 'ROLE_Users' ";
            var dbCon = new ConnectionDB();
            var cmd = dbCon.DataTable(sql);
            dbCon.OpenConection();

            comboBox_utilisateur_pageProfil.DataSource = cmd;
            comboBox_utilisateur_pageProfil.DisplayMember = "nom";
            comboBox_utilisateur_pageProfil.ValueMember = "id";

        }

        private void comboBox_utilisateur_pageProfil_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
