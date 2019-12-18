﻿using Jeu_de_role.Models;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_de_role
{
    public partial class Inscription : Form
    {
        private string server = Properties.Settings.Default.SERVER2.ToString();

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
            try
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
            catch
            {
                return new byte[0];
            }
            
        }

        private bool Exist(string mail, string pseudo)
        {
            return false;
        }

        private async Task<string> AjoutBDD(string mail, string pseudo, string mdp)
        {
            try
            {
                string url = server + "/Utilisateur/Inscription";
                return await Requetes.PostInfo(url, new List<AttributeModel> {
                new AttributeModel("mail",mail),
                new AttributeModel("pseudo",pseudo),
                new AttributeModel("mdp",mdp),
                new AttributeModel("mdpConfirm", mdp)
            });

            }
            catch
            {
                return "0";
            }
        }

        public async Task<string> ImageProfil(string mail, string pseudo, string mdp,byte[] imdData)
        {
            string url = server + "/Utilisateur/Inscription";

            HttpClient httpClient = new HttpClient();
            MultipartFormDataContent form = new MultipartFormDataContent();

            form.Add(new StringContent(mail), "mail");
            form.Add(new StringContent(pseudo), "pseudo");
            form.Add(new StringContent(mdp), "mdp");
            form.Add(new StringContent(mdp), "mdpConfirm");
            form.Add(new ByteArrayContent(imdData, 0, imdData.Length), "image", "pic.jpg");
            HttpResponseMessage response = await httpClient.PostAsync(url, form);

            response.EnsureSuccessStatusCode();
            httpClient.Dispose();
            string sd = response.Content.ReadAsStringAsync().Result;


            return sd;
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
                    Task.Run(() =>
                    {
                        Task<string> result = ImageProfil(mail, pseudo, mdp,ImageData);
                        
                    });
                    
                }
                try
                {
                    testPictureBox.Image = BytetoImage(ImageData);
                }
                catch (Exception)
                {

                    
                }
               
            }
            else
            {
                MessageBox.Show("Erreur, vérifier vos informations.");
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
