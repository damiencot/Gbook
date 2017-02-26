namespace gbook
{
    partial class Profil
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
            this.btn_enregistre_pageProfil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mdp_pageProfil = new System.Windows.Forms.TextBox();
            this.comboBox_utilisateur_pageProfil = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mdpActuel_pageProfil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_enregistre_pageProfil
            // 
            this.btn_enregistre_pageProfil.Location = new System.Drawing.Point(126, 283);
            this.btn_enregistre_pageProfil.Name = "btn_enregistre_pageProfil";
            this.btn_enregistre_pageProfil.Size = new System.Drawing.Size(181, 55);
            this.btn_enregistre_pageProfil.TabIndex = 0;
            this.btn_enregistre_pageProfil.Text = "Enregistre";
            this.btn_enregistre_pageProfil.UseVisualStyleBackColor = true;
            this.btn_enregistre_pageProfil.Click += new System.EventHandler(this.btn_enregistre_pageProfil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mot de Passe";
            // 
            // txt_mdp_pageProfil
            // 
            this.txt_mdp_pageProfil.Location = new System.Drawing.Point(176, 139);
            this.txt_mdp_pageProfil.Name = "txt_mdp_pageProfil";
            this.txt_mdp_pageProfil.Size = new System.Drawing.Size(183, 22);
            this.txt_mdp_pageProfil.TabIndex = 5;
            // 
            // comboBox_utilisateur_pageProfil
            // 
            this.comboBox_utilisateur_pageProfil.FormattingEnabled = true;
            this.comboBox_utilisateur_pageProfil.Location = new System.Drawing.Point(176, 76);
            this.comboBox_utilisateur_pageProfil.Name = "comboBox_utilisateur_pageProfil";
            this.comboBox_utilisateur_pageProfil.Size = new System.Drawing.Size(183, 24);
            this.comboBox_utilisateur_pageProfil.TabIndex = 6;
            this.comboBox_utilisateur_pageProfil.SelectedIndexChanged += new System.EventHandler(this.comboBox_utilisateur_pageProfil_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Utilisateurs";
            // 
            // txt_mdpActuel_pageProfil
            // 
            this.txt_mdpActuel_pageProfil.Location = new System.Drawing.Point(176, 198);
            this.txt_mdpActuel_pageProfil.Name = "txt_mdpActuel_pageProfil";
            this.txt_mdpActuel_pageProfil.Size = new System.Drawing.Size(183, 22);
            this.txt_mdpActuel_pageProfil.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mot de Passe Actuel";
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 404);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_mdpActuel_pageProfil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_utilisateur_pageProfil);
            this.Controls.Add(this.txt_mdp_pageProfil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_enregistre_pageProfil);
            this.Name = "Profil";
            this.Text = "Profil";
            this.Load += new System.EventHandler(this.Profil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_enregistre_pageProfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mdp_pageProfil;
        private System.Windows.Forms.ComboBox comboBox_utilisateur_pageProfil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mdpActuel_pageProfil;
        private System.Windows.Forms.Label label3;
    }
}