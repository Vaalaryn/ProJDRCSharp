using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using Newtonsoft.Json.Linq;
using System.IO;
using Jeu_de_role.Classes;

namespace Jeu_de_role
{
    public partial class PartiePerso : Form
    {

        public string idPartie = "";
        public int id_Joueur = 0;
        public JObject jsonPartie;
        public JArray jsonLogs;
        public PartiePerso(string idPartie, int idJoueur)
        {
            InitializeComponent();
            this.idPartie = idPartie;
            this.id_Joueur = idJoueur;
            string textLog = File.ReadAllText(@"\\10.176.131.132\Users\Elise\Documents\Watcher\Logs\" + idPartie + ".json");
            jsonPartie = JObject.Parse(File.ReadAllText("//10.176.131.132/Users/Elise/Documents/Watcher/Parties/" + idPartie + ".json"));
            if (!String.IsNullOrEmpty(textLog))
                jsonLogs = JArray.Parse(textLog);
            if (jsonLogs.Count > 0)
                RefreshLogs();

            setLabels();
            System.Diagnostics.Debug.WriteLine(getPersonnage(jsonPartie["joueur"].ToString()));


        }

        private string getPersonnage(string json)
        {
            string mydata = "";
            var myjson = JArray.Parse(json);
            foreach (JObject item in myjson)
            {
                //if (item["personnage"].ToString() == id_Joueur.ToString())
                //{
                //     mydata = item.ToString();
                //}
                var pars1 = JArray.Parse(item["personnage"].ToString());

                foreach (JObject item1 in pars1)
                {

                    if ((int)item1["ID_JOUEUR"] == id_Joueur)
                    {
                        mydata = item1.ToString();
                    }

                }

            }
            return mydata;
        }

        private void setLabels()
        {
            string tst = jsonPartie["joueur"].ToString();
            txtNom.Text = getStatsPerso.getData(getPersonnage(tst), 1);
            txtPrenom.Text = getStatsPerso.getData(getPersonnage(tst), 2);
            txtVie.Text = getStatsPerso.getData(getPersonnage(tst), 3);
            txtMana.Text = getStatsPerso.getData(getPersonnage(tst), 4);
            txtPuissance.Text = getStatsPerso.getData(getPersonnage(tst), 5);
            txtMagie.Text = getStatsPerso.getData(getPersonnage(tst), 6);
            txtDexterite.Text = getStatsPerso.getData(getPersonnage(tst), 7);
            txtObservation.Text = getStatsPerso.getData(getPersonnage(tst), 8);
            txtIntelligence.Text = getStatsPerso.getData(getPersonnage(tst), 9);
            txtChance.Text = getStatsPerso.getData(getPersonnage(tst), 10);
            txtCharisme.Text = getStatsPerso.getData(getPersonnage(tst), 11);
            txtClasse.Text = getStatsPerso.getData(getPersonnage(tst), 12);
            
            txtDescription.Text = getStatsPerso.getData(getPersonnage(tst), 14);
            txtBlocnote.Text = getStatsPerso.getData(getPersonnage(tst), 15);
            txtNiveau.Text = getStatsPerso.getData(getPersonnage(tst), 20);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string tst = jsonPartie["joueur"].ToString();
            getStatsPerso.saveBN(txtBlocnote.Text, getPersonnage(tst));
        }

        private void WatcherPartie_Changed(object sender, FileSystemEventArgs e)
        {
            if (e.FullPath.Split('\\').Last() == idPartie + ".json")
            {
                jsonPartie = JObject.Parse(File.ReadAllText(e.FullPath));
                setLabels();
            }
        }

        public void RefreshLogs()
        {
            txtLogs.Text = "";
            int i = 0;
            if (jsonLogs.Count > 0)
                foreach (JObject json in jsonLogs)
                {
                    int type = Convert.ToInt32(json["TYPE"].ToString());
                    txtLogs.AppendText("[" + Convert.ToDateTime(json["DATE_ENVOI"].ToString()).ToShortTimeString() + "]" + " : " + json["MESSAGE"].ToString() + "\r\n");
                    txtLogs.SelectionStart = txtLogs.GetFirstCharIndexFromLine(i);
                    txtLogs.SelectionLength = txtLogs.Lines[i].Length;
                    if (type == 1)
                        txtLogs.SelectionColor = System.Drawing.Color.Green;
                    else if (type == 2)
                        txtLogs.SelectionColor = System.Drawing.Color.Red;
                    else if (type == 3)
                        txtLogs.SelectionColor = System.Drawing.Color.Purple;
                    else if (type == 4)
                        txtLogs.SelectionColor = System.Drawing.Color.Blue;
                    i++;
                }
        }

        private void WatcherLogs_Changed(object sender, FileSystemEventArgs e)
        {
            try
            {

                if (e.FullPath.Split('\\').Last() == idPartie + ".json")
                {
                    txtLogs.Text = "";
                    System.Diagnostics.Debug.WriteLine(e.FullPath);
                    jsonLogs = JArray.Parse(File.ReadAllText(e.FullPath));
                    RefreshLogs();
                }
            }
            catch
            {
                RefreshLogs();
            }
        }
    }
}
