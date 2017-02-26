namespace gbook
{
    partial class Modifier
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_auteur_pageModifier = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_genre_pageModifier = new System.Windows.Forms.ComboBox();
            this.comboBox_editeur_pageModifier = new System.Windows.Forms.ComboBox();
            this.dateTime_pageModifier = new System.Windows.Forms.DateTimePicker();
            this.txt_titre_pageModifier = new System.Windows.Forms.TextBox();
            this.listBoxLivres_pageModifier = new System.Windows.Forms.ListBox();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_auteur_pageModifier);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBox_genre_pageModifier);
            this.groupBox2.Controls.Add(this.comboBox_editeur_pageModifier);
            this.groupBox2.Controls.Add(this.dateTime_pageModifier);
            this.groupBox2.Controls.Add(this.txt_titre_pageModifier);
            this.groupBox2.Location = new System.Drawing.Point(25, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 326);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information Livre";
            // 
            // comboBox_auteur_pageModifier
            // 
            this.comboBox_auteur_pageModifier.FormattingEnabled = true;
            this.comboBox_auteur_pageModifier.Location = new System.Drawing.Point(110, 138);
            this.comboBox_auteur_pageModifier.Name = "comboBox_auteur_pageModifier";
            this.comboBox_auteur_pageModifier.Size = new System.Drawing.Size(200, 24);
            this.comboBox_auteur_pageModifier.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Genres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Editeurs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Auteurs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Année";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Titre";
            // 
            // comboBox_genre_pageModifier
            // 
            this.comboBox_genre_pageModifier.FormattingEnabled = true;
            this.comboBox_genre_pageModifier.Location = new System.Drawing.Point(110, 251);
            this.comboBox_genre_pageModifier.Name = "comboBox_genre_pageModifier";
            this.comboBox_genre_pageModifier.Size = new System.Drawing.Size(200, 24);
            this.comboBox_genre_pageModifier.TabIndex = 15;
            // 
            // comboBox_editeur_pageModifier
            // 
            this.comboBox_editeur_pageModifier.FormattingEnabled = true;
            this.comboBox_editeur_pageModifier.Location = new System.Drawing.Point(110, 197);
            this.comboBox_editeur_pageModifier.Name = "comboBox_editeur_pageModifier";
            this.comboBox_editeur_pageModifier.Size = new System.Drawing.Size(200, 24);
            this.comboBox_editeur_pageModifier.TabIndex = 14;
            // 
            // dateTime_pageModifier
            // 
            this.dateTime_pageModifier.CustomFormat = "yyyy-MM-dd";
            this.dateTime_pageModifier.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_pageModifier.Location = new System.Drawing.Point(134, 82);
            this.dateTime_pageModifier.Name = "dateTime_pageModifier";
            this.dateTime_pageModifier.Size = new System.Drawing.Size(126, 22);
            this.dateTime_pageModifier.TabIndex = 12;
            // 
            // txt_titre_pageModifier
            // 
            this.txt_titre_pageModifier.Location = new System.Drawing.Point(110, 26);
            this.txt_titre_pageModifier.Name = "txt_titre_pageModifier";
            this.txt_titre_pageModifier.Size = new System.Drawing.Size(200, 22);
            this.txt_titre_pageModifier.TabIndex = 11;
            // 
            // listBoxLivres_pageModifier
            // 
            this.listBoxLivres_pageModifier.FormattingEnabled = true;
            this.listBoxLivres_pageModifier.ItemHeight = 16;
            this.listBoxLivres_pageModifier.Location = new System.Drawing.Point(411, 32);
            this.listBoxLivres_pageModifier.Name = "listBoxLivres_pageModifier";
            this.listBoxLivres_pageModifier.Size = new System.Drawing.Size(415, 500);
            this.listBoxLivres_pageModifier.TabIndex = 26;
            this.listBoxLivres_pageModifier.SelectedIndexChanged += new System.EventHandler(this.listBoxLivres_pageModifier_SelectedIndexChanged);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(95, 397);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(150, 63);
            this.btn_modifier.TabIndex = 27;
            this.btn_modifier.Text = "Enregistre";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // Modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 646);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.listBoxLivres_pageModifier);
            this.Controls.Add(this.groupBox2);
            this.Name = "Modifier";
            this.Text = "Modifier";
            this.Load += new System.EventHandler(this.Modifier_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_auteur_pageModifier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_genre_pageModifier;
        private System.Windows.Forms.ComboBox comboBox_editeur_pageModifier;
        private System.Windows.Forms.DateTimePicker dateTime_pageModifier;
        private System.Windows.Forms.TextBox txt_titre_pageModifier;
        private System.Windows.Forms.ListBox listBoxLivres_pageModifier;
        private System.Windows.Forms.Button btn_modifier;
    }
}