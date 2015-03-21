using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Championnat
{
    class Equipe
    {
        public string NomEquipe { get; set; }
        public string Ville { get; set; }
        public string NomStade { get; set; }
        public List<Joueur> Joueurs = new List<Joueur> { };
        public Entraineur entraineur { get; set; }


        public Equipe(string nom)
        {
            if (nom == null)
            {
                throw new ArgumentOutOfRangeException("nom", nom, "Le nom de la ville ne doit pas être nul ou vide");
            }

            NomEquipe = nom;
        }

        public Equipe(string nom, string ville): this(nom)
        {
            if (ville == null)
            {
                throw new ArgumentOutOfRangeException("Ville", Ville, "Le nom de la ville ne doit pas être nul ou vide");
            }
            Ville = ville;
        }

        public Equipe(string nom, string ville, string stade)
            : this(nom, ville)
        {
            if (stade == null)
            {
                throw new ArgumentOutOfRangeException("stade", stade, "Le nom du stade ne doit pas être nul ou vide");
            }
            NomStade = stade;
        }
        public void addJoueur(Joueur monJoueur)
        {
            Joueurs.Add(monJoueur);
        }



        //public void addJoueur(string nom)
        //{
        //    Joueur joueur = new Joueur(nom);
        //    Joueurs.Add(joueur);
        //}
        //public void addJoueur(string nom, string prenom)
        //{
        //    Joueur joueur = new Joueur(nom, prenom);
        //    Joueurs.Add(joueur);
        //}
        //public void addJoueur(string nom, string prenom, DateTime dateDeNaiss)
        //{
        //    Joueur joueur = new Joueur(nom, prenom, dateDeNaiss);
        //    Joueurs.Add(joueur);
        //}
        //public void addJoueur(string nom, string prenom, DateTime dateDeNaiss, string poste)
        //{
        //    Joueur joueur = new Joueur(nom, prenom, dateDeNaiss, poste);
        //    Joueurs.Add(joueur);
        //}


        //public void setEntraineur(string nom)
        //{
        //    entraineur = new Entraineur(nom);
        //}
        //public void setEntraineur(string nom, string prenom)
        //{
        //    entraineur = new Entraineur(nom, prenom);
        //}
        //public void setEntraineur(string nom, string prenom, DateTime dateDeNaiss)
        //{
        //    entraineur = new Entraineur(nom, prenom, dateDeNaiss);
        //}


    }
}
