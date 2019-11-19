namespace Jeu_de_role
{
    partial class CreationPartie
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
            this.CreateGameBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleGameTxtBx = new System.Windows.Forms.TextBox();
            this.DescScenarLbl = new System.Windows.Forms.Label();
            this.UniversLbl = new System.Windows.Forms.Label();
            this.UniversTxtBx = new System.Windows.Forms.TextBox();
            this.dgvDescScenar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescScenar)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateGameBtn
            // 
            this.CreateGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateGameBtn.Location = new System.Drawing.Point(600, 402);
            this.CreateGameBtn.Name = "CreateGameBtn";
            this.CreateGameBtn.Size = new System.Drawing.Size(188, 36);
            this.CreateGameBtn.TabIndex = 0;
            this.CreateGameBtn.Text = "Créer la partie";
            this.CreateGameBtn.UseVisualStyleBackColor = true;
            this.CreateGameBtn.Click += new System.EventHandler(this.CreateGameBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titre du scenario :";
            // 
            // TitleGameTxtBx
            // 
            this.TitleGameTxtBx.Location = new System.Drawing.Point(151, 8);
            this.TitleGameTxtBx.Name = "TitleGameTxtBx";
            this.TitleGameTxtBx.Size = new System.Drawing.Size(337, 20);
            this.TitleGameTxtBx.TabIndex = 2;
            // 
            // DescScenarLbl
            // 
            this.DescScenarLbl.AutoSize = true;
            this.DescScenarLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescScenarLbl.Location = new System.Drawing.Point(12, 177);
            this.DescScenarLbl.Name = "DescScenarLbl";
            this.DescScenarLbl.Size = new System.Drawing.Size(180, 16);
            this.DescScenarLbl.TabIndex = 3;
            this.DescScenarLbl.Text = "Description du scenario :";
            // 
            // UniversLbl
            // 
            this.UniversLbl.AutoSize = true;
            this.UniversLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UniversLbl.Location = new System.Drawing.Point(76, 40);
            this.UniversLbl.Name = "UniversLbl";
            this.UniversLbl.Size = new System.Drawing.Size(69, 16);
            this.UniversLbl.TabIndex = 5;
            this.UniversLbl.Text = "Univers :";
            // 
            // UniversTxtBx
            // 
            this.UniversTxtBx.Location = new System.Drawing.Point(151, 39);
            this.UniversTxtBx.Name = "UniversTxtBx";
            this.UniversTxtBx.Size = new System.Drawing.Size(186, 20);
            this.UniversTxtBx.TabIndex = 6;
            // 
            // dgvDescScenar
            // 
            this.dgvDescScenar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescScenar.Location = new System.Drawing.Point(15, 196);
            this.dgvDescScenar.Name = "dgvDescScenar";
            this.dgvDescScenar.Size = new System.Drawing.Size(579, 242);
            this.dgvDescScenar.TabIndex = 7;
            // 
            // CreationPartie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDescScenar);
            this.Controls.Add(this.UniversTxtBx);
            this.Controls.Add(this.UniversLbl);
            this.Controls.Add(this.DescScenarLbl);
            this.Controls.Add(this.TitleGameTxtBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateGameBtn);
            this.Name = "CreationPartie";
            this.Text = "CreationPartie";
            this.Load += new System.EventHandler(this.CreationPartie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescScenar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateGameBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleGameTxtBx;
        private System.Windows.Forms.Label DescScenarLbl;
        private System.Windows.Forms.Label UniversLbl;
        private System.Windows.Forms.TextBox UniversTxtBx;
        private System.Windows.Forms.DataGridView dgvDescScenar;
    }
}