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
                json = wc.DownloadString("file://10.176.131.132/Users/Elise/Documents/Watcher/Parties/Z3R5WL9pYuC0lHIk.json");
                //const string V = "{ 'ID_PARTIE':'mgD6nsd5IN85IlRO','TITRE':'Test des fichier','DESCRIPTION_PARTIE':'Ok','image':[],'joueur':[{'utilisateur':{'ID_UTIL':1,'MAIL':'tata','PSEUDO':'toto','AVATAR':'MTIzNA=='},'personnage':[],'ID_JOUEUR':15,'ID_UTIL':1,'ID_PARTIE':'mgD6nsd5IN85IlRO','IS_MJ':true}]}";
                //json = V;

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //JObject myjson = JObject.Parse(json);

            //DataSet data = JsonConvert.DeserializeObject<DataSet>(json);
            //System.Diagnostics.Debug.WriteLine(json);
            //System.Diagnostics.Debug.WriteLine('yolooooo');
            dgv.DataSource = TraitementPersonnage.ListeReader(json);
            //var jsonLinq = JArray.Parse(json);
            

        }

       

    }
}
