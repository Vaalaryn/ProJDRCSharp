namespace Jeu_de_role
{
    partial class modifJ
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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.nbVie = new System.Windows.Forms.NumericUpDown();
            this.nbMana = new System.Windows.Forms.NumericUpDown();
            this.nbXp = new System.Windows.Forms.NumericUpDown();
            this.nbNiveau = new System.Windows.Forms.NumericUpDown();
            this.lblVie = new System.Windows.Forms.Label();
            this.lblMana = new System.Windows.Forms.Label();
            this.lblXp = new System.Windows.Forms.Label();
            this.lblNiveau = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nbVie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbMana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbXp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbNiveau)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(12, 55);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(464, 20);
            this.txtNom.TabIndex = 0;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(12, 123);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.ReadOnly = true;
            this.txtPrenom.Size = new System.Drawing.Size(464, 20);
            this.txtPrenom.TabIndex = 1;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 39);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(12, 107);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 3;
            this.lblPrenom.Text = "Prenom";
            // 
            // nbVie
            // 
            this.nbVie.Location = new System.Drawing.Point(14, 223);
            this.nbVie.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nbVie.Name = "nbVie";
            this.nbVie.Size = new System.Drawing.Size(93, 20);
            this.nbVie.TabIndex = 4;
            // 
            // nbMana
            // 
            this.nbMana.Location = new System.Drawing.Point(137, 223);
            this.nbMana.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nbMana.Name = "nbMana";
            this.nbMana.Size = new System.Drawing.Size(93, 20);
            this.nbMana.TabIndex = 6;
            // 
            // nbXp
            // 
            this.nbXp.Location = new System.Drawing.Point(260, 223);
            this.nbXp.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nbXp.Name = "nbXp";
            this.nbXp.Size = new System.Drawing.Size(93, 20);
            this.nbXp.TabIndex = 7;
            // 
            // nbNiveau
            // 
            this.nbNiveau.Location = new System.Drawing.Point(383, 223);
            this.nbNiveau.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nbNiveau.Name = "nbNiveau";
            this.nbNiveau.Size = new System.Drawing.Size(93, 20);
            this.nbNiveau.TabIndex = 8;
            // 
            // lblVie
            // 
            this.lblVie.AutoSize = true;
            this.lblVie.Location = new System.Drawing.Point(12, 207);
            this.lblVie.Name = "lblVie";
            this.lblVie.Size = new System.Drawing.Size(22, 13);
            this.lblVie.TabIndex = 9;
            this.lblVie.Text = "Vie";
            // 
            // lblMana
            // 
            this.lblMana.AutoSize = true;
            this.lblMana.Location = new System.Drawing.Point(134, 207);
            this.lblMana.Name = "lblMana";
            this.lblMana.Size = new System.Drawing.Size(34, 13);
            this.lblMana.TabIndex = 10;
            this.lblMana.Text = "Mana";
            // 
            // lblXp
            // 
            this.lblXp.AutoSize = true;
            this.lblXp.Location = new System.Drawing.Point(257, 207);
            this.lblXp.Name = "lblXp";
            this.lblXp.Size = new System.Drawing.Size(60, 13);
            this.lblXp.TabIndex = 11;
            this.lblXp.Text = "Experience";
            // 
            // lblNiveau
            // 
            this.lblNiveau.AutoSize = true;
            this.lblNiveau.Location = new System.Drawing.Point(380, 207);
            this.lblNiveau.Name = "lblNiveau";
            this.lblNiveau.Size = new System.Drawing.Size(41, 13);
            this.lblNiveau.TabIndex = 12;
            this.lblNiveau.Text = "Niveau";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(182, 290);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(140, 37);
            this.btnValider.TabIndex = 13;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // modifJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 349);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblNiveau);
            this.Controls.Add(this.lblXp);
            this.Controls.Add(this.lblMana);
            this.Controls.Add(this.lblVie);
            this.Controls.Add(this.nbNiveau);
            this.Controls.Add(this.nbXp);
            this.Controls.Add(this.nbMana);
            this.Controls.Add(this.nbVie);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Name = "modifJ";
            this.Text = "modifJ";
            ((System.ComponentModel.ISupportInitialize)(this.nbVie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbMana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbXp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbNiveau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.NumericUpDown nbVie;
        private System.Windows.Forms.NumericUpDown nbMana;
        private System.Windows.Forms.NumericUpDown nbXp;
        private System.Windows.Forms.NumericUpDown nbNiveau;
        private System.Windows.Forms.Label lblVie;
        private System.Windows.Forms.Label lblMana;
        private System.Windows.Forms.Label lblXp;
        private System.Windows.Forms.Label lblNiveau;
        private System.Windows.Forms.Button btnValider;
    }
}