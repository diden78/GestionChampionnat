using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Championnat
{
    class Arbitre : Personne
    {
        public Arbitre(string nom) : base(nom)
        {    
        }

        public Arbitre(string nom, string prenom) : base(nom, prenom)
        {   
        }

        public Arbitre(string nom, string prenom, DateTime dateDeNaiss) : base(nom, prenom, dateDeNaiss)
        {
        }
    }
}
