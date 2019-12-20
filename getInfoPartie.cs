using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_de_role.Classes
{
    class getInfoPartie
    {
        private string _id;
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }


        private string _titre;

        public string TITRE
        {
            get { return _titre; }
            set { _titre = value; }
        }

        private string _description;

        public string DESCRIPTION
        {
            get { return _description; }
            set { _description = value; }
        }

        private string[] _joueur;

        public string[] Joueur
        {
            get { return _joueur; }
            set { _joueur = value; }
        }

        private string _cp;

        public getInfoPartie()
        {

        }



        public getInfoPartie(string ID, string TITRE, string DESCRIPTION, string[] JOUEUR)

        {
            // on set les propriétés de la classe
            _id = ID;
            _titre = TITRE;
            _description = DESCRIPTION;
            _joueur = JOUEUR;

        }
    }
}
