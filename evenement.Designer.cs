namespace Jeu_de_role
{
    partial class Evenement
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
            this.eventTxtBox = new System.Windows.Forms.TextBox();
            this.lootRbtn = new System.Windows.Forms.RadioButton();
            this.winRbtn = new System.Windows.Forms.RadioButton();
            this.looseRbtn = new System.Windows.Forms.RadioButton();
            this.addMonsterRbtn = new System.Windows.Forms.RadioButton();
            this.validEventBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eventTxtBox
            // 
            this.eventTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventTxtBox.Location = new System.Drawing.Point(12, 26);
            this.eventTxtBox.Multiline = true;
            this.eventTxtBox.Name = "eventTxtBox";
            this.eventTxtBox.Size = new System.Drawing.Size(396, 143);
            this.eventTxtBox.TabIndex = 0;
            this.eventTxtBox.TextChanged += new System.EventHandler(this.eventTxtBox_TextChanged);
            // 
            // lootRbtn
            // 
            this.lootRbtn.AutoSize = true;
            this.lootRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lootRbtn.ForeColor = System.Drawing.Color.Blue;
            this.lootRbtn.Location = new System.Drawing.Point(459, 118);
            this.lootRbtn.Name = "lootRbtn";
            this.lootRbtn.Size = new System.Drawing.Size(50, 17);
            this.lootRbtn.TabIndex = 1;
            this.lootRbtn.TabStop = true;
            this.lootRbtn.Text = "Loot";
            this.lootRbtn.UseVisualStyleBackColor = true;
            this.lootRbtn.CheckedChanged += new System.EventHandler(this.lootRbtn_CheckedChanged);
            // 
            // winRbtn
            // 
            this.winRbtn.AutoSize = true;
            this.winRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winRbtn.ForeColor = System.Drawing.Color.Green;
            this.winRbtn.Location = new System.Drawing.Point(459, 49);
            this.winRbtn.Name = "winRbtn";
            this.winRbtn.Size = new System.Drawing.Size(68, 17);
            this.winRbtn.TabIndex = 2;
            this.winRbtn.TabStop = true;
            this.winRbtn.Text = "Victoire";
            this.winRbtn.UseVisualStyleBackColor = true;
            this.winRbtn.CheckedChanged += new System.EventHandler(this.winRbtn_CheckedChanged);
            // 
            // looseRbtn
            // 
            this.looseRbtn.AutoSize = true;
            this.looseRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.looseRbtn.ForeColor = System.Drawing.Color.Red;
            this.looseRbtn.Location = new System.Drawing.Point(459, 72);
            this.looseRbtn.Name = "looseRbtn";
            this.looseRbtn.Size = new System.Drawing.Size(66, 17);
            this.looseRbtn.TabIndex = 3;
            this.looseRbtn.TabStop = true;
            this.looseRbtn.Text = "Défaite";
            this.looseRbtn.UseVisualStyleBackColor = true;
            this.looseRbtn.CheckedChanged += new System.EventHandler(this.looseRbtn_CheckedChanged);
            // 
            // addMonsterRbtn
            // 
            this.addMonsterRbtn.AutoSize = true;
            this.addMonsterRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMonsterRbtn.ForeColor = System.Drawing.Color.Purple;
            this.addMonsterRbtn.Location = new System.Drawing.Point(459, 95);
            this.addMonsterRbtn.Name = "addMonsterRbtn";
            this.addMonsterRbtn.Size = new System.Drawing.Size(114, 17);
            this.addMonsterRbtn.TabIndex = 4;
            this.addMonsterRbtn.TabStop = true;
            this.addMonsterRbtn.Text = "Ajouter Monstre";
            this.addMonsterRbtn.UseVisualStyleBackColor = true;
            this.addMonsterRbtn.CheckedChanged += new System.EventHandler(this.addMonsterRbtn_CheckedChanged);
            // 
            // validEventBtn
            // 
            this.validEventBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.validEventBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validEventBtn.Location = new System.Drawing.Point(223, 188);
            this.validEventBtn.Name = "validEventBtn";
            this.validEventBtn.Size = new System.Drawing.Size(185, 59);
            this.validEventBtn.TabIndex = 5;
            this.validEventBtn.Text = "Valider";
            this.validEventBtn.UseVisualStyleBackColor = true;
            this.validEventBtn.Click += new System.EventHandler(this.validEventBtn_Click);
            // 
            // evenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 259);
            this.Controls.Add(this.validEventBtn);
            this.Controls.Add(this.addMonsterRbtn);
            this.Controls.Add(this.looseRbtn);
            this.Controls.Add(this.winRbtn);
            this.Controls.Add(this.lootRbtn);
            this.Controls.Add(this.eventTxtBox);
            this.Name = "evenement";
            this.Text = "eventcs";
            this.Load += new System.EventHandler(this.evenement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eventTxtBox;
        private System.Windows.Forms.RadioButton lootRbtn;
        private System.Windows.Forms.RadioButton winRbtn;
        private System.Windows.Forms.RadioButton looseRbtn;
        private System.Windows.Forms.RadioButton addMonsterRbtn;
        private System.Windows.Forms.Button validEventBtn;
    }
}