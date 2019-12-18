using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Data.Linq;
using Jeu_de_role.Classes;
namespace Jeu_de_role.Models
{
    
    class TraitementPersonnage
    {
        public static JToken tst ="";
        public static JToken madata = "";

        public static string getData(string json, int mytst)
        {
            var classJson = "";
            var jsonLinq = JObject.Parse(json);
            var mydata = "";
            using (WebClient wc = new WebClient())
            {
                classJson = wc.DownloadString("http://10.176.131.106:8080/api/Classe/GetAll");
                //const string V = "{ 'ID_PARTIE':'mgD6nsd5IN85IlRO','TITRE':'Test des fichier','DESCRIPTION_PARTIE':'Ok','image':[],'joueur':[{'utilisateur':{'ID_UTIL':1,'MAIL':'tata','PSEUDO':'toto','AVATAR':'MTIzNA=='},'personnage':[],'ID_JOUEUR':15,'ID_UTIL':1,'ID_PARTIE':'mgD6nsd5IN85IlRO','IS_MJ':true}]}";
                //json = V;

            }
            var classlist = JArray.Parse(classJson);
            if (mytst == 0)
            {
                

                foreach (JObject item in classlist)
                {
                    if (item["ID_CLASSE"].ToString() == jsonLinq["ID_CLASSE"].ToString())
                    {
                        mydata = item["DESIGNATION"].ToString();
                    }


                }

                

            }
            if (mytst == 1)
            {
                mydata = jsonLinq["NOM"].ToString();
            }

            if (mytst == 2)
            {
                mydata = jsonLinq["PRENOM"].ToString();
            }

            if (mytst == 3)
            {
               if ((bool)jsonLinq["VIVANT"] == true)
                {
                    mydata = "Vivant";
                }
                if ((bool)jsonLinq["VIVANT"] == false)
                {
                    mydata = "Mort";
                }
            }

            if (mytst == 4)
            {
                mydata = jsonLinq["DESCRIPTION"].ToString();
            }

            if (mytst == 5)
            {

                foreach (JObject item in classlist)
                {
                    if (item["ID_CLASSE"].ToString() == jsonLinq["ID_CLASSE"].ToString())
                    {
                        mydata = jsonLinq["VIE"].ToString()+" / "+item["MAX_VIE"].ToString();
                    }


                }

                
            }

            if (mytst == 6)
            {
                foreach (JObject item in classlist)
                {
                    if (item["ID_CLASSE"].ToString() == jsonLinq["ID_CLASSE"].ToString())
                    {
                        mydata = jsonLinq["MANA"].ToString() + " / " + item["MAX_MANA"].ToString();
                    }


                }
                
            }

            if (mytst == 7)
            {
                mydata = jsonLinq["EXPERIENCE"].ToString();
            }

            if (mytst == 8)
            {
                mydata = jsonLinq["NIVEAU"].ToString();
            }


            if (mytst == 9)
            {
                foreach (JObject item in classlist)
                {
                    if (item["ID_CLASSE"].ToString() == jsonLinq["ID_CLASSE"].ToString())
                    {
                        mydata =item["PUISSANCE"].ToString();
                    }


                }

            }

            if (mytst == 10)
            {
                foreach (JObject item in classlist)
                {
                    if (item["ID_CLASSE"].ToString() == jsonLinq["ID_CLASSE"].ToString())
                    {
                        mydata =item["MAGIE"].ToString();
                    }


                }

            }

            if (mytst == 11)
            {
                foreach (JObject item in classlist)
                {
                    if (item["ID_CLASSE"].ToString() == jsonLinq["ID_CLASSE"].ToString())
                    {
                        mydata =item["DEXTERITE"].ToString();
                    }


                }

            }

            if (mytst == 12)
            {
                foreach (JObject item in classlist)
                {
                    if (item["ID_CLASSE"].ToString() == jsonLinq["ID_CLASSE"].ToString())
                    {
                        mydata =item["OBSERVATION"].ToString();
                    }


                }

            }

            if (mytst == 13)
            {
                foreach (JObject item in classlist)
                {
                    if (item["ID_CLASSE"].ToString() == jsonLinq["ID_CLASSE"].ToString())
                    {
                        mydata =item["INTELLIGENCE"].ToString();
                    }

                }

            }

            if (mytst == 14)
            {
                foreach (JObject item in classlist)
                {
                    if (item["ID_CLASSE"].ToString() == jsonLinq["ID_CLASSE"].ToString())
                    {
                        mydata =item["CHANCE"].ToString();
                    }


                }

            }

            if (mytst == 15)
            {
                foreach (JObject item in classlist)
                {
                    if (item["ID_CLASSE"].ToString() == jsonLinq["ID_CLASSE"].ToString())
                    {
                        mydata =item["CHARISME"].ToString();
                    }


                }

            }


            return mydata;
        }



        public static List<getFichePerso> ListeReader(string json)
        {
           
            var jsonLinq = JObject.Parse(json);
           
            List<getFichePerso> utilisateurs = new List<getFichePerso>();
           

            getFichePerso u = new getFichePerso();
            u.ID_CLASSE = jsonLinq["ID_CLASSE"].ToString();
            u.NOM = jsonLinq["NOM"].ToString();
            u.PRENOM = jsonLinq["PRENOM"].ToString();
            u.VIVANT = (bool)jsonLinq["VIVANT"];
            u.DESCRIPTION = jsonLinq["DESCRIPTION"].ToString();
            u.VIE = jsonLinq["VIE"].ToString();
            u.MANA = jsonLinq["MANA"].ToString();
            u.EXPERIENCE = jsonLinq["EXPERIENCE"].ToString();
            u.NIVEAU = jsonLinq["NIVEAU"].ToString();



            utilisateurs.Add(u);





            return utilisateurs;

        }

        public static List<getFichePerso> ListeBuilder(string json)
        {

            var myLinq = JObject.Parse(json);
            var etap = JArray.Parse(myLinq["joueur"].ToString());

            foreach (JObject item in etap)
            {
                tst = item.GetValue("personnage");
            }

            foreach (JObject item in tst)
            {
                if ((bool)item["VIVANT"] == true)
                {
                    madata = item;
                }


            }
            var jsonLinq = madata;
            List<getFichePerso> utilisateurs = new List<getFichePerso>();


            getFichePerso u = new getFichePerso();
            u.ID_CLASSE = jsonLinq["ID_CLASSE"].ToString();
            u.NOM = jsonLinq["NOM"].ToString();
            u.PRENOM = jsonLinq["PRENOM"].ToString();
            u.VIVANT = (bool)jsonLinq["VIVANT"];
            u.DESCRIPTION = jsonLinq["DESCRIPTION"].ToString();
            u.VIE = jsonLinq["VIE"].ToString();
            u.MANA = jsonLinq["MANA"].ToString();
            u.EXPERIENCE = jsonLinq["EXPERIENCE"].ToString();
            u.NIVEAU = jsonLinq["NIVEAU"].ToString();



            utilisateurs.Add(u);





            return utilisateurs;

        }
    }
}
