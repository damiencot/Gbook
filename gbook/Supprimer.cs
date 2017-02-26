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
    public partial class Supprimer : Form
    {

        private DataTable cmdLivres;

        public Supprimer()
        {
            InitializeComponent();
        }

        private void Supprimer_Load(object sender, EventArgs e)
        {
            livresListe();
        }

        private DataTable livresListe()
        {
            string sql = "SELECT id , titre FROM livres";
            var dbCon = new ConnectionDB();
            var cmdLivres = dbCon.DataTable(sql);
            dbCon.OpenConection();

            listBoxLivres_PageSupprimer.DataSource = cmdLivres;
            listBoxLivres_PageSupprimer.DisplayMember = "titre";
            listBoxLivres_PageSupprimer.ValueMember = "id";

            return cmdLivres;

        }

        private void btn_Supprimer_PageSupprimer_Click(object sender, EventArgs e)
        {

            var Selected = listBoxLivres_PageSupprimer.SelectedValue;

                try
                {
                    var dbCon = new ConnectionDB();
                    dbCon.OpenConection();
                    dbCon.ExecuteQueries("DELETE FROM livres WHERE id = " + Selected + "");
                    MessageBox.Show("Livre supprimer");
                    dbCon.CloseConnection();
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void btn_Recherche_PageSupprimer_Click(object sender, EventArgs e)
        {

        }


        private void listBoxLivres_PageSupprimer_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
