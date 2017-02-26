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
    public partial class Genre : Form
    {
        public Genre()
        {
            InitializeComponent();
        }

        private void btn_Enregistre_Click(object sender, EventArgs e)
        {
            if (txt_genre_pageGenre.Text != "")
            {
                string sql = "SELECT id , nom FROM genres";
                var db = new ConnectionDB();
                var cmd = db.DataTable(sql);
                db.OpenConection();

                DataRow[] foundGenres = cmd.Select("NOM Like '" + txt_genre_pageGenre.Text + "'");
                if (foundGenres.Length != 0)
                {
                    MessageBox.Show("Genres deja Existant ");

                }
                else
                {
                    db.ExecuteQueries("insert into genres(nom) values('" + txt_genre_pageGenre.Text + "');");

                    MessageBox.Show("Genre sauvegarder");
                    this.Close();

                }

                db.CloseConnection();
                }
            else
            {
                MessageBox.Show("Prière de fournir des détails!");
            }
            

        }

        private void txt_genre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Genre_Load(object sender, EventArgs e)
        {

        }
    }
}
