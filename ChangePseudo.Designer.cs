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
            this.button2.Location = new System.Drawing.Point(2, 102);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 19);
            this.button2.TabIndex = 11;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 102);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 19);
            this.button1.TabIndex = 10;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mot de passe :";
            // 
            // label_mail
            // 
            this.label_mail.AutoSize = true;
            this.label_mail.Location = new System.Drawing.Point(9, 6);
            this.label_mail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(96, 13);
            this.label_mail.TabIndex = 8;
            this.label_mail.Text = "Nouveau Pseudo: ";
            // 
            // mdp
            // 
            this.mdp.Location = new System.Drawing.Point(9, 66);
            this.mdp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mdp.Name = "mdp";
            this.mdp.PasswordChar = '*';
            this.mdp.Size = new System.Drawing.Size(188, 20);
            this.mdp.TabIndex = 7;
            // 
            // pseudo
            // 
            this.pseudo.Location = new System.Drawing.Point(9, 22);
            this.pseudo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pseudo.Name = "pseudo";
            this.pseudo.Size = new System.Drawing.Size(188, 20);
            this.pseudo.TabIndex = 6;
            // 
            // ChangePseudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 129);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_mail);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.pseudo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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