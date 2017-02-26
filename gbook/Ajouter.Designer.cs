namespace gbook
{
    partial class Ajouter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_enregistre_pageAjouter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_editeur_pageAjouter = new System.Windows.Forms.ComboBox();
            this.comboBox_auteur_pageAjouter = new System.Windows.Forms.ComboBox();
            this.comboBox_genre_pageAjouter = new System.Windows.Forms.ComboBox();
            this.txt_titre_pageAjouter = new System.Windows.Forms.TextBox();
            this.dateTime_pageAjouter = new System.Windows.Forms.DateTimePicker();
            this.grBox_Livres = new System.Windows.Forms.GroupBox();
            this.grBox_Livres.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_enregistre_pageAjouter
            // 
            this.btn_enregistre_pageAjouter.Location = new System.Drawing.Point(166, 371);
            this.btn_enregistre_pageAjouter.Name = "btn_enregistre_pageAjouter";
            this.btn_enregistre_pageAjouter.Size = new System.Drawing.Size(153, 61);
            this.btn_enregistre_pageAjouter.TabIndex = 0;
            this.btn_enregistre_pageAjouter.Text = "Enregistre";
            this.btn_enregistre_pageAjouter.UseVisualStyleBackColor = true;
            this.btn_enregistre_pageAjouter.Click += new System.EventHandler(this.btn_enregistre_pageAjouter_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Titre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Auteurs";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Editeurs";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Genres";
            // 
            // comboBox_editeur_pageAjouter
            // 
            this.comboBox_editeur_pageAjouter.FormattingEnabled = true;
            this.comboBox_editeur_pageAjouter.Location = new System.Drawing.Point(134, 175);
            this.comboBox_editeur_pageAjouter.Name = "comboBox_editeur_pageAjouter";
            this.comboBox_editeur_pageAjouter.Size = new System.Drawing.Size(170, 24);
            this.comboBox_editeur_pageAjouter.TabIndex = 6;
            // 
            // comboBox_auteur_pageAjouter
            // 
            this.comboBox_auteur_pageAjouter.FormattingEnabled = true;
            this.comboBox_auteur_pageAjouter.Location = new System.Drawing.Point(134, 131);
            this.comboBox_auteur_pageAjouter.Name = "comboBox_auteur_pageAjouter";
            this.comboBox_auteur_pageAjouter.Size = new System.Drawing.Size(167, 24);
            this.comboBox_auteur_pageAjouter.TabIndex = 7;
            // 
            // comboBox_genre_pageAjouter
            // 
            this.comboBox_genre_pageAjouter.FormattingEnabled = true;
            this.comboBox_genre_pageAjouter.Location = new System.Drawing.Point(134, 228);
            this.comboBox_genre_pageAjouter.Name = "comboBox_genre_pageAjouter";
            this.comboBox_genre_pageAjouter.Size = new System.Drawing.Size(170, 24);
            this.comboBox_genre_pageAjouter.TabIndex = 8;
            // 
            // txt_titre_pageAjouter
            // 
            this.txt_titre_pageAjouter.Location = new System.Drawing.Point(134, 42);
            this.txt_titre_pageAjouter.Name = "txt_titre_pageAjouter";
            this.txt_titre_pageAjouter.Size = new System.Drawing.Size(164, 22);
            this.txt_titre_pageAjouter.TabIndex = 9;
            // 
            // dateTime_pageAjouter
            // 
            this.dateTime_pageAjouter.CustomFormat = "yyyy-MM-dd";
            this.dateTime_pageAjouter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_pageAjouter.Location = new System.Drawing.Point(134, 89);
            this.dateTime_pageAjouter.Name = "dateTime_pageAjouter";
            this.dateTime_pageAjouter.Size = new System.Drawing.Size(164, 22);
            this.dateTime_pageAjouter.TabIndex = 10;
            // 
            // grBox_Livres
            // 
            this.grBox_Livres.Controls.Add(this.dateTime_pageAjouter);
            this.grBox_Livres.Controls.Add(this.txt_titre_pageAjouter);
            this.grBox_Livres.Controls.Add(this.comboBox_genre_pageAjouter);
            this.grBox_Livres.Controls.Add(this.comboBox_auteur_pageAjouter);
            this.grBox_Livres.Controls.Add(this.comboBox_editeur_pageAjouter);
            this.grBox_Livres.Controls.Add(this.label10);
            this.grBox_Livres.Controls.Add(this.label9);
            this.grBox_Livres.Controls.Add(this.label8);
            this.grBox_Livres.Controls.Add(this.label7);
            this.grBox_Livres.Controls.Add(this.label4);
            this.grBox_Livres.Location = new System.Drawing.Point(75, 29);
            this.grBox_Livres.Name = "grBox_Livres";
            this.grBox_Livres.Size = new System.Drawing.Size(367, 313);
            this.grBox_Livres.TabIndex = 11;
            this.grBox_Livres.TabStop = false;
            this.grBox_Livres.Text = "Ajouter un Nouveaux Livres";
            // 
            // Ajouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 505);
            this.Controls.Add(this.grBox_Livres);
            this.Controls.Add(this.btn_enregistre_pageAjouter);
            this.Name = "Ajouter";
            this.Text = "Ajouter";
            this.Load += new System.EventHandler(this.Ajouter_Load);
            this.grBox_Livres.ResumeLayout(false);
            this.grBox_Livres.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.ComboBox comboBox_genre_pageAjout;
        private System.Windows.Forms.ComboBox comboBox_editeur_pageAjout;
        private System.Windows.Forms.DateTimePicker dateTime_pageAjout;
        private System.Windows.Forms.TextBox txt_titre_pageAjout;
        private System.Windows.Forms.ComboBox comboBox_auteur_pageAjout;
        private System.Windows.Forms.Button btn_enregistre_pageAjouter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_editeur_pageAjouter;
        private System.Windows.Forms.ComboBox comboBox_auteur_pageAjouter;
        private System.Windows.Forms.ComboBox comboBox_genre_pageAjouter;
        private System.Windows.Forms.TextBox txt_titre_pageAjouter;
        private System.Windows.Forms.DateTimePicker dateTime_pageAjouter;
        private System.Windows.Forms.GroupBox grBox_Livres;
    }
}