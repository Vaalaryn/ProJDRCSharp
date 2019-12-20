using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_de_role.Classes
{
    class getFichePerso
    {
        private string _id;
        public string ID_CLASSE
        {
            get { return _id; }
            set { _id = value; }
        }


        private string _nom;

        public string NOM
        {
            get { return _nom; }
            set { _nom = value; }
        }

        private string _prenom;

        public string PRENOM
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        public bool _age;

        public bool VIVANT
        {
            get { return _age; }
            set { _age = value; }
        }

        private string _adresse;

        public string DESCRIPTION
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        private string _cp;

        public string VIE
        {
            get { return _cp; }
            set { _cp = value; }
        }

        private string _ville;

        public string MANA
        {
            get { return _ville; }
            set { _ville = value; }
        }

        private string _login;

        public string EXPERIENCE
        {
            get { return _login; }
            set { _login = value; }
        }

        private string _mdp;

        public string NIVEAU
        {
            get { return _mdp; }
            set { _mdp = value; }
        }

        public getFichePerso()
        {

        }



        public getFichePerso(string ID_CLASSE, string NOM, string PRENOM, bool VIVANT, string DESCRIPTION, string VIE, string MANA,
            string EXPERIENCE, string NIVEAU)

        {
            // on set les propriétés de la classe
            _id = ID_CLASSE;
            _nom = NOM;
            _prenom = PRENOM;
            _age = VIVANT;
            _adresse = DESCRIPTION;
            _cp = VIE;
            _ville = MANA;
            _login = EXPERIENCE;
            _mdp = NIVEAU;

        }
    }
}
