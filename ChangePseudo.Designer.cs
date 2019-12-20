namespace Jeu_de_role
{
    partial class ChangePseudo
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_mail = new System.Windows.Forms.Label();
            this.mdp = new System.Windows.Forms.TextBox();
            this.pseudo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mot de passe :";
            // 
            // label_mail
            // 
            this.label_mail.AutoSize = true;
            this.label_mail.Location = new System.Drawing.Point(12, 7);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(125, 17);
            this.label_mail.TabIndex = 8;
            this.label_mail.Text = "Nouveau Pseudo: ";
            // 
            // mdp
            // 
            this.mdp.Location = new System.Drawing.Point(12, 81);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(250, 22);
            this.mdp.TabIndex = 7;
            // 
            // pseudo
            // 
            this.pseudo.Location = new System.Drawing.Point(12, 27);
            this.pseudo.Name = "pseudo";
            this.pseudo.Size = new System.Drawing.Size(250, 22);
            this.pseudo.TabIndex = 6;
            // 
            // ChangePseudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 159);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_mail);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.pseudo);
            this.Name = "ChangePseudo";
            this.Text = "Modifier pseudo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.TextBox mdp;
        private System.Windows.Forms.TextBox pseudo;
    }
}