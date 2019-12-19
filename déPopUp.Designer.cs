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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.resultDeDtg.Size = new System.Drawing.Size(377, 60);
            this.resultDeDtg.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            // 
            // déPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 361);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}