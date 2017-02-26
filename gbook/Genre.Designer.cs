namespace gbook
{
    partial class Genre
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
            this.txt_genre_pageGenre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Enregistre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_genre_pageGenre
            // 
            this.txt_genre_pageGenre.Location = new System.Drawing.Point(116, 69);
            this.txt_genre_pageGenre.Name = "txt_genre_pageGenre";
            this.txt_genre_pageGenre.Size = new System.Drawing.Size(145, 22);
            this.txt_genre_pageGenre.TabIndex = 0;
            this.txt_genre_pageGenre.TextChanged += new System.EventHandler(this.txt_genre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Genre";
            // 
            // btn_Enregistre
            // 
            this.btn_Enregistre.Location = new System.Drawing.Point(116, 136);
            this.btn_Enregistre.Name = "btn_Enregistre";
            this.btn_Enregistre.Size = new System.Drawing.Size(145, 44);
            this.btn_Enregistre.TabIndex = 2;
            this.btn_Enregistre.Text = "Enregistre";
            this.btn_Enregistre.UseVisualStyleBackColor = true;
            this.btn_Enregistre.Click += new System.EventHandler(this.btn_Enregistre_Click);
            // 
            // Genre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 309);
            this.Controls.Add(this.btn_Enregistre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_genre_pageGenre);
            this.Name = "Genre";
            this.Text = "Genre";
            this.Load += new System.EventHandler(this.Genre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_genre_pageGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Enregistre;
    }
}