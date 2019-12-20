namespace Jeu_de_role
{
    partial class ModifInventaire
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
            this.listJdtg = new System.Windows.Forms.DataGridView();
            this.NomObjet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attribut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listJdtg)).BeginInit();
            this.SuspendLayout();
            // 
            // listJdtg
            // 
            this.listJdtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listJdtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomObjet,
            this.Attribut});
            this.listJdtg.Location = new System.Drawing.Point(31, 24);
            this.listJdtg.Name = "listJdtg";
            this.listJdtg.Size = new System.Drawing.Size(593, 318);
            this.listJdtg.TabIndex = 0;
            this.listJdtg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listJdtg_CellContentClick);
            // 
            // NomObjet
            // 
            this.NomObjet.HeaderText = "Nom Objet";
            this.NomObjet.Name = "NomObjet";
            this.NomObjet.ReadOnly = true;
            // 
            // Attribut
            // 
            this.Attribut.HeaderText = "Attribut";
            this.Attribut.Name = "Attribut";
            this.Attribut.ReadOnly = true;
            // 
            // ModifInventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listJdtg);
            this.Name = "ModifInventaire";
            this.Text = "ModifInventaire";
            ((System.ComponentModel.ISupportInitialize)(this.listJdtg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listJdtg;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomObjet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attribut;
    }
}