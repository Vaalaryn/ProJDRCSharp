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
            this.quit.Location = new System.Drawing.Point(12, 171);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(123, 23);
            this.quit.TabIndex = 11;
            this.quit.Text = "Annuler";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // validate
            // 
            this.validate.Location = new System.Drawing.Point(143, 171);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(119, 23);
            this.validate.TabIndex = 10;
            this.validate.Text = "Valider";
            this.validate.UseVisualStyleBackColor = true;
            this.validate.Click += new System.EventHandler(this.validate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ancient mot de passe :";
            // 
            // label_mail
            // 
            this.label_mail.AutoSize = true;
            this.label_mail.Location = new System.Drawing.Point(9, 62);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(154, 17);
            this.label_mail.TabIndex = 8;
            this.label_mail.Text = "Nouveau mot de passe";
            // 
            // new_mdp
            // 
            this.new_mdp.Location = new System.Drawing.Point(12, 82);
            this.new_mdp.Name = "new_mdp";
            this.new_mdp.Size = new System.Drawing.Size(250, 22);
            this.new_mdp.TabIndex = 7;
            // 
            // old_mdp
            // 
            this.old_mdp.Location = new System.Drawing.Point(12, 28);
            this.old_mdp.Name = "old_mdp";
            this.old_mdp.Size = new System.Drawing.Size(250, 22);
            this.old_mdp.TabIndex = 6;
            this.old_mdp.TextChanged += new System.EventHandler(this.old_mdp_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Confirmer nouveau mot de passe";
            // 
            // conf_new_mdp
            // 
            this.conf_new_mdp.Location = new System.Drawing.Point(12, 136);
            this.conf_new_mdp.Name = "conf_new_mdp";
            this.conf_new_mdp.Size = new System.Drawing.Size(250, 22);
            this.conf_new_mdp.TabIndex = 12;
            // 
            // ChangeMDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 207);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conf_new_mdp);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_mail);
            this.Controls.Add(this.new_mdp);
            this.Controls.Add(this.old_mdp);
            this.Margin = new System.Windows.Forms.Padding(4);
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