namespace Jeu_de_role
{
    partial class RejoindrePartie
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblTitrePartie = new System.Windows.Forms.Label();
            this.lblDescriptionPartie = new System.Windows.Forms.Label();
            this.btnNewPerso = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.txtPersoName = new System.Windows.Forms.TextBox();
            this.btnRejoindre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(31, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(257, 31);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Rejoindre une partie";
            // 
            // lblTitrePartie
            // 
            this.lblTitrePartie.AutoSize = true;
            this.lblTitrePartie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitrePartie.Location = new System.Drawing.Point(13, 66);
            this.lblTitrePartie.Name = "lblTitrePartie";
            this.lblTitrePartie.Size = new System.Drawing.Size(55, 25);
            this.lblTitrePartie.TabIndex = 1;
            this.lblTitrePartie.Text = "Titre";
            // 
            // lblDescriptionPartie
            // 
            this.lblDescriptionPartie.AutoSize = true;
            this.lblDescriptionPartie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionPartie.Location = new System.Drawing.Point(12, 129);
            this.lblDescriptionPartie.Name = "lblDescriptionPartie";
            this.lblDescriptionPartie.Size = new System.Drawing.Size(120, 25);
            this.lblDescriptionPartie.TabIndex = 2;
            this.lblDescriptionPartie.Text = "Description";
            // 
            // btnNewPerso
            // 
            this.btnNewPerso.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNewPerso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPerso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewPerso.Location = new System.Drawing.Point(268, 287);
            this.btnNewPerso.Name = "btnNewPerso";
            this.btnNewPerso.Size = new System.Drawing.Size(37, 33);
            this.btnNewPerso.TabIndex = 3;
            this.btnNewPerso.Text = "+";
            this.btnNewPerso.UseVisualStyleBackColor = false;
            this.btnNewPerso.Click += new System.EventHandler(this.btnNewPerso_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(16, 163);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(289, 102);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.Text = "";
            // 
            // txtTitre
            // 
            this.txtTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitre.Location = new System.Drawing.Point(15, 97);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.ReadOnly = true;
            this.txtTitre.Size = new System.Drawing.Size(290, 31);
            this.txtTitre.TabIndex = 5;
            // 
            // txtPersoName
            // 
            this.txtPersoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersoName.Location = new System.Drawing.Point(15, 287);
            this.txtPersoName.Name = "txtPersoName";
            this.txtPersoName.ReadOnly = true;
            this.txtPersoName.Size = new System.Drawing.Size(247, 31);
            this.txtPersoName.TabIndex = 6;
            // 
            // btnRejoindre
            // 
            this.btnRejoindre.Enabled = false;
            this.btnRejoindre.Location = new System.Drawing.Point(15, 340);
            this.btnRejoindre.Name = "btnRejoindre";
            this.btnRejoindre.Size = new System.Drawing.Size(290, 98);
            this.btnRejoindre.TabIndex = 7;
            this.btnRejoindre.Text = "Rejoindre";
            this.btnRejoindre.UseVisualStyleBackColor = true;
            // 
            // InfoPartie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 450);
            this.Controls.Add(this.btnRejoindre);
            this.Controls.Add(this.txtPersoName);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnNewPerso);
            this.Controls.Add(this.lblDescriptionPartie);
            this.Controls.Add(this.lblTitrePartie);
            this.Controls.Add(this.lblTitre);
            this.Name = "InfoPartie";
            this.Text = "Rejoindre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblTitrePartie;
        private System.Windows.Forms.Label lblDescriptionPartie;
        private System.Windows.Forms.Button btnNewPerso;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.TextBox txtPersoName;
        private System.Windows.Forms.Button btnRejoindre;
    }
}