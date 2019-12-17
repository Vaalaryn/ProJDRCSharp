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
            this.txtIdGame = new System.Windows.Forms.TextBox();
            this.CreateGameBtn = new System.Windows.Forms.Button();
            this.userInfoBtn = new System.Windows.Forms.Button();
            this.gameListView = new System.Windows.Forms.ListView();
            this.searchGameBtn = new System.Windows.Forms.Button();
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
            this.CreateGameBtn.Location = new System.Drawing.Point(32, 53);
            this.CreateGameBtn.Name = "CreateGameBtn";
            this.CreateGameBtn.Size = new System.Drawing.Size(160, 50);
            this.CreateGameBtn.TabIndex = 1;
            this.CreateGameBtn.Text = "Créer une partie";
            this.CreateGameBtn.UseVisualStyleBackColor = true;
            // 
            // userInfoBtn
            // 
            this.userInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInfoBtn.Location = new System.Drawing.Point(12, 388);
            this.userInfoBtn.Name = "userInfoBtn";
            this.userInfoBtn.Size = new System.Drawing.Size(205, 50);
            this.userInfoBtn.TabIndex = 2;
            this.userInfoBtn.Text = "Information Joueur";
            this.userInfoBtn.UseVisualStyleBackColor = true;
            this.userInfoBtn.Click += new System.EventHandler(this.userInfoBtn_Click);
            // 
            // gameListView
            // 
            this.gameListView.HideSelection = false;
            this.gameListView.Location = new System.Drawing.Point(12, 109);
            this.gameListView.Name = "gameListView";
            this.gameListView.Size = new System.Drawing.Size(205, 273);
            this.gameListView.TabIndex = 3;
            this.gameListView.UseCompatibleStateImageBehavior = false;
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
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 450);
            this.Controls.Add(this.searchGameBtn);
            this.Controls.Add(this.gameListView);
            this.Controls.Add(this.userInfoBtn);
            this.Controls.Add(this.CreateGameBtn);
            this.Controls.Add(this.txtIdGame);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdGame;
        private System.Windows.Forms.Button CreateGameBtn;
        private System.Windows.Forms.Button userInfoBtn;
        private System.Windows.Forms.ListView gameListView;
        private System.Windows.Forms.Button searchGameBtn;
    }
}