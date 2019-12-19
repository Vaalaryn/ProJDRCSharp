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
            this.selectPLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listJdtg)).BeginInit();
            this.SuspendLayout();
            // 
            // listJdtg
            // 
            this.listJdtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listJdtg.Location = new System.Drawing.Point(12, 46);
            this.listJdtg.Name = "listJdtg";
            this.listJdtg.Size = new System.Drawing.Size(447, 311);
            this.listJdtg.TabIndex = 0;
            this.listJdtg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listJdtg_CellContentClick);
            // 
            // selectPLbl
            // 
            this.selectPLbl.AutoSize = true;
            this.selectPLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPLbl.Location = new System.Drawing.Point(12, 19);
            this.selectPLbl.Name = "selectPLbl";
            this.selectPLbl.Size = new System.Drawing.Size(288, 24);
            this.selectPLbl.TabIndex = 1;
            this.selectPLbl.Text = "Selectionner un personnage :";
            // 
            // ModifInventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectPLbl);
            this.Controls.Add(this.listJdtg);
            this.Name = "ModifInventaire";
            this.Text = "ModifInventaire";
            this.Load += new System.EventHandler(this.ModifInventaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listJdtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listJdtg;
        private System.Windows.Forms.Label selectPLbl;
    }
}