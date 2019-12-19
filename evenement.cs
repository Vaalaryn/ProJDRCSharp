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
        public static string eventText;
        private PartieMJ fenetre;
        public Evenement(PartieMJ pmj)
        {
            InitializeComponent();
            fenetre = pmj;
        }
        public string EventText
        {
            get { return eventText; }
            set { eventText = value; }
        }
        #region Event
        private void winRbtn_CheckedChanged(object sender, EventArgs e)
        {
            eventTxtBox.ForeColor = Color.Green;
        }

        private void looseRbtn_CheckedChanged(object sender, EventArgs e)
        {
            eventTxtBox.ForeColor = Color.Red;
        }

        private void addMonsterRbtn_CheckedChanged(object sender, EventArgs e)
        {
            eventTxtBox.ForeColor = Color.Purple;
        }

        private void lootRbtn_CheckedChanged(object sender, EventArgs e)
        {
            eventTxtBox.ForeColor = Color.Blue;
        }
        private void eventTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void validEventBtn_Click(object sender, EventArgs e)
        {
            EventText = eventTxtBox.Text;
            fenetre.ecrireLog(EventText);
            this.Close();
        }
        #endregion

        private void evenement_Load(object sender, EventArgs e)
        {

        }
    }
}
