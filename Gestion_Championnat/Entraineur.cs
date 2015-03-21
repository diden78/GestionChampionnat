using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Championnat
{
    class Entraineur : Personne
    {
        public Entraineur(string nom) : base(nom)
        {    
        }

        public Entraineur(string nom, string prenom) : base(nom, prenom)
        {   
        }

        public Entraineur(string nom, string prenom, DateTime dateDeNaiss) : base(nom, prenom, dateDeNaiss)
        {
        }
    }
}
