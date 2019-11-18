using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_de_role
{
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private bool Exist(string mail, string pseudo)
        {
            return false;
        }

        private bool AjoutBDD(string mail, string pseudo, string mdp, string confirmation, Image img)
        {
            return false;
        }

        private void confirmerButton_Click(object sender, EventArgs e)
        {
            var mail = this.mailTxt.Text;
            var pseudo = this.pseudoTxt.Text;
            var mdp = this.mdpTxt.Text;
            var confirm = this.confirmMdpTxt.Text;
            var img = this.pictureBox.Image;

            if (!Exist(mail, pseudo))
            {
                AjoutBDD(mail, pseudo, mdp, confirm, img);
            }

        }

        private void rechercheImgButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            // chose the images type
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                // get the image returned by OpenFileDialog 
                pictureBox.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
