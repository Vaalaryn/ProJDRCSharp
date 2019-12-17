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
            this.userPseudodgv = new System.Windows.Forms.DataGridView();
            this.persoListdgv = new System.Windows.Forms.DataGridView();
            this.modifPseudoUser = new System.Windows.Forms.Button();
            this.pseudoUserIndication = new System.Windows.Forms.Label();
            this.persoList = new System.Windows.Forms.Label();
            this.modifMdpUser = new System.Windows.Forms.Button();
            this.delPerso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userPseudodgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persoListdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // userPseudodgv
            // 
            this.userPseudodgv.AllowUserToAddRows = false;
            this.userPseudodgv.AllowUserToDeleteRows = false;
            this.userPseudodgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userPseudodgv.Location = new System.Drawing.Point(97, 12);
            this.userPseudodgv.Name = "userPseudodgv";
            this.userPseudodgv.Size = new System.Drawing.Size(240, 31);
            this.userPseudodgv.TabIndex = 0;
            // 
            // persoListdgv
            // 
            this.persoListdgv.AllowUserToAddRows = false;
            this.persoListdgv.AllowUserToDeleteRows = false;
            this.persoListdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.persoListdgv.Location = new System.Drawing.Point(12, 231);
            this.persoListdgv.Name = "persoListdgv";
            this.persoListdgv.Size = new System.Drawing.Size(814, 207);
            this.persoListdgv.TabIndex = 1;
            // 
            // modifPseudoUser
            // 
            this.modifPseudoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifPseudoUser.Location = new System.Drawing.Point(343, 13);
            this.modifPseudoUser.Name = "modifPseudoUser";
            this.modifPseudoUser.Size = new System.Drawing.Size(86, 30);
            this.modifPseudoUser.TabIndex = 2;
            this.modifPseudoUser.Text = "Modifier";
            this.modifPseudoUser.UseVisualStyleBackColor = true;
            // 
            // pseudoUserIndication
            // 
            this.pseudoUserIndication.AutoSize = true;
            this.pseudoUserIndication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pseudoUserIndication.Location = new System.Drawing.Point(12, 17);
            this.pseudoUserIndication.Name = "pseudoUserIndication";
            this.pseudoUserIndication.Size = new System.Drawing.Size(79, 20);
            this.pseudoUserIndication.TabIndex = 3;
            this.pseudoUserIndication.Text = "Pseudo :";
            // 
            // persoList
            // 
            this.persoList.AutoSize = true;
            this.persoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persoList.Location = new System.Drawing.Point(12, 198);
            this.persoList.Name = "persoList";
            this.persoList.Size = new System.Drawing.Size(167, 20);
            this.persoList.TabIndex = 4;
            this.persoList.Text = "Liste personnages :";
            // 
            // modifMdpUser
            // 
            this.modifMdpUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifMdpUser.Location = new System.Drawing.Point(111, 58);
            this.modifMdpUser.Name = "modifMdpUser";
            this.modifMdpUser.Size = new System.Drawing.Size(210, 30);
            this.modifMdpUser.TabIndex = 5;
            this.modifMdpUser.Text = "Modifier mot de passe";
            this.modifMdpUser.UseVisualStyleBackColor = true;
            // 
            // delPerso
            // 
            this.delPerso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delPerso.Location = new System.Drawing.Point(201, 193);
            this.delPerso.Name = "delPerso";
            this.delPerso.Size = new System.Drawing.Size(228, 30);
            this.delPerso.TabIndex = 6;
            this.delPerso.Text = "Supprimer un personnage";
            this.delPerso.UseVisualStyleBackColor = true;
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Controls.Add(this.delPerso);
            this.Controls.Add(this.modifMdpUser);
            this.Controls.Add(this.persoList);
            this.Controls.Add(this.pseudoUserIndication);
            this.Controls.Add(this.modifPseudoUser);
            this.Controls.Add(this.persoListdgv);
            this.Controls.Add(this.userPseudodgv);
            this.Name = "Profil";
            this.Text = "Profil";
            ((System.ComponentModel.ISupportInitialize)(this.userPseudodgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persoListdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userPseudodgv;
        private System.Windows.Forms.DataGridView persoListdgv;
        private System.Windows.Forms.Button modifPseudoUser;
        private System.Windows.Forms.Label pseudoUserIndication;
        private System.Windows.Forms.Label persoList;
        private System.Windows.Forms.Button modifMdpUser;
        private System.Windows.Forms.Button delPerso;
    }
}