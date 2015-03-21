using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Championnat
{
    class Championnat
    {
        
        public string Saison { get; set; }
        public string Division { get; set; }
        public int nombreEquipes;


        public List<Equipe> Equipes { get; set; }
        public List<Journee> Calendrier { get; set; }

        public Championnat(string saison, string division, int nbEqu)
        {
            if (saison == null)
            {
                throw new ArgumentOutOfRangeException("saison", saison, "La saison ne doit pas être nulle ou vide");
            }
            if (division == null)
            {
                throw new ArgumentOutOfRangeException("division", division, "La division ne doit pas être nulle ou vide");
            }
            if (nbEqu == null)
            {
                throw new ArgumentOutOfRangeException("nombre d'équipes", nbEqu, "Le nombre d'équipes ne doit pas être nulle ou vide");
            }
            Saison = saison;
            Division = division;
            nombreEquipes = nbEqu;
        }

        public void addEquipe(Equipe monEquipe)
        {
            Equipes.Add(monEquipe);
        }

        public void addJournee(Journee maJournee)
        {
            Calendrier.Add(maJournee);
        }
    }
}
