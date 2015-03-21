using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Championnat
{
    class Match
    {
        public int Id { get; set; }
        public Equipe Equipe_A_Dom{ get; set; }
        public Equipe Equipe_Visit{ get; set; }
        public Arbitre ArbitreDuMatch { get; set; }
        public string LieuMatch ="Non défini";
        public string LieuStade ="Non défini";

        public Match( Equipe domicile, Equipe visiteur)
        {
            Equipe_A_Dom = domicile;
            Equipe_Visit = visiteur;
            if (domicile.Ville != null)
            {
                LieuMatch = domicile.Ville; 
            }
            if (domicile.NomStade != null)
            {
                LieuStade = domicile.NomStade;  
            }
            
        }

    }
}
