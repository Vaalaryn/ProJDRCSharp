using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_de_role.Models
{
    public class PartieModel
    {
        public string ID_PARTIE { get; set; }
        public string TITRE { get; set; }
        public string DESCRIPTION_PARTIE { get; set; }
        public bool ISMJ { get; set; }
        public int ID_JOUEUR { get; set; }
    }
}
