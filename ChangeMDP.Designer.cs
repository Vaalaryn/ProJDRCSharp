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
            this.dgvNewMDP = new System.Windows.Forms.DataGridView();
            this.dgvConfNewMDP = new System.Windows.Forms.DataGridView();
            this.NewMDP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveMDPbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewMDP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfNewMDP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNewMDP
            // 
            this.dgvNewMDP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewMDP.Location = new System.Drawing.Point(65, 28);
            this.dgvNewMDP.Name = "dgvNewMDP";
            this.dgvNewMDP.Size = new System.Drawing.Size(318, 34);
            this.dgvNewMDP.TabIndex = 0;
            // 
            // dgvConfNewMDP
            // 
            this.dgvConfNewMDP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfNewMDP.Location = new System.Drawing.Point(65, 103);
            this.dgvConfNewMDP.Name = "dgvConfNewMDP";
            this.dgvConfNewMDP.Size = new System.Drawing.Size(318, 34);
            this.dgvConfNewMDP.TabIndex = 1;
            // 
            // NewMDP
            // 
            this.NewMDP.AutoSize = true;
            this.NewMDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewMDP.Location = new System.Drawing.Point(133, 9);
            this.NewMDP.Name = "NewMDP";
            this.NewMDP.Size = new System.Drawing.Size(176, 16);
            this.NewMDP.TabIndex = 2;
            this.NewMDP.Text = "Nouveau mot de passe :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Confirmer nouveau mot de passe :";
            // 
            // SaveMDPbtn
            // 
            this.SaveMDPbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveMDPbtn.Location = new System.Drawing.Point(136, 172);
            this.SaveMDPbtn.Name = "SaveMDPbtn";
            this.SaveMDPbtn.Size = new System.Drawing.Size(162, 49);
            this.SaveMDPbtn.TabIndex = 4;
            this.SaveMDPbtn.Text = "Sauvegarder";
            this.SaveMDPbtn.UseVisualStyleBackColor = true;
            // 
            // ChangeMDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 256);
            this.Controls.Add(this.SaveMDPbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewMDP);
            this.Controls.Add(this.dgvConfNewMDP);
            this.Controls.Add(this.dgvNewMDP);
            this.Name = "ChangeMDP";
            this.Text = "ChangeMDP";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewMDP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfNewMDP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNewMDP;
        private System.Windows.Forms.DataGridView dgvConfNewMDP;
        private System.Windows.Forms.Label NewMDP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveMDPbtn;
    }
}