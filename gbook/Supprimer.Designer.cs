namespace gbook
{
    partial class Supprimer
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
            this.listBoxLivres_PageSupprimer = new System.Windows.Forms.ListBox();
            this.btn_Supprimer_PageSupprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxLivres_PageSupprimer
            // 
            this.listBoxLivres_PageSupprimer.FormattingEnabled = true;
            this.listBoxLivres_PageSupprimer.ItemHeight = 16;
            this.listBoxLivres_PageSupprimer.Location = new System.Drawing.Point(12, 100);
            this.listBoxLivres_PageSupprimer.Name = "listBoxLivres_PageSupprimer";
            this.listBoxLivres_PageSupprimer.Size = new System.Drawing.Size(815, 516);
            this.listBoxLivres_PageSupprimer.TabIndex = 0;
            this.listBoxLivres_PageSupprimer.SelectedIndexChanged += new System.EventHandler(this.listBoxLivres_PageSupprimer_SelectedIndexChanged);
            // 
            // btn_Supprimer_PageSupprimer
            // 
            this.btn_Supprimer_PageSupprimer.Location = new System.Drawing.Point(323, 27);
            this.btn_Supprimer_PageSupprimer.Name = "btn_Supprimer_PageSupprimer";
            this.btn_Supprimer_PageSupprimer.Size = new System.Drawing.Size(161, 47);
            this.btn_Supprimer_PageSupprimer.TabIndex = 1;
            this.btn_Supprimer_PageSupprimer.Text = "Supprimer";
            this.btn_Supprimer_PageSupprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer_PageSupprimer.Click += new System.EventHandler(this.btn_Supprimer_PageSupprimer_Click);
            // 
            // Supprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 629);
            this.Controls.Add(this.btn_Supprimer_PageSupprimer);
            this.Controls.Add(this.listBoxLivres_PageSupprimer);
            this.Name = "Supprimer";
            this.Text = "Supprimer";
            this.Load += new System.EventHandler(this.Supprimer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLivres_PageSupprimer;
        private System.Windows.Forms.Button btn_Supprimer_PageSupprimer;
    }
}