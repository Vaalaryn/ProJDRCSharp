using Jeu_de_role.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_de_role
{
    public partial class Evenement : Form
    {
        private PartieMJ fenetre;
        private string server = Properties.Settings.Default.SERVER;
        private string idPartie = "";
        private short type = 1;

        public Evenement(PartieMJ pmj, string partie)
        {
            InitializeComponent();
            fenetre = pmj;
            idPartie = partie;
        }












        //Evénements
        #region Event
        private void winRbtn_CheckedChanged(object sender, EventArgs e)
        {
            eventTxtBox.ForeColor = Color.Green;
            type = 1;
        }

        private void looseRbtn_CheckedChanged(object sender, EventArgs e)
        {
            eventTxtBox.ForeColor = Color.Red;
            type = 2;
        }

        private void addMonsterRbtn_CheckedChanged(object sender, EventArgs e)
        {
            eventTxtBox.ForeColor = Color.Purple;
            type = 3;
        }

        private void lootRbtn_CheckedChanged(object sender, EventArgs e)
        {
            eventTxtBox.ForeColor = Color.Blue;
            type = 4;
        }

        private void validEventBtn_Click(object sender, EventArgs e)
        {
            if(eventTxtBox.Text != "")
            {
                string url = server + "/Log/Ajouter";
                Task.Run(() =>
                {
                    Task<string> result = Requetes.PostInfo(url, new List<AttributeModel>
                {
                    new AttributeModel("idPartie",idPartie),
                    new AttributeModel("type",type),
                    new AttributeModel("message",eventTxtBox.Text),
                });
                    this.Invoke(new MethodInvoker(delegate
                    {
                        fenetre.RefreshLogs();
                        this.Close();
                    }));
                });
            }
            else
            {
                MessageBox.Show("Veuillez écrire un message");
            }
            
        }
        #endregion
    }
}
