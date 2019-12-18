namespace Jeu_de_role
{
    partial class déPopUp
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
            this.déFacetxtBx = new System.Windows.Forms.TextBox();
            this.nbFaceLbl = new System.Windows.Forms.Label();
            this.lancerBtn = new System.Windows.Forms.Button();
            this.nbDéLbl = new System.Windows.Forms.Label();
            this.déNbtxtBx = new System.Windows.Forms.TextBox();
            this.resultDeDtg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.resultDeDtg)).BeginInit();
            this.SuspendLayout();
            // 
            // déFacetxtBx
            // 
            this.déFacetxtBx.Location = new System.Drawing.Point(217, 25);
            this.déFacetxtBx.Name = "déFacetxtBx";
            this.déFacetxtBx.Size = new System.Drawing.Size(100, 20);
            this.déFacetxtBx.TabIndex = 1;
            this.déFacetxtBx.TextChanged += new System.EventHandler(this.déFacetxtBx_TextChanged);
            // 
            // nbFaceLbl
            // 
            this.nbFaceLbl.AutoSize = true;
            this.nbFaceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbFaceLbl.Location = new System.Drawing.Point(61, 25);
            this.nbFaceLbl.Name = "nbFaceLbl";
            this.nbFaceLbl.Size = new System.Drawing.Size(146, 20);
            this.nbFaceLbl.TabIndex = 4;
            this.nbFaceLbl.Text = "Nombre de face :";
            // 
            // lancerBtn
            // 
            this.lancerBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lancerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lancerBtn.Location = new System.Drawing.Point(120, 114);
            this.lancerBtn.Name = "lancerBtn";
            this.lancerBtn.Size = new System.Drawing.Size(145, 57);
            this.lancerBtn.TabIndex = 5;
            this.lancerBtn.Text = "Lancer !";
            this.lancerBtn.UseVisualStyleBackColor = false;
            this.lancerBtn.Click += new System.EventHandler(this.lancerBtn_Click);
            // 
            // nbDéLbl
            // 
            this.nbDéLbl.AutoSize = true;
            this.nbDéLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbDéLbl.Location = new System.Drawing.Point(61, 62);
            this.nbDéLbl.Name = "nbDéLbl";
            this.nbDéLbl.Size = new System.Drawing.Size(140, 20);
            this.nbDéLbl.TabIndex = 8;
            this.nbDéLbl.Text = "Nombre de dés :";
            // 
            // déNbtxtBx
            // 
            this.déNbtxtBx.Location = new System.Drawing.Point(217, 64);
            this.déNbtxtBx.Name = "déNbtxtBx";
            this.déNbtxtBx.Size = new System.Drawing.Size(100, 20);
            this.déNbtxtBx.TabIndex = 9;
            // 
            // resultDeDtg
            // 
            this.resultDeDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDeDtg.Location = new System.Drawing.Point(10, 196);
            this.resultDeDtg.Name = "resultDeDtg";
            this.resultDeDtg.Size = new System.Drawing.Size(377, 92);
            this.resultDeDtg.TabIndex = 10;
            // 
            // déPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 300);
            this.Controls.Add(this.resultDeDtg);
            this.Controls.Add(this.déNbtxtBx);
            this.Controls.Add(this.nbDéLbl);
            this.Controls.Add(this.lancerBtn);
            this.Controls.Add(this.nbFaceLbl);
            this.Controls.Add(this.déFacetxtBx);
            this.Name = "déPopUp";
            this.Text = "déPopUp";
            this.Load += new System.EventHandler(this.déPopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultDeDtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox déFacetxtBx;
        private System.Windows.Forms.Label nbFaceLbl;
        private System.Windows.Forms.Button lancerBtn;
        private System.Windows.Forms.Label nbDéLbl;
        private System.Windows.Forms.TextBox déNbtxtBx;
        private System.Windows.Forms.DataGridView resultDeDtg;
    }
}