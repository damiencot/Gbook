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
    public partial class Auteur : Form
    {
        public Auteur()
        {
            InitializeComponent();
        }

        private void btn_Enregistre_Click(object sender, EventArgs e)
        {
            if (txt_auteur_pageAuteur.Text != "")
            {
                string sql = "SELECT id , nom FROM auteurs";
                var db = new ConnectionDB();
                var cmd = db.DataTable(sql);
                db.OpenConection();

                DataRow[] foundAuteurs = cmd.Select("NOM Like '" + txt_auteur_pageAuteur.Text + "'");
                if (foundAuteurs.Length != 0)
                {
                    MessageBox.Show("Auteurs deja existant");

                }
                else
                {
                    db.ExecuteQueries("insert into auteurs(nom) values('" + txt_auteur_pageAuteur.Text + "');");

                    MessageBox.Show("Auteur sauvegarder");
                    this.Close();

                }

                db.CloseConnection();
            }
            else
            {
                MessageBox.Show("Prière de fournir des détails!");
            }
        }

        private void Auteur_Load(object sender, EventArgs e)
        {

        }
    }
}
