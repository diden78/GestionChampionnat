using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Championnat
{
    public class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Date_De_Naiss { get; set; }


        public Personne(string nom){
            if (nom == null)
            {
                throw new ArgumentOutOfRangeException("nom", nom, "Le nom ne doit pas être nul ou vide");
            }

            Nom = nom;
        }
        
        public Personne(string nom, string prenom) : this(nom)
        {
            if (prenom == null)
            {
                throw new ArgumentOutOfRangeException("prenom", prenom, "Le prenom ne doit pas être nul ou vide");
            }
            Prenom = prenom;

        }

        public Personne(string nom, string prenom, DateTime dateDeNaiss) : this(nom, prenom)
        {
            if (dateDeNaiss == null)
            {
                throw new ArgumentOutOfRangeException("dateDeNaiss", dateDeNaiss, "La date de naissance ne doit pas être nulle ou vide");
            }
            Date_De_Naiss = dateDeNaiss;
        }

    }
}
