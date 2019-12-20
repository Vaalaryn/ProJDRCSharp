using System;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_de_role
{
    public partial class ChangeAvatar : Form
    {

        private int id = 0;
        public ChangeAvatar(int idUtil)
        {
            InitializeComponent();
            id = idUtil;
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

        public async Task<string> UpdateAvatar(int id, string mdp, byte[] imdData)
        {
            string url = Properties.Settings.Default.SERVER.ToString() + "/Utilisateur/Inscription";

            HttpClient httpClient = new HttpClient();
            MultipartFormDataContent form = new MultipartFormDataContent();

            form.Add(new StringContent(Convert.ToString(id)), "idUtil");
            form.Add(new StringContent(mdp), "mdp");
            form.Add(new ByteArrayContent(imdData, 0, imdData.Length), "image", "pic.jpg");
            HttpResponseMessage response = await httpClient.PostAsync(url, form);

            response.EnsureSuccessStatusCode();
            httpClient.Dispose();
            string sd = response.Content.ReadAsStringAsync().Result;

            return sd;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (linkTxt.Text != "" && mdp_value.Text != "")
            {
                Task.Run(() =>
                {
                    Task<string> result = UpdateAvatar(id, mdp_value.Text, Inscription.ImagetoByte(linkTxt.Text));
                    this.Invoke(new MethodInvoker(delegate
                    {
                        MessageBox.Show(result.Result);
                    }));
                });
            }
            else
            {
                MessageBox.Show("Champs vide");
            }
        }
    }
}
