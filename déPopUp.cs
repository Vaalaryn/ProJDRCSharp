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
    public partial class déPopUp : Form
    {
        public déPopUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lancerBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, Convert.ToInt32(déFacetxtBx.Text) + 1);
            resultDeDtg.Text = Convert.ToString(randomNumber);

            if (déFacetxtBx.Text == string.Empty && déNbtxtBx.Text == string.Empty)
            {
                MessageBox.Show("Les champs sont vides");
            }
        }

        private void resultDéLbl_Click(object sender, EventArgs e)
        {

        }

        private void déFacetxtBx_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void déPopUp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
