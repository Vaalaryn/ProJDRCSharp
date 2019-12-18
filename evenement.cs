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
    public partial class evenement : Form
    {
        private PartieMJ fenetre;

        public evenement(PartieMJ pmj)
        {
            InitializeComponent();
            fenetre = pmj;
        }












        //Evénements
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
        
        private void validEventBtn_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        #endregion
    }
}
