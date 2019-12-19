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
            var nbrDé = Convert.ToInt32(déNbtxtBx.Text);
            var nbrFaces = Convert.ToInt32(déFacetxtBx.Text);
            var somme=0;
            var min = nbrFaces;
            var max = 0;
            //var precedent = 0;
            BindingList<int> termsList = new BindingList<int>();
            Random random = new Random();
            System.Diagnostics.Debug.WriteLine("tst");
            //resultDeDtg.Text = Convert.ToString(randomNumber);

            if (déFacetxtBx.Text == string.Empty || déNbtxtBx.Text == string.Empty)
            {
                System.Diagnostics.Debug.WriteLine("NOPE");
                MessageBox.Show("Au moins un des champs est vide");
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Rows.Add();
                System.Diagnostics.Debug.WriteLine("tst1");
                for (int i = 0; i < nbrDé; i++)
                {
                    string tst = "Dé " + (i+1).ToString();
                    dt.Columns.Add(tst) ;
                    int randomNumber = random.Next(1, nbrFaces + 1);
                    termsList.Add(randomNumber);
                    
                    dt.Rows[0][tst] = randomNumber;
                    somme = somme + randomNumber;
                   
                    if (min > randomNumber)
                    {
                        min = randomNumber;
                    }
                    if (max < randomNumber)
                    {
                        max = randomNumber;
                    }


                    
                }
                label1.Text = "min :" + min.ToString();
                label2.Text = "max :" + max.ToString();
                label3.Text = "somme :" + somme.ToString();
                label4.Text = "moyenne :" + (somme/nbrDé).ToString();
                System.Diagnostics.Debug.WriteLine(termsList);
                resultDeDtg.DataSource = dt;
                
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
