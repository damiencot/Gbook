namespace gbook
{
    partial class Auteur
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
            this.txt_auteur_pageAuteur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Enregistre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_auteur_pageAuteur
            // 
            this.txt_auteur_pageAuteur.Location = new System.Drawing.Point(106, 63);
            this.txt_auteur_pageAuteur.Name = "txt_auteur_pageAuteur";
            this.txt_auteur_pageAuteur.Size = new System.Drawing.Size(150, 22);
            this.txt_auteur_pageAuteur.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Auteur";
            // 
            // btn_Enregistre
            // 
            this.btn_Enregistre.Location = new System.Drawing.Point(92, 136);
            this.btn_Enregistre.Name = "btn_Enregistre";
            this.btn_Enregistre.Size = new System.Drawing.Size(173, 58);
            this.btn_Enregistre.TabIndex = 2;
            this.btn_Enregistre.Text = "Enregistre";
            this.btn_Enregistre.UseVisualStyleBackColor = true;
            this.btn_Enregistre.Click += new System.EventHandler(this.btn_Enregistre_Click);
            // 
            // Auteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 310);
            this.Controls.Add(this.btn_Enregistre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_auteur_pageAuteur);
            this.Name = "Auteur";
            this.Text = "Auteur";
            this.Load += new System.EventHandler(this.Auteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_auteur_pageAuteur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Enregistre;
    }
}