namespace Jeu_de_role
{
    partial class ChangeAvatar
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
            this.mdp_value = new System.Windows.Forms.TextBox();
            this.linkTxt = new System.Windows.Forms.TextBox();
            this.rechercheImgButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 159);
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
            this.button1.Location = new System.Drawing.Point(107, 159);
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
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mot de passe :";
            // 
            // mdp_value
            // 
            this.mdp_value.Location = new System.Drawing.Point(9, 24);
            this.mdp_value.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mdp_value.Name = "mdp_value";
            this.mdp_value.PasswordChar = '*';
            this.mdp_value.Size = new System.Drawing.Size(188, 20);
            this.mdp_value.TabIndex = 7;
            // 
            // linkTxt
            // 
            this.linkTxt.Location = new System.Drawing.Point(9, 80);
            this.linkTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.linkTxt.Name = "linkTxt";
            this.linkTxt.Size = new System.Drawing.Size(188, 20);
            this.linkTxt.TabIndex = 17;
            // 
            // rechercheImgButton
            // 
            this.rechercheImgButton.Location = new System.Drawing.Point(114, 103);
            this.rechercheImgButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rechercheImgButton.Name = "rechercheImgButton";
            this.rechercheImgButton.Size = new System.Drawing.Size(82, 26);
            this.rechercheImgButton.TabIndex = 16;
            this.rechercheImgButton.Text = "Parcourir";
            this.rechercheImgButton.UseVisualStyleBackColor = true;
            this.rechercheImgButton.Click += new System.EventHandler(this.rechercheImgButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(210, 24);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(119, 141);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 15;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Avatar :";
            // 
            // ChangeAvatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 184);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkTxt);
            this.Controls.Add(this.rechercheImgButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mdp_value);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChangeAvatar";
            this.Text = "Modifier avatar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mdp_value;
        private System.Windows.Forms.TextBox linkTxt;
        private System.Windows.Forms.Button rechercheImgButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
    }
}