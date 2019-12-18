using Jeu_de_role.Models;
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
        private string server = Properties.Settings.Default.SERVER.ToString();

        public byte[] bytes;

        public Inscription()
        {
            InitializeComponent();
        }

        private Image BytetoImage(byte[] ImageData)
        {
            MemoryStream ms = new MemoryStream(ImageData);
            ms.Position = 0;
            return Image.FromStream(ms);
        }

        private Byte[] ImagetoByte(string FileName)
        {
            FileStream fs;
            BinaryReader br;
            byte[] ImageData;
            fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            br = new BinaryReader(fs);
            ImageData = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            return ImageData;
        }

        private bool Exist(string mail, string pseudo)
        {
            return false;
        }

        private async Task<bool> AjoutBDD(string mail, string pseudo, string mdp, Byte[] img)
        {
            try
            {
                string url = server + "/Utilisateur/Inscription";
                await Requetes.PostInfo(url, new List<AttributeModel> {
                new AttributeModel("mail",mail),
                new AttributeModel("pseudo",pseudo),
                new AttributeModel("mdp",mdp),
                new AttributeModel("mdpConfirm", mdp),
                new AttributeModel("avatar",img)
            });

                return true;
            }
            catch
            {
                return false;
            }

        }

        private void confirmerButton_Click(object sender, EventArgs e)
        {
            if (mailTxt.Text.Length > 0 && pseudoTxt.Text.Length > 0 && mdpTxt.Text == confirmMdpTxt.Text)
            {
                var mail = this.mailTxt.Text;
                var pseudo = this.pseudoTxt.Text;
                var mdp = this.mdpTxt.Text;

                byte[] ImageData;
                ImageData = ImagetoByte(linkTxt.Text);

                if (!Exist(mail, pseudo))
                {
                    Task.Run<bool>(() =>
                    {
                        Task<bool> result = AjoutBDD(mail, pseudo, mdp, ImageData);
                        return result.Result;
                    });
                    
                }

                testPictureBox.Image = BytetoImage(ImageData);
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
