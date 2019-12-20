namespace Jeu_de_role
{
    partial class PartiePerso
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
            this.WatcherParties = new System.IO.FileSystemWatcher();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBlocnote = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtVie = new System.Windows.Forms.TextBox();
            this.txtMana = new System.Windows.Forms.TextBox();
            this.txtPuissance = new System.Windows.Forms.TextBox();
            this.txtMagie = new System.Windows.Forms.TextBox();
            this.txtDexterite = new System.Windows.Forms.TextBox();
            this.txtObservation = new System.Windows.Forms.TextBox();
            this.txtIntelligence = new System.Windows.Forms.TextBox();
            this.txtChance = new System.Windows.Forms.TextBox();
            this.txtCharisme = new System.Windows.Forms.TextBox();
            this.txtClasse = new System.Windows.Forms.TextBox();
            this.txtLogs = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.WatcherLogs = new System.IO.FileSystemWatcher();
            this.txtNiveau = new System.Windows.Forms.TextBox();
            this.lblNiveau = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WatcherParties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WatcherLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // WatcherParties
            // 
            this.WatcherParties.EnableRaisingEvents = true;
            this.WatcherParties.Path = "\\\\10.176.131.132\\Users\\Elise\\Documents\\Watcher\\Parties";
            this.WatcherParties.SynchronizingObject = this;
            this.WatcherParties.Changed += new System.IO.FileSystemEventHandler(this.WatcherPartie_Changed);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(143, 356);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(254, 80);
            this.txtDescription.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(311, 340);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "DESCRIPTION :";
            // 
            // txtBlocnote
            // 
            this.txtBlocnote.Location = new System.Drawing.Point(742, 302);
            this.txtBlocnote.Multiline = true;
            this.txtBlocnote.Name = "txtBlocnote";
            this.txtBlocnote.Size = new System.Drawing.Size(348, 103);
            this.txtBlocnote.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(742, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(348, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mana";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Puissance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Magie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dextérité";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Observation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Intelligence";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(140, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Chance";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Charisme";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(140, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Classe";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(13, 30);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 17;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(143, 29);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.ReadOnly = true;
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 18;
            // 
            // txtVie
            // 
            this.txtVie.Location = new System.Drawing.Point(15, 83);
            this.txtVie.Name = "txtVie";
            this.txtVie.ReadOnly = true;
            this.txtVie.Size = new System.Drawing.Size(100, 20);
            this.txtVie.TabIndex = 19;
            // 
            // txtMana
            // 
            this.txtMana.Location = new System.Drawing.Point(143, 83);
            this.txtMana.Name = "txtMana";
            this.txtMana.ReadOnly = true;
            this.txtMana.Size = new System.Drawing.Size(100, 20);
            this.txtMana.TabIndex = 20;
            // 
            // txtPuissance
            // 
            this.txtPuissance.Location = new System.Drawing.Point(15, 145);
            this.txtPuissance.Name = "txtPuissance";
            this.txtPuissance.ReadOnly = true;
            this.txtPuissance.Size = new System.Drawing.Size(100, 20);
            this.txtPuissance.TabIndex = 21;
            // 
            // txtMagie
            // 
            this.txtMagie.Location = new System.Drawing.Point(143, 145);
            this.txtMagie.Name = "txtMagie";
            this.txtMagie.ReadOnly = true;
            this.txtMagie.Size = new System.Drawing.Size(100, 20);
            this.txtMagie.TabIndex = 22;
            // 
            // txtDexterite
            // 
            this.txtDexterite.Location = new System.Drawing.Point(15, 194);
            this.txtDexterite.Name = "txtDexterite";
            this.txtDexterite.ReadOnly = true;
            this.txtDexterite.Size = new System.Drawing.Size(100, 20);
            this.txtDexterite.TabIndex = 23;
            // 
            // txtObservation
            // 
            this.txtObservation.Location = new System.Drawing.Point(143, 194);
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.ReadOnly = true;
            this.txtObservation.Size = new System.Drawing.Size(100, 20);
            this.txtObservation.TabIndex = 24;
            // 
            // txtIntelligence
            // 
            this.txtIntelligence.Location = new System.Drawing.Point(15, 252);
            this.txtIntelligence.Name = "txtIntelligence";
            this.txtIntelligence.ReadOnly = true;
            this.txtIntelligence.Size = new System.Drawing.Size(100, 20);
            this.txtIntelligence.TabIndex = 25;
            // 
            // txtChance
            // 
            this.txtChance.Location = new System.Drawing.Point(143, 252);
            this.txtChance.Name = "txtChance";
            this.txtChance.ReadOnly = true;
            this.txtChance.Size = new System.Drawing.Size(100, 20);
            this.txtChance.TabIndex = 26;
            // 
            // txtCharisme
            // 
            this.txtCharisme.Location = new System.Drawing.Point(13, 302);
            this.txtCharisme.Name = "txtCharisme";
            this.txtCharisme.ReadOnly = true;
            this.txtCharisme.Size = new System.Drawing.Size(100, 20);
            this.txtCharisme.TabIndex = 27;
            // 
            // txtClasse
            // 
            this.txtClasse.Location = new System.Drawing.Point(143, 302);
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.ReadOnly = true;
            this.txtClasse.Size = new System.Drawing.Size(100, 20);
            this.txtClasse.TabIndex = 28;
            // 
            // txtLogs
            // 
            this.txtLogs.Location = new System.Drawing.Point(335, 29);
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.Size = new System.Drawing.Size(755, 257);
            this.txtLogs.TabIndex = 30;
            this.txtLogs.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(332, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Logs";
            // 
            // WatcherLogs
            // 
            this.WatcherLogs.EnableRaisingEvents = true;
            this.WatcherLogs.Path = "\\\\10.176.131.132\\Users\\Elise\\Documents\\Watcher\\Logs";
            this.WatcherLogs.SynchronizingObject = this;
            this.WatcherLogs.Changed += new System.IO.FileSystemEventHandler(this.WatcherLogs_Changed);
            // 
            // txtNiveau
            // 
            this.txtNiveau.Location = new System.Drawing.Point(12, 356);
            this.txtNiveau.Name = "txtNiveau";
            this.txtNiveau.ReadOnly = true;
            this.txtNiveau.Size = new System.Drawing.Size(100, 20);
            this.txtNiveau.TabIndex = 32;
            // 
            // lblNiveau
            // 
            this.lblNiveau.AutoSize = true;
            this.lblNiveau.Location = new System.Drawing.Point(9, 340);
            this.lblNiveau.Name = "lblNiveau";
            this.lblNiveau.Size = new System.Drawing.Size(41, 13);
            this.lblNiveau.TabIndex = 33;
            this.lblNiveau.Text = "Niveau";
            // 
            // PartiePerso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 450);
            this.Controls.Add(this.lblNiveau);
            this.Controls.Add(this.txtNiveau);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtLogs);
            this.Controls.Add(this.txtClasse);
            this.Controls.Add(this.txtCharisme);
            this.Controls.Add(this.txtChance);
            this.Controls.Add(this.txtIntelligence);
            this.Controls.Add(this.txtObservation);
            this.Controls.Add(this.txtDexterite);
            this.Controls.Add(this.txtMagie);
            this.Controls.Add(this.txtPuissance);
            this.Controls.Add(this.txtMana);
            this.Controls.Add(this.txtVie);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBlocnote);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PartiePerso";
            this.Text = "PartiePerso";
            ((System.ComponentModel.ISupportInitialize)(this.WatcherParties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WatcherLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher WatcherParties;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBlocnote;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox txtLogs;
        private System.Windows.Forms.TextBox txtClasse;
        private System.Windows.Forms.TextBox txtCharisme;
        private System.Windows.Forms.TextBox txtChance;
        private System.Windows.Forms.TextBox txtIntelligence;
        private System.Windows.Forms.TextBox txtObservation;
        private System.Windows.Forms.TextBox txtDexterite;
        private System.Windows.Forms.TextBox txtMagie;
        private System.Windows.Forms.TextBox txtPuissance;
        private System.Windows.Forms.TextBox txtMana;
        private System.Windows.Forms.TextBox txtVie;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.IO.FileSystemWatcher WatcherLogs;
        private System.Windows.Forms.Label lblNiveau;
        private System.Windows.Forms.TextBox txtNiveau;
    }
}