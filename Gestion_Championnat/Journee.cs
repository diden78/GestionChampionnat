using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Championnat
{
    class Journee
    {
        public DateTime Date { get; set; }
        public int Numero { get; set; }
        public List<Match> Matchs = new List<Match> { };

        public void addMatch(Match monMatch)
        {
            Matchs.Add(monMatch);
        }
    }
}
