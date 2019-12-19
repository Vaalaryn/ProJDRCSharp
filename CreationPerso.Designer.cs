namespace Jeu_de_role
{
    partial class CreationPerso
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
            this.button1 = new System.Windows.Forms.Button();
            this.select_classe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prenom_perso = new System.Windows.Forms.TextBox();
            this.desc_perso = new System.Windows.Forms.RichTextBox();
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
            this.description_classe = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.nom_perso = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.vie_value = new System.Windows.Forms.Label();
            this.mana_value = new System.Windows.Forms.Label();
            this.puissance_value = new System.Windows.Forms.Label();
            this.observation_value = new System.Windows.Forms.Label();
            this.intelligence_value = new System.Windows.Forms.Label();
            this.chance_value = new System.Windows.Forms.Label();
            this.dexterite_value = new System.Windows.Forms.Label();
            this.charisme_value = new System.Windows.Forms.Label();
            this.magie_value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(337, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // select_classe
            // 
            this.select_classe.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.select_classe.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.select_classe.FormattingEnabled = true;
            this.select_classe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.select_classe.Location = new System.Drawing.Point(12, 87);
            this.select_classe.MaxDropDownItems = 20;
            this.select_classe.Name = "select_classe";
            this.select_classe.Size = new System.Drawing.Size(337, 24);
            this.select_classe.TabIndex = 1;
            this.select_classe.SelectedIndexChanged += new System.EventHandler(this.select_classe_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Classe :";
            // 
            // prenom_perso
            // 
            this.prenom_perso.Location = new System.Drawing.Point(185, 29);
            this.prenom_perso.Name = "prenom_perso";
            this.prenom_perso.Size = new System.Drawing.Size(164, 22);
            this.prenom_perso.TabIndex = 5;
            // 
            // desc_perso
            // 
            this.desc_perso.Location = new System.Drawing.Point(12, 407);
            this.desc_perso.Name = "desc_perso";
            this.desc_perso.Size = new System.Drawing.Size(337, 96);
            this.desc_perso.TabIndex = 6;
            this.desc_perso.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prenom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vie max :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Puissance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Observation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Magie";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(153, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Mana max : ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(156, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Intelligence";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Charisme";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(287, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Dextérité";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(295, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Chance";
            // 
            // description_classe
            // 
            this.description_classe.Location = new System.Drawing.Point(12, 299);
            this.description_classe.Name = "description_classe";
            this.description_classe.ReadOnly = true;
            this.description_classe.Size = new System.Drawing.Size(337, 73);
            this.description_classe.TabIndex = 19;
            this.description_classe.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 279);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "Description de la classe :";
            // 
            // nom_perso
            // 
            this.nom_perso.Location = new System.Drawing.Point(12, 29);
            this.nom_perso.Name = "nom_perso";
            this.nom_perso.Size = new System.Drawing.Size(164, 22);
            this.nom_perso.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 387);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(223, 17);
            this.label14.TabIndex = 22;
            this.label14.Text = "Description de votre personnage :";
            // 
            // vie_value
            // 
            this.vie_value.AutoSize = true;
            this.vie_value.Location = new System.Drawing.Point(33, 152);
            this.vie_value.Name = "vie_value";
            this.vie_value.Size = new System.Drawing.Size(16, 17);
            this.vie_value.TabIndex = 23;
            this.vie_value.Text = "?";
            // 
            // mana_value
            // 
            this.mana_value.AutoSize = true;
            this.mana_value.Location = new System.Drawing.Point(183, 152);
            this.mana_value.Name = "mana_value";
            this.mana_value.Size = new System.Drawing.Size(16, 17);
            this.mana_value.TabIndex = 24;
            this.mana_value.Text = "?";
            this.mana_value.Click += new System.EventHandler(this.mana_value_Click);
            // 
            // puissance_value
            // 
            this.puissance_value.AutoSize = true;
            this.puissance_value.Location = new System.Drawing.Point(33, 206);
            this.puissance_value.Name = "puissance_value";
            this.puissance_value.Size = new System.Drawing.Size(16, 17);
            this.puissance_value.TabIndex = 25;
            this.puissance_value.Text = "?";
            // 
            // observation_value
            // 
            this.observation_value.AutoSize = true;
            this.observation_value.Location = new System.Drawing.Point(33, 260);
            this.observation_value.Name = "observation_value";
            this.observation_value.Size = new System.Drawing.Size(16, 17);
            this.observation_value.TabIndex = 26;
            this.observation_value.Text = "?";
            // 
            // intelligence_value
            // 
            this.intelligence_value.AutoSize = true;
            this.intelligence_value.Location = new System.Drawing.Point(183, 262);
            this.intelligence_value.Name = "intelligence_value";
            this.intelligence_value.Size = new System.Drawing.Size(16, 17);
            this.intelligence_value.TabIndex = 27;
            this.intelligence_value.Text = "?";
            this.intelligence_value.Click += new System.EventHandler(this.intelligence_value_Click);
            // 
            // chance_value
            // 
            this.chance_value.AutoSize = true;
            this.chance_value.Location = new System.Drawing.Point(315, 260);
            this.chance_value.Name = "chance_value";
            this.chance_value.Size = new System.Drawing.Size(16, 17);
            this.chance_value.TabIndex = 28;
            this.chance_value.Text = "?";
            // 
            // dexterite_value
            // 
            this.dexterite_value.AutoSize = true;
            this.dexterite_value.Location = new System.Drawing.Point(315, 206);
            this.dexterite_value.Name = "dexterite_value";
            this.dexterite_value.Size = new System.Drawing.Size(16, 17);
            this.dexterite_value.TabIndex = 29;
            this.dexterite_value.Text = "?";
            // 
            // charisme_value
            // 
            this.charisme_value.AutoSize = true;
            this.charisme_value.Location = new System.Drawing.Point(315, 152);
            this.charisme_value.Name = "charisme_value";
            this.charisme_value.Size = new System.Drawing.Size(16, 17);
            this.charisme_value.TabIndex = 30;
            this.charisme_value.Text = "?";
            // 
            // magie_value
            // 
            this.magie_value.AutoSize = true;
            this.magie_value.Location = new System.Drawing.Point(183, 206);
            this.magie_value.Name = "magie_value";
            this.magie_value.Size = new System.Drawing.Size(16, 17);
            this.magie_value.TabIndex = 31;
            this.magie_value.Text = "?";
            this.magie_value.Click += new System.EventHandler(this.magie_value_Click);
            // 
            // CreationPerso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 556);
            this.Controls.Add(this.magie_value);
            this.Controls.Add(this.charisme_value);
            this.Controls.Add(this.dexterite_value);
            this.Controls.Add(this.chance_value);
            this.Controls.Add(this.intelligence_value);
            this.Controls.Add(this.observation_value);
            this.Controls.Add(this.puissance_value);
            this.Controls.Add(this.mana_value);
            this.Controls.Add(this.vie_value);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.nom_perso);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.description_classe);
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
            this.Controls.Add(this.desc_perso);
            this.Controls.Add(this.prenom_perso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.select_classe);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CreationPerso";
            this.Text = "Création de personnage";
            this.Load += new System.EventHandler(this.CreationPerso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox select_classe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prenom_perso;
        private System.Windows.Forms.RichTextBox desc_perso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox description_classe;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox nom_perso;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label vie_value;
        private System.Windows.Forms.Label mana_value;
        private System.Windows.Forms.Label puissance_value;
        private System.Windows.Forms.Label observation_value;
        private System.Windows.Forms.Label intelligence_value;
        private System.Windows.Forms.Label chance_value;
        private System.Windows.Forms.Label dexterite_value;
        private System.Windows.Forms.Label charisme_value;
        private System.Windows.Forms.Label magie_value;
    }
}