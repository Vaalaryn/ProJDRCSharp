using Jeu_de_role.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_de_role
{
    public partial class ChangeMDP : Form
    {

        private int id = 0;
        public ChangeMDP(int idUtil)
        {
            InitializeComponent();
            id = idUtil;
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void validate_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Task<string> result = Requetes.PostInfo(Properties.Settings.Default.SERVER + "/Utilisateur/UpdateUtilisateur", new List<AttributeModel>
                {
                    new AttributeModel("mdp", old_mdp.Text),
                    new AttributeModel("id", id),
                    new AttributeModel("newMdp", new_mdp.Text),
                    new AttributeModel("newMdpConfirm", conf_new_mdp.Text),
                });
                this.Invoke(new MethodInvoker(delegate
                {
                    this.Close();
                }));
            });
        }

        private void old_mdp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
