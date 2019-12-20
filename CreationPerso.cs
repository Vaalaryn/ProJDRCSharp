using Jeu_de_role.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_de_role
{
    public partial class CreationPerso : Form
    {
        private JArray ClasseJson;

        private int idUtil;
        private string idPartie;
        private RejoindrePartie window;

        public CreationPerso(int util, string partie, RejoindrePartie linkedWindow)
        {
            InitializeComponent();
            idUtil = util;
            idPartie = partie;
            window = linkedWindow;
            Task.Run(() =>
            {
                Task<string> result = Requetes.GetInfo(Properties.Settings.Default.SERVER.ToString() + "/Classe/GetAll");
                JArray json = JArray.Parse(result.Result);
                this.Invoke(new MethodInvoker(delegate
                {
                    ClasseJson = json;
                    foreach (JObject item in json)
                    {
                        select_classe.Items.Insert(Convert.ToInt32(item["ID_CLASSE"].ToString()) - 1, item["DESIGNATION"].ToString());

                    }

                }));
            });
        }

        private void CreationPerso_Load(object sender, EventArgs e)
        {

        }

        private void select_classe_SelectedIndexChanged(object sender, EventArgs e)
        {
            vie_value.Text = ClasseJson[select_classe.SelectedIndex]["MAX_VIE"].ToString();
            mana_value.Text = ClasseJson[select_classe.SelectedIndex]["MAX_MANA"].ToString();
            puissance_value.Text = ClasseJson[select_classe.SelectedIndex]["PUISSANCE"].ToString();
            magie_value.Text = ClasseJson[select_classe.SelectedIndex]["MAGIE"].ToString();
            dexterite_value.Text = ClasseJson[select_classe.SelectedIndex]["DEXTERITE"].ToString();
            observation_value.Text = ClasseJson[select_classe.SelectedIndex]["OBSERVATION"].ToString();
            intelligence_value.Text = ClasseJson[select_classe.SelectedIndex]["INTELLIGENCE"].ToString();
            chance_value.Text = ClasseJson[select_classe.SelectedIndex]["CHANCE"].ToString();
            charisme_value.Text = ClasseJson[select_classe.SelectedIndex]["CHARISME"].ToString();
            description_classe.Text = ClasseJson[select_classe.SelectedIndex]["DESCRIPTION"].ToString();
        }

        private void mana_value_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void magie_value_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void intelligence_value_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                int idJoueur;
                Task<string> result = Requetes.PostInfo(Properties.Settings.Default.SERVER.ToString() + "/Joueur/Ajouter", new List<AttributeModel>
                {
                    new AttributeModel ("idUtil", idUtil),
                    new AttributeModel ("idPartie", idPartie)

                });
                
                this.Invoke(new MethodInvoker(delegate
                {
                    idJoueur = Convert.ToInt32(result.Result);
                    Task<string> result2 = Requetes.PostInfo(Properties.Settings.Default.SERVER.ToString() + "/Personnage/Ajouter", new List<AttributeModel>
                        {
                            new AttributeModel ("idJoueur", idJoueur),
                            new AttributeModel ("idClasse", select_classe.SelectedIndex + 1),
                            new AttributeModel ("nom", nom_perso.Text),
                            new AttributeModel ("prenom", prenom_perso.Text),
                            new AttributeModel ("description", desc_perso.Text),
                            new AttributeModel ("vie", ClasseJson[select_classe.SelectedIndex]["MAX_VIE"].ToString()),
                            new AttributeModel ("mana", ClasseJson[select_classe.SelectedIndex]["MAX_MANA"].ToString())
                        });

                    window.ChangerNomPerso(nom_perso.Text);
                    window.Show();
                    this.Close();
                }));
            });
            
        }
    }
}
