using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Championnat 
{
    class Championnat : IComparer<Equipe>
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
            if (nbEqu == 0)
            {
                throw new ArgumentOutOfRangeException("nombre d'équipes", nbEqu, "Le nombre d'équipes ne doit pas être nul ou vide");
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

        public int Compare(Equipe A, Equipe B)
        {
            if (A.NombrePoints.CompareTo(B.NombrePoints) == 0)
            {
                if (A.DiffDeButs.CompareTo(B.DiffDeButs) == 0)
                {
                    return A.NomEquipe.CompareTo(B.NomEquipe);
                } return A.DiffDeButs.CompareTo(B.DiffDeButs);
            } return A.NombrePoints.CompareTo(B.NombrePoints);
        }

        public void actualiserClassement()
        {
            foreach (var monEquipe in Equipes)
            {
                monEquipe.calculDiffDeButs();
                monEquipe.calculNombrePoints();
            }

        }
    }
}
