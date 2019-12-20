using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_de_role
{
    public partial class Profil : Form
    {
        private int id;


        public Profil(int idUtil)
        {
            InitializeComponent();
            id = idUtil;
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {

        }

        private void Profil_Load_1(object sender, System.EventArgs e)
        {
            Task.Run(() =>
            {
                Task<string> result = Requetes.GetInfo(Properties.Settings.Default.SERVER.ToString() + "/Utilisateur/GetById/" + id);
                JObject json = JObject.Parse(result.Result);
                this.Invoke(new MethodInvoker(delegate
                {
                    mail_value.Text = json["MAIL"].ToString();
                    pseudo_value.Text = json["PSEUDO"].ToString();
                    pictureBox1.Image = Inscription.BytetoImage(Convert.FromBase64String(json["AVATAR"].ToString()));
                }));
            });
        }

        private void mail_Click_Click(object sender, EventArgs e)
        {
            ChangeMail mailBox = new ChangeMail(id);
            mailBox.Show();
        }

        private void mdp_Click_Click(object sender, EventArgs e)
        {
            ChangeMDP mdpBox = new ChangeMDP(id);
            mdpBox.Show();
        }

        private void pseudo_Click_Click(object sender, EventArgs e)
        {
            ChangePseudo pseudoBox = new ChangePseudo(id);
            pseudoBox.Show();
        }

        public async Task<string> UpdateAvatar(string mdp, byte[] imdData)
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

        private void avatar_Click_Click(object sender, EventArgs e)
        {
            ChangeAvatar avatarBox = new ChangeAvatar(id);
            avatarBox.Show();
        }
    }
}
