using Jeu_de_role.Models;
using Newtonsoft.Json.Linq;
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
    public partial class modifJ : Form
    {
        private int idPerso = 0;
        private string server = Properties.Settings.Default.SERVER.ToString();
        JObject jsonPerso;

        public modifJ(int idPerso)
        {
            InitializeComponent();
            this.idPerso = idPerso;
            InitJson();
        }

        private void InitJson()
        {
            string url = server + "/Personnage/GetById?idPerso=" + idPerso;
            Task.Run(() =>
            {
                Task<string> result = Requetes.GetInfo(url);
                result.Wait();
                jsonPerso = JObject.Parse(result.Result);
                this.Invoke(new MethodInvoker(delegate
                {
                    txtNom.Text = jsonPerso["NOM"].ToString();
                    txtPrenom.Text = jsonPerso["PRENOM"].ToString();
                }));
            });
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string url = server + "/Personnage/UpdatePersonnage";
            Task.Run(() =>
            {
                Task<string> result = Requetes.PostInfo(url, new List<AttributeModel>
                {
                    new AttributeModel("idPersonnage",idPerso),
                    new AttributeModel("vie",nbVie.Value),
                    new AttributeModel("mana",nbMana.Value),
                    new AttributeModel("experience",nbXp.Value),
                    new AttributeModel("niveau",nbNiveau.Value)
                });
                result.Wait();
            });

            this.Close();
        }
    }
}
