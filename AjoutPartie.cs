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
    public partial class AjoutPartie : Form
    {
        private string server = Properties.Settings.Default.SERVER.ToString();

        //Utilisateur
        private int IdUtilisateur = 0;
        private Menu menuLinked;

        public AjoutPartie(int idUtilisateur,Menu menu)
        {
            InitializeComponent();
            IdUtilisateur = idUtilisateur;
            menuLinked = menu;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTitle.Text) && !String.IsNullOrEmpty(txtDescription.Text))
            {
                string url = server + "/Partie/Ajouter";
                Task.Run(() =>
                {
                    Task<string> result = Requetes.PostInfo(url, new List<Models.AttributeModel>
                    {
                        new Models.AttributeModel("idUtilisateur",IdUtilisateur),
                        new Models.AttributeModel("titre",txtTitle.Text),
                        new Models.AttributeModel("description",txtDescription.Text)
                    });
                    result.Wait();
                    this.Invoke(new MethodInvoker(delegate
                    {
                        menuLinked.RefreshPartieList();
                        this.Close();
                    }));
                });

            }

        }
    }
}
