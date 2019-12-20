using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Jeu_de_role
{
    public partial class InfosPartie : Form
    {
        private string server = Properties.Settings.Default.SERVER.ToString();
        public string json;
        private string id;
        public InfosPartie(string idPartie)
        {
            InitializeComponent();
            id = idPartie;
        }

        private void InfosPartie_Load(object sender, EventArgs e)
        {
            string nom_perso = "";
            string prenom_perso = "";
            //string nom_utilisateur = "";
            string classe = "";
            string niveau = "";

            string getallperso = server + "/Partie/GetAllPerso";
            string getInfoUtil = server + "/Joueur/GetUtilByJoueur";
            string getInfoPartie = server + "/Partie/GetById";

            //récupération des informations de la partie

            Task.Run(() =>
            {
                Task<string> resPartie = Requetes.GetInfo(getInfoPartie + "?idPartie=" + id);

                this.Invoke(new MethodInvoker(delegate
                {
                    var partie = JObject.Parse(resPartie.Result);
                    description_label.Text = partie["DESCRIPTION_PARTIE"].ToString();
                    titreLabel.Text = partie["TITRE"].ToString();
                    idPartielabel.Text = id;
                }));
            });

            Task.Run(() =>
            {
                Task<string> res = Requetes.PostInfo(getallperso, new List<Models.AttributeModel>
                    {
                        new Models.AttributeModel("idPartie",id)
                    });
               
                this.Invoke(new MethodInvoker(delegate
                {
                    var myLinq = JArray.Parse(res.Result)[0];

                    DataTable table = new DataTable();
                    table.Columns.Add("Nom perso", typeof(string));
                    table.Columns.Add("Prenom perso", typeof(string));
                    table.Columns.Add("Niveau", typeof(string));
                    table.Columns.Add("classe", typeof(string));
                    //table.Columns.Add("Nom Utilisateur", typeof(string));

                    // Boucle pour afficher les informations des personnages/utilisateur
                    foreach (JToken perso in myLinq.Parent)
                    {

                        nom_perso = perso["perso"]["NOM"].ToString();
                        prenom_perso = perso["perso"]["PRENOM"].ToString();
                        niveau = perso["perso"]["NIVEAU"].ToString();
                        classe = perso["classePerso"]["DESIGNATION"].ToString();

                        //---------------------------------------------------------------
                        //string idjoueur = perso["perso"]["ID_JOUEUR"].ToString();
                        //string url = getInfoUtil + "?idJoueur=" + idjoueur.ToString();
                        //MessageBox.Show("1");
                        /*Task.Run(() =>
                        {
                            Task<string> res2 = Requetes.GetInfo(url);
                           
                            this.Invoke(new MethodInvoker(delegate
                            {
                               // MessageBox.Show("1");
                                var test = JObject.Parse(res2.Result);
                                nom_utilisateur = test["utilisateur"]["PSEUDO"].ToString();
                            }));
                        });*/
                        //MessageBox.Show("1");
                        //---------------------------------------------------------------
                        //nom_utilisateur
                        table.Rows.Add(nom_perso, prenom_perso, niveau, classe);
                    }
                    dgv.DataSource = table;

                    //  this.Close();
                }));
            });
        }
    }
}
