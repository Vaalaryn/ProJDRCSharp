using Jeu_de_role.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_de_role
{
    public partial class ChangePseudo : Form
    {
        private int id = 0;
        public ChangePseudo(int idUtil)
        {
            InitializeComponent();
            id = idUtil;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mdp.Text != "" && pseudo.Text != "")
            {
                Task.Run(() =>
                {
                    Task<string> result = Requetes.PostInfo(Properties.Settings.Default.SERVER + "/Utilisateur/UpdateUtilisateur", new List<AttributeModel>
                {
                    new AttributeModel("mdp", mdp.Text),
                    new AttributeModel("id", id),
                    new AttributeModel("newPseudo", pseudo.Text),
                });
                    this.Invoke(new MethodInvoker(delegate
                    {
                        this.Close();
                    }));
                });
            }
            else
            {
                MessageBox.Show("Champs vide");
            }
        }
    }
}
