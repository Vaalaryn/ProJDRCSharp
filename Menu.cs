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
using Newtonsoft.Json;
using System.IO;

namespace Jeu_de_role
{
    public partial class Menu : Form
    {
        //Adresse du serveur
        private string server = Properties.Settings.Default.SERVER.ToString();

        private Profil profil = new Profil();
       
        public Menu()
        {
            InitializeComponent();
        }




        private void userInfoBtn_Click(object sender, EventArgs e)
        {
            profil.ShowDialog();
        }

        //Changement d'un fichier
        private void Watcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            using (StreamReader sr = new StreamReader(e.FullPath))
            {
                string line;
                // Read and display lines from the file until the end of 
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    // Ajoute dans la base de données les données de la ligne.
                    MessageBox.Show(line);
                }
            }
        }
    }
}
