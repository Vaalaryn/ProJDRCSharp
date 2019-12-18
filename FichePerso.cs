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
using Newtonsoft.Json;
using System.Data.Linq;
using Jeu_de_role.Models;


namespace Jeu_de_role
{


    public partial class FichePerso : Form
    {
        public string json;
        public FichePerso()
        {
            InitializeComponent();
            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString("http://10.176.131.106:8080/api/Personnage/GetById?idPerso=19");
                //const string V = "{ 'ID_PARTIE':'mgD6nsd5IN85IlRO','TITRE':'Test des fichier','DESCRIPTION_PARTIE':'Ok','image':[],'joueur':[{'utilisateur':{'ID_UTIL':1,'MAIL':'tata','PSEUDO':'toto','AVATAR':'MTIzNA=='},'personnage':[],'ID_JOUEUR':15,'ID_UTIL':1,'ID_PARTIE':'mgD6nsd5IN85IlRO','IS_MJ':true}]}";
                //json = V;

            }
            label1.Text = TraitementPersonnage.getData(json, 0);
            label2.Text = TraitementPersonnage.getData(json, 1);
            label3.Text = TraitementPersonnage.getData(json, 2);
            label4.Text = TraitementPersonnage.getData(json, 3);
            textBox1.Text = TraitementPersonnage.getData(json, 4);
            label6.Text = TraitementPersonnage.getData(json, 5);
            label7.Text = TraitementPersonnage.getData(json, 6);
            label8.Text = TraitementPersonnage.getData(json, 7);
            label9.Text = TraitementPersonnage.getData(json, 8);
            label10.Text = TraitementPersonnage.getData(json, 9);
            label11.Text = TraitementPersonnage.getData(json, 10);
            label12.Text = TraitementPersonnage.getData(json, 11);
            label13.Text = TraitementPersonnage.getData(json, 12);
            label14.Text = TraitementPersonnage.getData(json, 13);
            label15.Text = TraitementPersonnage.getData(json, 14);
            label16.Text = TraitementPersonnage.getData(json, 15);

        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
