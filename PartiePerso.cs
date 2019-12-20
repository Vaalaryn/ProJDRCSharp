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
        
        public static string idPartie = "ZJw0mbSIEzmoBQsp";
        public static int id_Joueur = 50;
        public JObject jsonPartie;
        public PartiePerso()
        {
            InitializeComponent();

            jsonPartie = JObject.Parse(File.ReadAllText("//10.176.131.132/Users/Elise/Documents/Watcher/Parties/" + idPartie + ".json"));
            //const string V = "{ 'ID_PARTIE':'mgD6nsd5IN85IlRO','TITRE':'Test des fichier','DESCRIPTION_PARTIE':'Ok','image':[],'joueur':[{'utilisateur':{'ID_UTIL':1,'MAIL':'tata','PSEUDO':'toto','AVATAR':'MTIzNA=='},'personnage':[],'ID_JOUEUR':15,'ID_UTIL':1,'ID_PARTIE':'mgD6nsd5IN85IlRO','IS_MJ':true}]}";
            //json = V;



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
            label1.Text = getStatsPerso.getData(getPersonnage(tst), 1);
            label2.Text = getStatsPerso.getData(getPersonnage(tst), 2);
            label3.Text = getStatsPerso.getData(getPersonnage(tst), 3);
            label4.Text = getStatsPerso.getData(getPersonnage(tst), 4);
            label5.Text = getStatsPerso.getData(getPersonnage(tst), 5);
            label6.Text = getStatsPerso.getData(getPersonnage(tst), 6);
            label7.Text = getStatsPerso.getData(getPersonnage(tst), 7);
            label8.Text = getStatsPerso.getData(getPersonnage(tst), 8);
            label9.Text = getStatsPerso.getData(getPersonnage(tst), 9);
            label10.Text = getStatsPerso.getData(getPersonnage(tst), 10);
            label11.Text = getStatsPerso.getData(getPersonnage(tst), 11);
            label12.Text = getStatsPerso.getData(getPersonnage(tst), 12);
            label13.Text = getStatsPerso.getData(getPersonnage(tst), 13);
            textBox1.Text = getStatsPerso.getData(getPersonnage(tst), 14);
            textBox2.Text = getStatsPerso.getData(getPersonnage(tst), 15);
        }

        private void fileSystemWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            if (e.FullPath.Split('\\').Last() == idPartie + ".json")
            {
                jsonPartie = JObject.Parse(File.ReadAllText(e.FullPath));
                setLabels();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tst = jsonPartie["joueur"].ToString();
            getStatsPerso.saveBN(textBox2.Text, getPersonnage(tst));
        }
    }
}
