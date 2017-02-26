namespace gbook
{
    partial class Editeur
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
            this.btn_Enregistre = new System.Windows.Forms.Button();
            this.txt_editeur_pageEditeur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Enregistre
            // 
            this.btn_Enregistre.Location = new System.Drawing.Point(117, 144);
            this.btn_Enregistre.Name = "btn_Enregistre";
            this.btn_Enregistre.Size = new System.Drawing.Size(148, 47);
            this.btn_Enregistre.TabIndex = 0;
            this.btn_Enregistre.Text = "Enregistre";
            this.btn_Enregistre.UseVisualStyleBackColor = true;
            this.btn_Enregistre.Click += new System.EventHandler(this.btn_Enregistre_Click);
            // 
            // txt_editeur_pageEditeur
            // 
            this.txt_editeur_pageEditeur.Location = new System.Drawing.Point(117, 73);
            this.txt_editeur_pageEditeur.Name = "txt_editeur_pageEditeur";
            this.txt_editeur_pageEditeur.Size = new System.Drawing.Size(161, 22);
            this.txt_editeur_pageEditeur.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Editeurs";
            // 
            // Editeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_editeur_pageEditeur);
            this.Controls.Add(this.btn_Enregistre);
            this.Name = "Editeur";
            this.Text = "Editeur";
            this.Load += new System.EventHandler(this.Editeur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Enregistre;
        private System.Windows.Forms.TextBox txt_editeur_pageEditeur;
        private System.Windows.Forms.Label label1;
    }
}