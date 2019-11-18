namespace Jeu_de_role
{
    partial class Inscription
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
            this.mailTxt = new System.Windows.Forms.TextBox();
            this.pseudoTxt = new System.Windows.Forms.TextBox();
            this.mdpTxt = new System.Windows.Forms.TextBox();
            this.confirmMdpTxt = new System.Windows.Forms.TextBox();
            this.mailLabel = new System.Windows.Forms.Label();
            this.pseudoLabel = new System.Windows.Forms.Label();
            this.mdpLabel = new System.Windows.Forms.Label();
            this.confirmMdpLabel = new System.Windows.Forms.Label();
            this.avatarLabel = new System.Windows.Forms.Label();
            this.confirmerButton = new System.Windows.Forms.Button();
            this.inscriptionLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.rechercheImgButton = new System.Windows.Forms.Button();
            this.rechercheImg = new System.DirectoryServices.DirectorySearcher();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mailTxt
            // 
            this.mailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailTxt.Location = new System.Drawing.Point(12, 109);
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.Size = new System.Drawing.Size(392, 30);
            this.mailTxt.TabIndex = 0;
            // 
            // pseudoTxt
            // 
            this.pseudoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pseudoTxt.Location = new System.Drawing.Point(12, 188);
            this.pseudoTxt.Name = "pseudoTxt";
            this.pseudoTxt.Size = new System.Drawing.Size(392, 30);
            this.pseudoTxt.TabIndex = 1;
            // 
            // mdpTxt
            // 
            this.mdpTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdpTxt.Location = new System.Drawing.Point(12, 263);
            this.mdpTxt.Name = "mdpTxt";
            this.mdpTxt.Size = new System.Drawing.Size(392, 30);
            this.mdpTxt.TabIndex = 2;
            // 
            // confirmMdpTxt
            // 
            this.confirmMdpTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmMdpTxt.Location = new System.Drawing.Point(12, 341);
            this.confirmMdpTxt.Name = "confirmMdpTxt";
            this.confirmMdpTxt.Size = new System.Drawing.Size(392, 30);
            this.confirmMdpTxt.TabIndex = 3;
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailLabel.Location = new System.Drawing.Point(12, 78);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(59, 25);
            this.mailLabel.TabIndex = 5;
            this.mailLabel.Text = "Mail :";
            // 
            // pseudoLabel
            // 
            this.pseudoLabel.AutoSize = true;
            this.pseudoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pseudoLabel.Location = new System.Drawing.Point(12, 160);
            this.pseudoLabel.Name = "pseudoLabel";
            this.pseudoLabel.Size = new System.Drawing.Size(90, 25);
            this.pseudoLabel.TabIndex = 6;
            this.pseudoLabel.Text = "Pseudo :";
            // 
            // mdpLabel
            // 
            this.mdpLabel.AutoSize = true;
            this.mdpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdpLabel.Location = new System.Drawing.Point(12, 235);
            this.mdpLabel.Name = "mdpLabel";
            this.mdpLabel.Size = new System.Drawing.Size(141, 25);
            this.mdpLabel.TabIndex = 7;
            this.mdpLabel.Text = "Mot de passe :";
            // 
            // confirmMdpLabel
            // 
            this.confirmMdpLabel.AutoSize = true;
            this.confirmMdpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmMdpLabel.Location = new System.Drawing.Point(12, 313);
            this.confirmMdpLabel.Name = "confirmMdpLabel";
            this.confirmMdpLabel.Size = new System.Drawing.Size(231, 25);
            this.confirmMdpLabel.TabIndex = 8;
            this.confirmMdpLabel.Text = "Confirmer Mot de passe :";
            // 
            // avatarLabel
            // 
            this.avatarLabel.AutoSize = true;
            this.avatarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avatarLabel.Location = new System.Drawing.Point(7, 410);
            this.avatarLabel.Name = "avatarLabel";
            this.avatarLabel.Size = new System.Drawing.Size(85, 25);
            this.avatarLabel.TabIndex = 9;
            this.avatarLabel.Text = "Avatar  :";
            // 
            // confirmerButton
            // 
            this.confirmerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmerButton.Location = new System.Drawing.Point(121, 486);
            this.confirmerButton.Name = "confirmerButton";
            this.confirmerButton.Size = new System.Drawing.Size(166, 41);
            this.confirmerButton.TabIndex = 10;
            this.confirmerButton.Text = "Confirmer";
            this.confirmerButton.UseVisualStyleBackColor = true;
            this.confirmerButton.Click += new System.EventHandler(this.confirmerButton_Click);
            // 
            // inscriptionLabel
            // 
            this.inscriptionLabel.AutoSize = true;
            this.inscriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inscriptionLabel.Location = new System.Drawing.Point(114, 19);
            this.inscriptionLabel.Name = "inscriptionLabel";
            this.inscriptionLabel.Size = new System.Drawing.Size(165, 38);
            this.inscriptionLabel.TabIndex = 11;
            this.inscriptionLabel.Text = "Inscription";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(98, 393);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 74);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 12;
            this.pictureBox.TabStop = false;
            // 
            // rechercheImgButton
            // 
            this.rechercheImgButton.Location = new System.Drawing.Point(217, 409);
            this.rechercheImgButton.Name = "rechercheImgButton";
            this.rechercheImgButton.Size = new System.Drawing.Size(110, 32);
            this.rechercheImgButton.TabIndex = 13;
            this.rechercheImgButton.Text = "Browse";
            this.rechercheImgButton.UseVisualStyleBackColor = true;
            this.rechercheImgButton.Click += new System.EventHandler(this.rechercheImgButton_Click);
            // 
            // rechercheImg
            // 
            this.rechercheImg.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.rechercheImg.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.rechercheImg.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 539);
            this.Controls.Add(this.rechercheImgButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.inscriptionLabel);
            this.Controls.Add(this.confirmerButton);
            this.Controls.Add(this.avatarLabel);
            this.Controls.Add(this.confirmMdpLabel);
            this.Controls.Add(this.mdpLabel);
            this.Controls.Add(this.pseudoLabel);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.confirmMdpTxt);
            this.Controls.Add(this.mdpTxt);
            this.Controls.Add(this.pseudoTxt);
            this.Controls.Add(this.mailTxt);
            this.Name = "Inscription";
            this.Text = "Inscription";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mailTxt;
        private System.Windows.Forms.TextBox pseudoTxt;
        private System.Windows.Forms.TextBox mdpTxt;
        private System.Windows.Forms.TextBox confirmMdpTxt;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Label pseudoLabel;
        private System.Windows.Forms.Label mdpLabel;
        private System.Windows.Forms.Label confirmMdpLabel;
        private System.Windows.Forms.Label avatarLabel;
        private System.Windows.Forms.Button confirmerButton;
        private System.Windows.Forms.Label inscriptionLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button rechercheImgButton;
        private System.DirectoryServices.DirectorySearcher rechercheImg;
    }
}