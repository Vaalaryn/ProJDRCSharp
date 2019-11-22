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
    public partial class CreationPartie: Form
    {
        public CreationPartie()
        {
            InitializeComponent();
        }

        private void CreateGameBtn_Click(object sender, EventArgs e)
        {
            dgvDescScenar.DataSource = null;
            dgvDescScenar.Refresh();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreationPartie_Load(object sender, EventArgs e)
        {

        }
    }
}
