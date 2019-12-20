using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Jeu_de_role.Models;
using Newtonsoft.Json.Linq;

namespace Jeu_de_role
{
    public static class Requetes
    {
        static string server = Properties.Settings.Default.SERVER.ToString();

        /* Helpers HTTP GET et POST */

        /// <summary>
        /// Effectue un HttpPost
        /// </summary>
        /// <param name="url"></param>
        /// <param name="attributes"></param>
        /// <returns></returns>
        public static async Task<string> PostInfo(string url, List<AttributeModel> attributes = null)
        {
            if (attributes.Count != 0 && attributes != null)
            {
                url += "?";
                foreach (AttributeModel attr in attributes)
                {
                    url += attr.Name + "=" + attr.Value.ToString() + "&";
                }
                url = url.Substring(0, url.Length - 1);
            }

            System.Diagnostics.Debug.WriteLine(url);

            HttpClient client = new HttpClient();

            var values = new Dictionary<string, string>
            {

            };

            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync(url, content);

            string responseString = await response.Content.ReadAsStringAsync();

            System.Diagnostics.Debug.WriteLine(responseString);

            return responseString;
        }


        public static async Task<string> GetInfo(string url)
        {

            using (HttpClient client = new HttpClient())
            {
                // autre possibilité
                //client.BaseAddress = new Uri(page);

                // on peut compléter le header
                //client.DefaultRequestHeaders.Add("X-TEST", "123");

                // la requête
                using (HttpResponseMessage response = await client.GetAsync(url))
                {

                    using (HttpContent content = response.Content)
                    {
                        // récupère la réponse, il ne resterai plus qu'à désérialiser
                        string result = await content.ReadAsStringAsync();
                        return result;
                    }
                }
            }
        }


        //Requêtes vers l'api
        /// <summary>
        /// Récupère les parties de l'utilisateur.
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <returns></returns>
        public static async Task<List<PartieModel>> GetParties(int idUtilisateur)
        {
            List<PartieModel> listResult = new List<PartieModel>();

            string url = server + "/Partie/PartiesEnCours?idUtilisateur=" + idUtilisateur;
            string result = await GetInfo(url);
            JArray json = JArray.Parse(result);
            foreach(JObject jo in json)
            {
                listResult.Add(new PartieModel
                {
                    ID_PARTIE = jo["ID_PARTIE"].ToString(),
                    DESCRIPTION_PARTIE = jo["DESCRIPTION_PARTIE"].ToString(),
                    TITRE = jo["TITRE"].ToString(),
                    ISMJ = Convert.ToBoolean(jo["IS_MJ"].ToString()),
                    ID_JOUEUR = Convert.ToInt32(jo["ID_JOUEUR"].ToString())
                });
            }

            return listResult;

        }







    }
}
