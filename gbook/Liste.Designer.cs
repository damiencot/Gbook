namespace gbook
{
    partial class PageListe
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
            this.dataGridView_pageListe = new System.Windows.Forms.DataGridView();
            this.btn_check_pageListe = new System.Windows.Forms.Button();
            this.btn_update_pageListe = new System.Windows.Forms.Button();
            this.btn_delete_pageListe = new System.Windows.Forms.Button();
            this.btn_ajout__pageListe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_auteurs_pageListe = new System.Windows.Forms.Button();
            this.btn_genres_pageListe = new System.Windows.Forms.Button();
            this.btn_editeurs_pageListe = new System.Windows.Forms.Button();
            this.btn_profil_pageListe = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pageListe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_pageListe
            // 
            this.dataGridView_pageListe.AllowUserToAddRows = false;
            this.dataGridView_pageListe.AllowUserToDeleteRows = false;
            this.dataGridView_pageListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pageListe.Location = new System.Drawing.Point(366, 131);
            this.dataGridView_pageListe.Name = "dataGridView_pageListe";
            this.dataGridView_pageListe.ReadOnly = true;
            this.dataGridView_pageListe.RowTemplate.Height = 24;
            this.dataGridView_pageListe.Size = new System.Drawing.Size(813, 537);
            this.dataGridView_pageListe.TabIndex = 0;
            this.dataGridView_pageListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_pageListe_CellContentClick);
            // 
            // btn_check_pageListe
            // 
            this.btn_check_pageListe.Location = new System.Drawing.Point(1007, 38);
            this.btn_check_pageListe.Name = "btn_check_pageListe";
            this.btn_check_pageListe.Size = new System.Drawing.Size(120, 54);
            this.btn_check_pageListe.TabIndex = 1;
            this.btn_check_pageListe.Text = "Actualiser";
            this.btn_check_pageListe.UseVisualStyleBackColor = true;
            this.btn_check_pageListe.Click += new System.EventHandler(this.btn_check_pageListe_Click);
            // 
            // btn_update_pageListe
            // 
            this.btn_update_pageListe.Location = new System.Drawing.Point(25, 112);
            this.btn_update_pageListe.Name = "btn_update_pageListe";
            this.btn_update_pageListe.Size = new System.Drawing.Size(286, 47);
            this.btn_update_pageListe.TabIndex = 7;
            this.btn_update_pageListe.Text = "Modifier un Livres";
            this.btn_update_pageListe.UseVisualStyleBackColor = true;
            this.btn_update_pageListe.Click += new System.EventHandler(this.btn_update_pageListe_Click);
            // 
            // btn_delete_pageListe
            // 
            this.btn_delete_pageListe.Location = new System.Drawing.Point(25, 185);
            this.btn_delete_pageListe.Name = "btn_delete_pageListe";
            this.btn_delete_pageListe.Size = new System.Drawing.Size(288, 48);
            this.btn_delete_pageListe.TabIndex = 8;
            this.btn_delete_pageListe.Text = "Supprimer un Livres";
            this.btn_delete_pageListe.UseVisualStyleBackColor = true;
            this.btn_delete_pageListe.Click += new System.EventHandler(this.btn_delete_pageListe_Click);
            // 
            // btn_ajout__pageListe
            // 
            this.btn_ajout__pageListe.Location = new System.Drawing.Point(25, 42);
            this.btn_ajout__pageListe.Name = "btn_ajout__pageListe";
            this.btn_ajout__pageListe.Size = new System.Drawing.Size(286, 47);
            this.btn_ajout__pageListe.TabIndex = 9;
            this.btn_ajout__pageListe.Text = "Ajouter un Livres";
            this.btn_ajout__pageListe.UseVisualStyleBackColor = true;
            this.btn_ajout__pageListe.Click += new System.EventHandler(this.btn_ajout__pageListe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_auteurs_pageListe);
            this.groupBox1.Controls.Add(this.btn_genres_pageListe);
            this.groupBox1.Controls.Add(this.btn_editeurs_pageListe);
            this.groupBox1.Controls.Add(this.btn_ajout__pageListe);
            this.groupBox1.Controls.Add(this.btn_update_pageListe);
            this.groupBox1.Controls.Add(this.btn_delete_pageListe);
            this.groupBox1.Location = new System.Drawing.Point(12, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 451);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btn_auteurs_pageListe
            // 
            this.btn_auteurs_pageListe.Location = new System.Drawing.Point(15, 382);
            this.btn_auteurs_pageListe.Name = "btn_auteurs_pageListe";
            this.btn_auteurs_pageListe.Size = new System.Drawing.Size(90, 54);
            this.btn_auteurs_pageListe.TabIndex = 12;
            this.btn_auteurs_pageListe.Text = "Auteurs";
            this.btn_auteurs_pageListe.UseVisualStyleBackColor = true;
            this.btn_auteurs_pageListe.Click += new System.EventHandler(this.btn_auteurs_pageListe_Click);
            // 
            // btn_genres_pageListe
            // 
            this.btn_genres_pageListe.Location = new System.Drawing.Point(111, 382);
            this.btn_genres_pageListe.Name = "btn_genres_pageListe";
            this.btn_genres_pageListe.Size = new System.Drawing.Size(96, 54);
            this.btn_genres_pageListe.TabIndex = 11;
            this.btn_genres_pageListe.Text = "Genres";
            this.btn_genres_pageListe.UseVisualStyleBackColor = true;
            this.btn_genres_pageListe.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_editeurs_pageListe
            // 
            this.btn_editeurs_pageListe.Location = new System.Drawing.Point(213, 382);
            this.btn_editeurs_pageListe.Name = "btn_editeurs_pageListe";
            this.btn_editeurs_pageListe.Size = new System.Drawing.Size(100, 54);
            this.btn_editeurs_pageListe.TabIndex = 10;
            this.btn_editeurs_pageListe.Text = "Editeurs";
            this.btn_editeurs_pageListe.UseVisualStyleBackColor = true;
            this.btn_editeurs_pageListe.Click += new System.EventHandler(this.btn_editeurs_pageListe_Click_1);
            // 
            // btn_profil_pageListe
            // 
            this.btn_profil_pageListe.Location = new System.Drawing.Point(29, 22);
            this.btn_profil_pageListe.Name = "btn_profil_pageListe";
            this.btn_profil_pageListe.Size = new System.Drawing.Size(102, 56);
            this.btn_profil_pageListe.TabIndex = 11;
            this.btn_profil_pageListe.Text = "Profils";
            this.btn_profil_pageListe.UseVisualStyleBackColor = true;
            this.btn_profil_pageListe.Click += new System.EventHandler(this.btn_profil_pageListe_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(394, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(470, 22);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PageListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 694);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_profil_pageListe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_check_pageListe);
            this.Controls.Add(this.dataGridView_pageListe);
            this.Name = "PageListe";
            this.Text = "Liste";
            this.Load += new System.EventHandler(this.PageListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pageListe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_pageListe;
        private System.Windows.Forms.Button btn_check_pageListe;
        private System.Windows.Forms.Button btn_update_pageListe;
        private System.Windows.Forms.Button btn_delete_pageListe;
        private System.Windows.Forms.Button btn_ajout__pageListe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btn_auteurs_pageListe;
        private System.Windows.Forms.Button btn_genres_pageListe;
        private System.Windows.Forms.Button btn_editeurs_pageListe;
        private System.Windows.Forms.Button btn_profil_pageListe;
        private System.Windows.Forms.TextBox textBox1;
    }
}