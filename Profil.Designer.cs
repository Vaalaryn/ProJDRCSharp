namespace Jeu_de_role
{
    partial class Profil
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mail_label = new System.Windows.Forms.Label();
            this.pseudo_label = new System.Windows.Forms.Label();
            this.mail_Click = new System.Windows.Forms.Button();
            this.pseudo_Click = new System.Windows.Forms.Button();
            this.mdp_Click = new System.Windows.Forms.Button();
            this.avatar_Click = new System.Windows.Forms.Button();
            this.pseudo_value = new System.Windows.Forms.Label();
            this.mail_value = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mail_label
            // 
            this.mail_label.AutoSize = true;
            this.mail_label.Location = new System.Drawing.Point(12, 272);
            this.mail_label.Name = "mail_label";
            this.mail_label.Size = new System.Drawing.Size(45, 17);
            this.mail_label.TabIndex = 5;
            this.mail_label.Text = "Mail : ";
            // 
            // pseudo_label
            // 
            this.pseudo_label.AutoSize = true;
            this.pseudo_label.Location = new System.Drawing.Point(12, 207);
            this.pseudo_label.Name = "pseudo_label";
            this.pseudo_label.Size = new System.Drawing.Size(68, 17);
            this.pseudo_label.TabIndex = 6;
            this.pseudo_label.Text = "Pseudo : ";
            // 
            // mail_Click
            // 
            this.mail_Click.Location = new System.Drawing.Point(15, 348);
            this.mail_Click.Name = "mail_Click";
            this.mail_Click.Size = new System.Drawing.Size(88, 50);
            this.mail_Click.TabIndex = 7;
            this.mail_Click.Text = "Changer Mail";
            this.mail_Click.UseVisualStyleBackColor = true;
            this.mail_Click.Click += new System.EventHandler(this.mail_Click_Click);
            // 
            // pseudo_Click
            // 
            this.pseudo_Click.Location = new System.Drawing.Point(129, 348);
            this.pseudo_Click.Name = "pseudo_Click";
            this.pseudo_Click.Size = new System.Drawing.Size(88, 50);
            this.pseudo_Click.TabIndex = 8;
            this.pseudo_Click.Text = "Changer Pseudo";
            this.pseudo_Click.UseVisualStyleBackColor = true;
            this.pseudo_Click.Click += new System.EventHandler(this.pseudo_Click_Click);
            // 
            // mdp_Click
            // 
            this.mdp_Click.Location = new System.Drawing.Point(243, 348);
            this.mdp_Click.Name = "mdp_Click";
            this.mdp_Click.Size = new System.Drawing.Size(88, 50);
            this.mdp_Click.TabIndex = 9;
            this.mdp_Click.Text = "Changer Mdp";
            this.mdp_Click.UseVisualStyleBackColor = true;
            this.mdp_Click.Click += new System.EventHandler(this.mdp_Click_Click);
            // 
            // avatar_Click
            // 
            this.avatar_Click.Location = new System.Drawing.Point(357, 348);
            this.avatar_Click.Name = "avatar_Click";
            this.avatar_Click.Size = new System.Drawing.Size(88, 50);
            this.avatar_Click.TabIndex = 10;
            this.avatar_Click.Text = "Changer Avatar";
            this.avatar_Click.UseVisualStyleBackColor = true;
            this.avatar_Click.Click += new System.EventHandler(this.avatar_Click_Click);
            // 
            // pseudo_value
            // 
            this.pseudo_value.AutoSize = true;
            this.pseudo_value.Location = new System.Drawing.Point(12, 224);
            this.pseudo_value.Name = "pseudo_value";
            this.pseudo_value.Size = new System.Drawing.Size(16, 17);
            this.pseudo_value.TabIndex = 11;
            this.pseudo_value.Text = "?";
            // 
            // mail_value
            // 
            this.mail_value.AutoSize = true;
            this.mail_value.Location = new System.Drawing.Point(12, 289);
            this.mail_value.Name = "mail_value";
            this.mail_value.Size = new System.Drawing.Size(16, 17);
            this.mail_value.TabIndex = 12;
            this.mail_value.Text = "?";
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 410);
            this.Controls.Add(this.mail_value);
            this.Controls.Add(this.pseudo_value);
            this.Controls.Add(this.avatar_Click);
            this.Controls.Add(this.mdp_Click);
            this.Controls.Add(this.pseudo_Click);
            this.Controls.Add(this.mail_Click);
            this.Controls.Add(this.pseudo_label);
            this.Controls.Add(this.mail_label);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Profil";
            this.Text = "Profil";
            this.Load += new System.EventHandler(this.Profil_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label mail_label;
        private System.Windows.Forms.Label pseudo_label;
        private System.Windows.Forms.Button mail_Click;
        private System.Windows.Forms.Button pseudo_Click;
        private System.Windows.Forms.Button mdp_Click;
        private System.Windows.Forms.Button avatar_Click;
        private System.Windows.Forms.Label pseudo_value;
        private System.Windows.Forms.Label mail_value;
    }
}