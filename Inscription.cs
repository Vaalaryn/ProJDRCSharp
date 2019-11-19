using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_de_role
{
    public partial class Inscription : Form
    {
        public byte[] bytes;

        public Inscription()
        {
            InitializeComponent();
        }

        private bool Exist(string mail, string pseudo)
        {
            return false;
        }

        private bool AjoutBDD(string mail, string pseudo, string mdp, Byte[] img)
        {
            return false;
        }

        private void confirmerButton_Click(object sender, EventArgs e)
        {
            FileStream fs;
            BinaryReader br;
            if (mailTxt.Text.Length > 0 && pseudoTxt.Text.Length > 0 && mdpTxt.Text == confirmMdpTxt.Text)
            {
                var mail = this.mailTxt.Text;
                var pseudo = this.pseudoTxt.Text;
                var mdp = this.mdpTxt.Text;

                string FileName = linkTxt.Text;
                byte[] ImageData;
                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                ImageData = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();

                if (!Exist(mail, pseudo))
                {
                    AjoutBDD(mail, pseudo, mdp, ImageData);
                }

                MemoryStream ms = new MemoryStream(ImageData);
                ms.Position = 0;
                Image returnImage = Image.FromStream(ms);
                testPictureBox.Image = returnImage;
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
                linkTxt.Text = opf.FileName;
                pictureBox.Image = Image.FromFile(opf.FileName);

                this.linkTxt.Click += new System.EventHandler(this.rechercheImgButton_Click);
                this.linkTxt.Enter += new System.EventHandler(this.rechercheImgButton_Click);

            }
        }
    }
}
