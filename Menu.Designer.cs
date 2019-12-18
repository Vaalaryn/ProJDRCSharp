namespace Jeu_de_role
{
    partial class Menu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtIdGame = new System.Windows.Forms.TextBox();
            this.CreateGameBtn = new System.Windows.Forms.Button();
            this.userInfoBtn = new System.Windows.Forms.Button();
            this.searchGameBtn = new System.Windows.Forms.Button();
            this.Watcher = new System.IO.FileSystemWatcher();
            this.dgvParties = new System.Windows.Forms.DataGridView();
            this.dgvTitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPartie = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Watcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdGame
            // 
            this.txtIdGame.Location = new System.Drawing.Point(12, 12);
            this.txtIdGame.Multiline = true;
            this.txtIdGame.Name = "txtIdGame";
            this.txtIdGame.Size = new System.Drawing.Size(205, 35);
            this.txtIdGame.TabIndex = 0;
            // 
            // CreateGameBtn
            // 
            this.CreateGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateGameBtn.Location = new System.Drawing.Point(12, 53);
            this.CreateGameBtn.Name = "CreateGameBtn";
            this.CreateGameBtn.Size = new System.Drawing.Size(262, 50);
            this.CreateGameBtn.TabIndex = 1;
            this.CreateGameBtn.Text = "Créer une partie";
            this.CreateGameBtn.UseVisualStyleBackColor = true;
            this.CreateGameBtn.Click += new System.EventHandler(this.CreateGameBtn_Click);
            // 
            // userInfoBtn
            // 
            this.userInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInfoBtn.Location = new System.Drawing.Point(12, 388);
            this.userInfoBtn.Name = "userInfoBtn";
            this.userInfoBtn.Size = new System.Drawing.Size(262, 50);
            this.userInfoBtn.TabIndex = 2;
            this.userInfoBtn.Text = "Information Joueur";
            this.userInfoBtn.UseVisualStyleBackColor = true;
            this.userInfoBtn.Click += new System.EventHandler(this.userInfoBtn_Click);
            // 
            // searchGameBtn
            // 
            this.searchGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchGameBtn.Location = new System.Drawing.Point(223, 12);
            this.searchGameBtn.Name = "searchGameBtn";
            this.searchGameBtn.Size = new System.Drawing.Size(51, 35);
            this.searchGameBtn.TabIndex = 4;
            this.searchGameBtn.Text = "R";
            this.searchGameBtn.UseVisualStyleBackColor = true;
            this.searchGameBtn.Click += new System.EventHandler(this.searchGameBtn_Click);
            // 
            // Watcher
            // 
            this.Watcher.EnableRaisingEvents = true;
            this.Watcher.SynchronizingObject = this;
            this.Watcher.Changed += new System.IO.FileSystemEventHandler(this.Watcher_Changed);
            // 
            // dgvParties
            // 
            this.dgvParties.AllowUserToResizeColumns = false;
            this.dgvParties.AllowUserToResizeRows = false;
            this.dgvParties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParties.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvParties.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvParties.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParties.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvParties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvParties.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTitre,
            this.dgvDescription,
            this.ID});
            this.dgvParties.Location = new System.Drawing.Point(12, 139);
            this.dgvParties.MultiSelect = false;
            this.dgvParties.Name = "dgvParties";
            this.dgvParties.ReadOnly = true;
            this.dgvParties.RowHeadersVisible = false;
            this.dgvParties.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvParties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParties.Size = new System.Drawing.Size(262, 243);
            this.dgvParties.TabIndex = 5;
            this.dgvParties.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParties_CellClick);
            // 
            // dgvTitre
            // 
            this.dgvTitre.HeaderText = "Titre";
            this.dgvTitre.Name = "dgvTitre";
            this.dgvTitre.ReadOnly = true;
            // 
            // dgvDescription
            // 
            this.dgvDescription.HeaderText = "Description";
            this.dgvDescription.Name = "dgvDescription";
            this.dgvDescription.ReadOnly = true;
            // 
            // lblPartie
            // 
            this.lblPartie.AutoSize = true;
            this.lblPartie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartie.Location = new System.Drawing.Point(12, 111);
            this.lblPartie.Name = "lblPartie";
            this.lblPartie.Size = new System.Drawing.Size(120, 25);
            this.lblPartie.TabIndex = 6;
            this.lblPartie.Text = "Vos parties";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 450);
            this.Controls.Add(this.lblPartie);
            this.Controls.Add(this.dgvParties);
            this.Controls.Add(this.searchGameBtn);
            this.Controls.Add(this.userInfoBtn);
            this.Controls.Add(this.CreateGameBtn);
            this.Controls.Add(this.txtIdGame);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Shown += new System.EventHandler(this.Menu_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Watcher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdGame;
        private System.Windows.Forms.Button CreateGameBtn;
        private System.Windows.Forms.Button userInfoBtn;
        private System.Windows.Forms.Button searchGameBtn;
        private System.IO.FileSystemWatcher Watcher;
        private System.Windows.Forms.DataGridView dgvParties;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescription;
        private System.Windows.Forms.Label lblPartie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}