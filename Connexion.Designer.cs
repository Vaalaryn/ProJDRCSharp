namespace Jeu_de_role
{
    partial class Connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.inscriptionLink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.loginLbl = new System.Windows.Forms.Label();
            this.mdpLbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginTxt
            // 
            this.loginTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTxt.Location = new System.Drawing.Point(12, 120);
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.Size = new System.Drawing.Size(526, 26);
            this.loginTxt.TabIndex = 0;
            this.loginTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.loginTxt_KeyUp);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(12, 203);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(526, 26);
            this.passwordTxt.TabIndex = 1;
            this.passwordTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.passwordTxt_KeyUp);
            // 
            // inscriptionLink
            // 
            this.inscriptionLink.AutoSize = true;
            this.inscriptionLink.Location = new System.Drawing.Point(9, 232);
            this.inscriptionLink.Name = "inscriptionLink";
            this.inscriptionLink.Size = new System.Drawing.Size(85, 13);
            this.inscriptionLink.TabIndex = 2;
            this.inscriptionLink.TabStop = true;
            this.inscriptionLink.Text = "Créer un compte";
            this.inscriptionLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.inscriptionLink_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jeu de rôle";
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLbl.Location = new System.Drawing.Point(8, 97);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(63, 20);
            this.loginLbl.TabIndex = 4;
            this.loginLbl.Text = "Pseudo";
            // 
            // mdpLbl
            // 
            this.mdpLbl.AutoSize = true;
            this.mdpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdpLbl.Location = new System.Drawing.Point(8, 180);
            this.mdpLbl.Name = "mdpLbl";
            this.mdpLbl.Size = new System.Drawing.Size(105, 20);
            this.mdpLbl.TabIndex = 5;
            this.mdpLbl.Text = "Mot de passe";
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(202, 273);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(141, 31);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Se connecter";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 316);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.mdpLbl);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inscriptionLink);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.loginTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Connexion";
            this.Text = "Se connecter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.LinkLabel inscriptionLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.Label mdpLbl;
        private System.Windows.Forms.Button loginBtn;
    }
}

