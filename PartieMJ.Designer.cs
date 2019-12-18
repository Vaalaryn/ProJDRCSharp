namespace Jeu_de_role
{
    partial class PartieMJ
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
            this.jListDtg = new System.Windows.Forms.DataGridView();
            this.flpActionButton = new System.Windows.Forms.FlowLayoutPanel();
            this.déBtn = new System.Windows.Forms.Button();
            this.eventBtn = new System.Windows.Forms.Button();
            this.modifJBtn = new System.Windows.Forms.Button();
            this.modifInventBtn = new System.Windows.Forms.Button();
            this.sendPicBtn = new System.Windows.Forms.Button();
            this.changeMJBtn = new System.Windows.Forms.Button();
            this.infoPBtn = new System.Windows.Forms.Button();
            this.blocNotetxtbx = new System.Windows.Forms.TextBox();
            this.listeJLbl = new System.Windows.Forms.Label();
            this.logLbl = new System.Windows.Forms.Label();
            this.blocNoteLbl = new System.Windows.Forms.Label();
            this.logTxtbx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.jListDtg)).BeginInit();
            this.flpActionButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // jListDtg
            // 
            this.jListDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jListDtg.Location = new System.Drawing.Point(12, 36);
            this.jListDtg.Name = "jListDtg";
            this.jListDtg.Size = new System.Drawing.Size(374, 146);
            this.jListDtg.TabIndex = 0;
            this.jListDtg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jListDtg_CellContentClick);
            // 
            // flpActionButton
            // 
            this.flpActionButton.Controls.Add(this.déBtn);
            this.flpActionButton.Controls.Add(this.eventBtn);
            this.flpActionButton.Controls.Add(this.modifJBtn);
            this.flpActionButton.Controls.Add(this.modifInventBtn);
            this.flpActionButton.Controls.Add(this.sendPicBtn);
            this.flpActionButton.Controls.Add(this.changeMJBtn);
            this.flpActionButton.Controls.Add(this.infoPBtn);
            this.flpActionButton.Location = new System.Drawing.Point(837, 86);
            this.flpActionButton.Name = "flpActionButton";
            this.flpActionButton.Size = new System.Drawing.Size(165, 346);
            this.flpActionButton.TabIndex = 1;
            // 
            // déBtn
            // 
            this.déBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.déBtn.Location = new System.Drawing.Point(3, 3);
            this.déBtn.Name = "déBtn";
            this.déBtn.Size = new System.Drawing.Size(157, 43);
            this.déBtn.TabIndex = 0;
            this.déBtn.Text = "Lancer un dé";
            this.déBtn.UseVisualStyleBackColor = true;
            this.déBtn.Click += new System.EventHandler(this.déBtn_Click);
            // 
            // eventBtn
            // 
            this.eventBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventBtn.Location = new System.Drawing.Point(3, 52);
            this.eventBtn.Name = "eventBtn";
            this.eventBtn.Size = new System.Drawing.Size(157, 43);
            this.eventBtn.TabIndex = 1;
            this.eventBtn.Text = "Événement";
            this.eventBtn.UseVisualStyleBackColor = true;
            this.eventBtn.Click += new System.EventHandler(this.eventBtn_Click);
            // 
            // modifJBtn
            // 
            this.modifJBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifJBtn.Location = new System.Drawing.Point(3, 101);
            this.modifJBtn.Name = "modifJBtn";
            this.modifJBtn.Size = new System.Drawing.Size(157, 43);
            this.modifJBtn.TabIndex = 2;
            this.modifJBtn.Text = "Modif joueur";
            this.modifJBtn.UseVisualStyleBackColor = true;
            this.modifJBtn.Click += new System.EventHandler(this.modifJBtn_Click);
            // 
            // modifInventBtn
            // 
            this.modifInventBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifInventBtn.Location = new System.Drawing.Point(3, 150);
            this.modifInventBtn.Name = "modifInventBtn";
            this.modifInventBtn.Size = new System.Drawing.Size(157, 43);
            this.modifInventBtn.TabIndex = 3;
            this.modifInventBtn.Text = "Modif inventaire";
            this.modifInventBtn.UseVisualStyleBackColor = true;
            // 
            // sendPicBtn
            // 
            this.sendPicBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendPicBtn.Location = new System.Drawing.Point(3, 199);
            this.sendPicBtn.Name = "sendPicBtn";
            this.sendPicBtn.Size = new System.Drawing.Size(157, 43);
            this.sendPicBtn.TabIndex = 4;
            this.sendPicBtn.Text = "Envoyer image";
            this.sendPicBtn.UseVisualStyleBackColor = true;
            // 
            // changeMJBtn
            // 
            this.changeMJBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeMJBtn.Location = new System.Drawing.Point(3, 248);
            this.changeMJBtn.Name = "changeMJBtn";
            this.changeMJBtn.Size = new System.Drawing.Size(157, 43);
            this.changeMJBtn.TabIndex = 5;
            this.changeMJBtn.Text = "Changer MJ";
            this.changeMJBtn.UseVisualStyleBackColor = true;
            // 
            // infoPBtn
            // 
            this.infoPBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoPBtn.Location = new System.Drawing.Point(3, 297);
            this.infoPBtn.Name = "infoPBtn";
            this.infoPBtn.Size = new System.Drawing.Size(157, 43);
            this.infoPBtn.TabIndex = 6;
            this.infoPBtn.Text = "Info partie";
            this.infoPBtn.UseVisualStyleBackColor = true;
            // 
            // blocNotetxtbx
            // 
            this.blocNotetxtbx.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.blocNotetxtbx.Location = new System.Drawing.Point(392, 38);
            this.blocNotetxtbx.Multiline = true;
            this.blocNotetxtbx.Name = "blocNotetxtbx";
            this.blocNotetxtbx.Size = new System.Drawing.Size(439, 458);
            this.blocNotetxtbx.TabIndex = 3;
            // 
            // listeJLbl
            // 
            this.listeJLbl.AutoSize = true;
            this.listeJLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeJLbl.Location = new System.Drawing.Point(12, 9);
            this.listeJLbl.Name = "listeJLbl";
            this.listeJLbl.Size = new System.Drawing.Size(156, 20);
            this.listeJLbl.TabIndex = 4;
            this.listeJLbl.Text = "Liste des joueurs :";
            this.listeJLbl.Click += new System.EventHandler(this.listeJLbl_Click);
            // 
            // logLbl
            // 
            this.logLbl.AutoSize = true;
            this.logLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logLbl.Location = new System.Drawing.Point(12, 185);
            this.logLbl.Name = "logLbl";
            this.logLbl.Size = new System.Drawing.Size(58, 20);
            this.logLbl.TabIndex = 5;
            this.logLbl.Text = "Logs :";
            // 
            // blocNoteLbl
            // 
            this.blocNoteLbl.AutoSize = true;
            this.blocNoteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blocNoteLbl.Location = new System.Drawing.Point(392, 15);
            this.blocNoteLbl.Name = "blocNoteLbl";
            this.blocNoteLbl.Size = new System.Drawing.Size(95, 20);
            this.blocNoteLbl.TabIndex = 6;
            this.blocNoteLbl.Text = "Bloc note :";
            // 
            // logTxtbx
            // 
            this.logTxtbx.Location = new System.Drawing.Point(12, 208);
            this.logTxtbx.Multiline = true;
            this.logTxtbx.Name = "logTxtbx";
            this.logTxtbx.Size = new System.Drawing.Size(370, 286);
            this.logTxtbx.TabIndex = 7;
            this.logTxtbx.TextChanged += new System.EventHandler(this.logTxtbx_TextChanged);
            // 
            // PartieMJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 508);
            this.Controls.Add(this.logTxtbx);
            this.Controls.Add(this.blocNoteLbl);
            this.Controls.Add(this.logLbl);
            this.Controls.Add(this.listeJLbl);
            this.Controls.Add(this.blocNotetxtbx);
            this.Controls.Add(this.flpActionButton);
            this.Controls.Add(this.jListDtg);
            this.Name = "PartieMJ";
            this.Text = "PartieMJ";
            this.Load += new System.EventHandler(this.PartieMJ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jListDtg)).EndInit();
            this.flpActionButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView jListDtg;
        private System.Windows.Forms.FlowLayoutPanel flpActionButton;
        private System.Windows.Forms.Button déBtn;
        private System.Windows.Forms.TextBox blocNotetxtbx;
        private System.Windows.Forms.Button eventBtn;
        private System.Windows.Forms.Button modifJBtn;
        private System.Windows.Forms.Button modifInventBtn;
        private System.Windows.Forms.Button sendPicBtn;
        private System.Windows.Forms.Button changeMJBtn;
        private System.Windows.Forms.Button infoPBtn;
        private System.Windows.Forms.Label listeJLbl;
        private System.Windows.Forms.Label logLbl;
        private System.Windows.Forms.Label blocNoteLbl;
        private System.Windows.Forms.TextBox logTxtbx;
    }
}