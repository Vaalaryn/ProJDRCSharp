using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_de_role
{
    public partial class PartieMJ : Form
    {
        private string server = Properties.Settings.Default.SERVER.ToString();
        private string idPartie = "";
        private JObject jsonPartie = new JObject();
        private JArray jsonLog = new JArray();
        private DataGridViewRow rowClone;
        private int idPersoSelected = 0;


        public PartieMJ(string partie)
        {
            InitializeComponent();
            rowClone = (DataGridViewRow)jListDtg.Rows[0].Clone();
            jListDtg.AllowUserToAddRows = false;
            idPartie = partie;
            InitJson();

        }

        public void InitJson()
        {
            string textLog = File.ReadAllText(@"\\10.176.131.132\Users\Elise\Documents\Watcher\Logs\" + idPartie + ".json");
            string textPartie = File.ReadAllText(@"\\10.176.131.132\Users\Elise\Documents\Watcher\Parties\" + idPartie + ".json");
            if (!String.IsNullOrEmpty(textPartie))
                jsonPartie = JObject.Parse(textPartie);
            if (!String.IsNullOrEmpty(textLog))
                jsonLog = JArray.Parse(textLog);

            if (jsonPartie.Count > 0)
                RefreshListePerso();
            if (jsonLog.Count > 0)
                RefreshLogs();
        }



        public void EcrireLog(string log)
        {
            logTxtbx.Text += log;
        }



        /* ****************** Liste des perso **********************/
        public void RefreshListePerso()
        {
            jListDtg.Rows.Clear();
            JArray listeJoueur = (JArray)jsonPartie["joueur"];

            foreach (JObject joueurInfo in listeJoueur)
            {
                JArray perso = JArray.Parse(joueurInfo["personnage"].ToString());
                if (perso.Count > 0)
                    AddRowToDgv(perso.First["NOM"].ToString(), perso.First["PRENOM"].ToString(), perso.First["ID_PERSO"].ToString());
            }
        }

        private void AddRowToDgv(string nom, string prenom, string idJoueur)
        {
            DataGridViewRow row = (DataGridViewRow)rowClone.Clone();
            row.Cells[0].Value = nom;
            row.Cells[1].Value = prenom;
            row.Cells[2].Value = idJoueur;
            jListDtg.Rows.Add(row);
        }
        /* ****************** Liste des perso **********************/

        /* ****************** Logs *********************************/
        public void RefreshLogs()
        {
            logTxtbx.Text = "";
            int i = 0;
            if (jsonLog.Count > 0)
                foreach (JObject json in jsonLog)
                {
                    int type = Convert.ToInt32(json["TYPE"].ToString());
                    logTxtbx.AppendText("[" + Convert.ToDateTime(json["DATE_ENVOI"].ToString()).ToShortTimeString() + "]" + " : " + json["MESSAGE"].ToString() + "\r\n");
                    logTxtbx.SelectionStart = logTxtbx.GetFirstCharIndexFromLine(i);
                    logTxtbx.SelectionLength = logTxtbx.Lines[i].Length;
                    if (type == 1)
                        logTxtbx.SelectionColor = System.Drawing.Color.Green;
                    else if (type == 2)
                        logTxtbx.SelectionColor = System.Drawing.Color.Red;
                    else if (type == 3)
                        logTxtbx.SelectionColor = System.Drawing.Color.Purple;
                    else if (type == 4)
                        logTxtbx.SelectionColor = System.Drawing.Color.Blue;
                    i++;
                }
        }
        /* ****************** Logs *********************************/



        //Evénements 
        private void déBtn_Click(object sender, EventArgs e)
        {
            var déPopUp = new déPopUp();
            déPopUp.Show(this);
        }

        private void jListDtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Task.Run(() =>
            {
                Task<string> result = Requetes.GetInfo(server + "/Joueur/GetByPartie?idPartie=" + idPartie);
            });
        }

        private void modifJBtn_Click(object sender, EventArgs e)
        {
            if(idPersoSelected > 0)
            {
                var modifJ = new modifJ(idPersoSelected);
                modifJ.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un personnage svp.");
            }
        }

        private void eventBtn_Click(object sender, EventArgs e)
        {
            var evenement = new Evenement(this, idPartie);
            evenement.Show(this);
        }
        /// <summary>
        /// Changement des fichiers logs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WatcherLogs_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            try
            {

                if (e.FullPath.Split('\\').Last() == idPartie + ".json")
                {
                    logTxtbx.Text = "";
                    System.Diagnostics.Debug.WriteLine(e.FullPath);
                    jsonLog = JArray.Parse(File.ReadAllText(e.FullPath));
                    RefreshLogs();
                }
            }
            catch
            {
                RefreshLogs();
            }

        }

        private void WatcherPartie_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            try
            {
                if (e.FullPath.Split('\\').Last() == idPartie + ".json")
                {
                    System.Diagnostics.Debug.WriteLine(e.FullPath);
                    jsonPartie = JObject.Parse(File.ReadAllText(e.FullPath));
                    RefreshListePerso();
                }
            }
            catch (Exception)
            {
                RefreshListePerso();

            }

        }

        private void changeMJBtn_Click(object sender, EventArgs e)
        {

        }

        private void modifInventBtn_Click(object sender, EventArgs e)
        {
            var modifInventaire = new ModifInventaire();
            modifInventaire.Show(this);
        }

        private void modifInventBtn_Click_1(object sender, EventArgs e)
        {

            ModifInventaire modif = new ModifInventaire();
            modif.Show();

        }

        private void jListDtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow dgvr in jListDtg.SelectedRows)
            {
                try
                {
                    idPersoSelected = Convert.ToInt32(dgvr.Cells["ID"].Value.ToString());
                }
                catch
                {
                    idPersoSelected = 0;
                }
            }
        }
    }
}
