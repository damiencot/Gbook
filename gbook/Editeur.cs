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
    public partial class Editeur : Form
    {
        public Editeur()
        {
            InitializeComponent();
        }

        private void btn_Enregistre_Click(object sender, EventArgs e)
        {
            if (txt_editeur_pageEditeur.Text != "")
            {
                string sql = "SELECT id , nom FROM editeurs";
                var db = new ConnectionDB();
                var cmd = db.DataTable(sql);
                db.OpenConection();

                DataRow[] foundEditeurs = cmd.Select("NOM Like '" + txt_editeur_pageEditeur.Text + "'");
                if (foundEditeurs.Length != 0)
                {
                    MessageBox.Show("Editeurs deja Existant ");

                }
                else
                {
                    db.ExecuteQueries("insert into editeurs(nom) values('" + txt_editeur_pageEditeur.Text + "');");

                    MessageBox.Show("Editeurs sauvegarder");
                    this.Close();

                }

                db.CloseConnection();
            }
            else
            {
                MessageBox.Show("Prière de fournir des détails!");
            }
        }

        private void Editeur_Load(object sender, EventArgs e)
        {

        }
    }
}
