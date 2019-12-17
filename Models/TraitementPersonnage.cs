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
        public static List<getFichePerso> ListeReader(string json)
        {
           
            var myLinq = JObject.Parse(json);
            var etap = JArray.Parse(myLinq["joueur"].ToString());
            
            foreach (JObject item in etap)
            {
                tst = item.GetValue("personnage");
                
            }
            
            foreach (JObject item in tst)
            {
                if ((bool)item["VIVANT"] == true){
                    madata = item;
                }
                

            }
            var jsonLinq =madata;
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
