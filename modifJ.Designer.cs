namespace Jeu_de_role
{
    partial class modifJ
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
            this.listJDtg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listJDtg)).BeginInit();
            this.SuspendLayout();
            // 
            // listJDtg
            // 
            this.listJDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listJDtg.Location = new System.Drawing.Point(21, 12);
            this.listJDtg.Name = "listJDtg";
            this.listJDtg.Size = new System.Drawing.Size(320, 351);
            this.listJDtg.TabIndex = 0;
            // 
            // modifJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 375);
            this.Controls.Add(this.listJDtg);
            this.Name = "modifJ";
            this.Text = "modifJ";
            ((System.ComponentModel.ISupportInitialize)(this.listJDtg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listJDtg;
    }
}