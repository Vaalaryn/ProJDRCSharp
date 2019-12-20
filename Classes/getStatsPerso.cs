using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json.Linq;


namespace Jeu_de_role.Classes
{
    class getStatsPerso
    {
        private static string classJson;
        private static string server = Properties.Settings.Default.SERVER.ToString();
        private static JToken madata = "";
        
        
        public static string getData(string json, int mytst)
        {
            using (WebClient wc = new WebClient())
            {
                classJson = wc.DownloadString(server + "/Classe/GetAll");
                //const string V = "{ 'ID_PARTIE':'mgD6nsd5IN85IlRO','TITRE':'Test des fichier','DESCRIPTION_PARTIE':'Ok','image':[],'joueur':[{'utilisateur':{'ID_UTIL':1,'MAIL':'tata','PSEUDO':'toto','AVATAR':'MTIzNA=='},'personnage':[],'ID_JOUEUR':15,'ID_UTIL':1,'ID_PARTIE':'mgD6nsd5IN85IlRO','IS_MJ':true}]}";
                //json = V;

            }
            var classlist = JArray.Parse(classJson);
            var mydata = "";
            JObject jsonLinq = JObject.Parse(json);
            if (mytst == 12)
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
                mydata =  jsonLinq["PRENOM"].ToString();
            }

            if (mytst == 20)
            {
                mydata = jsonLinq["NIVEAU"].ToString();
            }


            if (mytst == 14)
            {
                mydata = jsonLinq["DESCRIPTION"].ToString();
            }

            if (mytst == 3)
            {

                foreach (JObject item in classlist)
                {
                    if (item["ID_CLASSE"].ToString() == jsonLinq["ID_CLASSE"].ToString())
                    {
                        mydata =  jsonLinq["VIE"].ToString() + " / " + item["MAX_VIE"].ToString();
                    }


                }


            }

            if (mytst == 4)
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
                mydata =  jsonLinq["EXPERIENCE"].ToString();
            }

            if (mytst == 8)
            {
                mydata =  jsonLinq["NIVEAU"].ToString();
            }


            if (mytst == 5)
            {
                foreach (JObject item in classlist)
                {
                    if (item["ID_CLASSE"].ToString() == jsonLinq["ID_CLASSE"].ToString())
                    {
                        mydata =  item["PUISSANCE"].ToString();
                    }


                }

            }

            if (mytst == 6)
            {
                foreach (JObject item in classlist)
                {
                    if (item["ID_CLASSE"].ToString() == jsonLinq["ID_CLASSE"].ToString())
                    {
                        mydata =  item["MAGIE"].ToString();
                    }


                }

            }

            if (mytst == 7)
            {
                foreach (JObject item in classlist)
                {
                    if (item["ID_CLASSE"].ToString() == jsonLinq["ID_CLASSE"].ToString())
                    {
                        mydata = item["DEXTERITE"].ToString();
                    }


                }

            }

            if (mytst == 8)
            {
                foreach (JObject item in classlist)
                {
                    if (item["ID_CLASSE"].ToString() == jsonLinq["ID_CLASSE"].ToString())
                    {
                        mydata =  item["OBSERVATION"].ToString();
                    }


                }

            }

            if (mytst == 9)
            {
                foreach (JObject item in classlist)
                {
                    if (item["ID_CLASSE"].ToString() == jsonLinq["ID_CLASSE"].ToString())
                    {
                        mydata =  item["INTELLIGENCE"].ToString();
                    }

                }

            }

            if (mytst == 10)
            {
                foreach (JObject item in classlist)
                {
                    if (item["ID_CLASSE"].ToString() == jsonLinq["ID_CLASSE"].ToString())
                    {
                        mydata =  item["CHANCE"].ToString();
                    }


                }

            }

            if (mytst == 11)
            {
                foreach (JObject item in classlist)
                {
                    if (item["ID_CLASSE"].ToString() == jsonLinq["ID_CLASSE"].ToString())
                    {
                        mydata = item["CHARISME"].ToString();
                    }


                }

            }

            if (mytst == 13)
            {
                foreach (JObject item in classlist)
                {
                    if (item["ID_CLASSE"].ToString() == jsonLinq["ID_CLASSE"].ToString())
                    {
                        mydata =  item["DESCRIPTION"].ToString();
                    }


                }

            }

            if (mytst == 15)
            {
                mydata = jsonLinq["BLOCNOTE"].ToString();

            }


            return mydata;
        }
        public static void saveBN(string txt, string json)
        {
            JObject jsonLinq = JObject.Parse(json);
            Task.Run(() =>
            {
                Task<string> res = Requetes.PostInfo(server + "/Personnage/UpdatePersonnage", new List<Models.AttributeModel>
                    {
                        new Models.AttributeModel("blocnote",txt),
                        new Models.AttributeModel("idPersonnage",(int)jsonLinq["ID_PERSO"])
                    });
            });
        }
    }
}
