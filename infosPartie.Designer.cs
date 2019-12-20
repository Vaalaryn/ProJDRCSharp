namespace Jeu_de_role
{
    partial class InfosPartie
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
            this.titreLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.idPartielabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // titreLabel
            // 
            this.titreLabel.AutoSize = true;
            this.titreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.titreLabel.Location = new System.Drawing.Point(176, 36);
            this.titreLabel.Name = "titreLabel";
            this.titreLabel.Size = new System.Drawing.Size(304, 31);
            this.titreLabel.TabIndex = 0;
            this.titreLabel.Text = "Informations de la partie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(159, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "description :";
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.description_label.Location = new System.Drawing.Point(341, 131);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(64, 25);
            this.description_label.TabIndex = 2;
            this.description_label.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(455, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = " Personnage";
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 249);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1016, 262);
            this.dgv.TabIndex = 5;
            // 
            // idPartielabel
            // 
            this.idPartielabel.AutoSize = true;
            this.idPartielabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.idPartielabel.Location = new System.Drawing.Point(633, 36);
            this.idPartielabel.Name = "idPartielabel";
            this.idPartielabel.Size = new System.Drawing.Size(156, 31);
            this.idPartielabel.TabIndex = 6;
            this.idPartielabel.Text = "ID_PARTIE";
            // 
            // InfosPartie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 564);
            this.Controls.Add(this.idPartielabel);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titreLabel);
            this.Name = "InfosPartie";
            this.Text = "infosPartie";
            this.Load += new System.EventHandler(this.InfosPartie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titreLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idPartielabel;
        public System.Windows.Forms.DataGridView dgv;
    }
}