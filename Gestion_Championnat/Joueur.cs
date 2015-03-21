using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Championnat
{
    public class Joueur : Personne
    {
        public string poste { get; set; }

        public Joueur(string nom) : base(nom)
        {    
        }

        public Joueur(string nom, string prenom) : base(nom, prenom)
        {   
        }

        public Joueur(string nom, string prenom, DateTime dateDeNaiss) : base(nom, prenom, dateDeNaiss)
        {
        }
        public Joueur(string nom, string prenom, DateTime dateDeNaiss, string poste) : base(nom, prenom, dateDeNaiss)
        {
            if (poste == null)
            {
                throw new ArgumentOutOfRangeException("poste", poste, "Le poste ne doit pas être nul ou vide");
            }
        }
    }
}
