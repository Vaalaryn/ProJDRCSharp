namespace Jeu_de_role
{
    partial class ChangeMDP
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
            this.quit = new System.Windows.Forms.Button();
            this.validate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_mail = new System.Windows.Forms.Label();
            this.new_mdp = new System.Windows.Forms.TextBox();
            this.old_mdp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.conf_new_mdp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(9, 139);
            this.quit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(92, 19);
            this.quit.TabIndex = 11;
            this.quit.Text = "Annuler";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // validate
            // 
            this.validate.Location = new System.Drawing.Point(107, 139);
            this.validate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(89, 19);
            this.validate.TabIndex = 10;
            this.validate.Text = "Valider";
            this.validate.UseVisualStyleBackColor = true;
            this.validate.Click += new System.EventHandler(this.validate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ancient mot de passe :";
            // 
            // label_mail
            // 
            this.label_mail.AutoSize = true;
            this.label_mail.Location = new System.Drawing.Point(7, 50);
            this.label_mail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(117, 13);
            this.label_mail.TabIndex = 8;
            this.label_mail.Text = "Nouveau mot de passe";
            // 
            // new_mdp
            // 
            this.new_mdp.Location = new System.Drawing.Point(9, 67);
            this.new_mdp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.new_mdp.Name = "new_mdp";
            this.new_mdp.PasswordChar = '*';
            this.new_mdp.Size = new System.Drawing.Size(188, 20);
            this.new_mdp.TabIndex = 7;
            // 
            // old_mdp
            // 
            this.old_mdp.Location = new System.Drawing.Point(9, 23);
            this.old_mdp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.old_mdp.Name = "old_mdp";
            this.old_mdp.PasswordChar = '*';
            this.old_mdp.Size = new System.Drawing.Size(188, 20);
            this.old_mdp.TabIndex = 6;
            this.old_mdp.TextChanged += new System.EventHandler(this.old_mdp_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Confirmer nouveau mot de passe";
            // 
            // conf_new_mdp
            // 
            this.conf_new_mdp.Location = new System.Drawing.Point(9, 110);
            this.conf_new_mdp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.conf_new_mdp.Name = "conf_new_mdp";
            this.conf_new_mdp.PasswordChar = '*';
            this.conf_new_mdp.Size = new System.Drawing.Size(188, 20);
            this.conf_new_mdp.TabIndex = 12;
            // 
            // ChangeMDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 168);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conf_new_mdp);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_mail);
            this.Controls.Add(this.new_mdp);
            this.Controls.Add(this.old_mdp);
            this.Name = "ChangeMDP";
            this.Text = "Modifier mot de passe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button validate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.TextBox new_mdp;
        private System.Windows.Forms.TextBox old_mdp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox conf_new_mdp;
    }
}