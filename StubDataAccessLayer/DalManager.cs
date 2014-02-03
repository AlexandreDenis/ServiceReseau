using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;

namespace StubDataAccessLayer
{
    public class DalManager
    {
        public List<Joueur> GetAllJoueurs()
        {
            List<Joueur> joueurs = new List<Joueur>();

            //Joueurs de l'equipe de Gryffondor
            joueurs.Add(new Joueur(0, "Daval", "Olivier", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(1, "Thuillier", "André", DateTime.Now, PosteJoueur.Attrapeur, 2, 3));
            joueurs.Add(new Joueur(2, "Perrier", "Kevin", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(3, "Lagrange", "Pascal", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(4, "Lebert", "Charles", DateTime.Now, PosteJoueur.Batteur, 2, 3));
            joueurs.Add(new Joueur(5, "Caillaud", "Claude", DateTime.Now, PosteJoueur.Batteur, 2, 3));
            joueurs.Add(new Joueur(6, "Despres", "Anthony", DateTime.Now, PosteJoueur.Gardien, 2, 3));

            //Joueurs de l'equipe de Serdaigle
            joueurs.Add(new Joueur(7, "Rubio", "Jean-Marie", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(8, "Leclerc", "François", DateTime.Now, PosteJoueur.Attrapeur, 2, 3));
            joueurs.Add(new Joueur(9, "Menu", "Jean-Paul", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(10, "Rossignol", "Damien", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(11, "Savy", "Lionel", DateTime.Now, PosteJoueur.Batteur, 2, 3));
            joueurs.Add(new Joueur(12, "Ribeiro", "Michel", DateTime.Now, PosteJoueur.Batteur, 2, 3));
            joueurs.Add(new Joueur(13, "Drouot", "Yannick", DateTime.Now, PosteJoueur.Gardien, 2, 3));

            //Joueurs de l'equipe de Serpentard
            joueurs.Add(new Joueur(14, "Menager", "Sylvain", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(15, "Mayer", "Emmanuel", DateTime.Now, PosteJoueur.Attrapeur, 2, 3));
            joueurs.Add(new Joueur(16, "Casanova", "Raymond", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(17, "Clavier", "Georges", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(18, "Bordier", "Guillaume", DateTime.Now, PosteJoueur.Batteur, 2, 3));
            joueurs.Add(new Joueur(19, "Voisin", "Loïc", DateTime.Now, PosteJoueur.Batteur, 2, 3));
            joueurs.Add(new Joueur(20, "Braun", "Mickaël", DateTime.Now, PosteJoueur.Gardien, 2, 3));

            return joueurs;
        }

        public List<Equipe> GetAllEquipes()
        {
            List<Equipe> equipes = new List<Equipe>();
            List<Joueur> joueurs = GetAllJoueurs();
            int i;

            Equipe e1 = new Equipe(21, "Gryffondor", "Grande-Bretagne");
            for (i = 0; i < 7; i++)
            {
                e1.AddJoueur(joueurs[i]);
            }

            Equipe e2 = new Equipe(22, "Serdaigle", "France");
            for (i = 7; i < 14; i++)
            {
                e2.AddJoueur(joueurs[i]);
            }

            Equipe e3 = new Equipe(23, "Poussoufle", "Bulgarie");
            for (i = 14; i < 21; i++)
            {
                e3.AddJoueur(joueurs[i]);
            }

            equipes.Add(e1);
            equipes.Add(e2);
            equipes.Add(e3);

            return equipes;
        }

        public List<Stade> GetAllStades()
        {
            List<Stade> stades = new List<Stade>();

            stades.Add(new Stade(24, "Poudlard", "5 rue du hibou", 500, 15.3));
            stades.Add(new Stade(25, "World Cup Stadium", "47 impasse du balai", 2000, 20.20));

            return stades;
        }

        public List<Match> GetAllMatchs()
        {
            List<Equipe> equipes = GetAllEquipes();
            List<Stade> stades = GetAllStades();

            List<Match> matchs = new List<Match>();

            matchs.Add(new Match(30, 33, new DateTime(2014, 2, 18), equipes[0], equipes[1], 25.2, 0, 0, stades[0]));
            matchs.Add(new Match(31, 34, new DateTime(2014, 6, 25), equipes[1], equipes[2], 100.25, 0, 0, stades[1]));
            matchs.Add(new Match(32, 34, new DateTime(2015, 7, 21), equipes[2], equipes[0], 102, 0, 0, stades[1]));

            return matchs;
        }

        public List<Coupe> GetAllCoupes()
        {
            List<Coupe> coupes = new List<Coupe>();

            coupes.Add(new Coupe(33, 2013, "Coupe des nations"));
            coupes.Add(new Coupe(34, 2014, "Coupe des régions"));

            return coupes;
        }

        public List<Utilisateur> GetAllUtilisateurs()
        {
            List<Utilisateur> utilisateurs = new List<Utilisateur>();

            utilisateurs.Add(new Utilisateur("Denis","Alexandre","alec","mdpalec"));
            utilisateurs.Add(new Utilisateur("Calime","Adrien","adrien","mdpadrien"));

            return utilisateurs;
        }

        public List<Reservation> GetAllReservations()
        {
            List<Reservation> reservations = new List<Reservation>();
            List<Match> matchs = GetAllMatchs();

            reservations.Add(new Reservation(35, matchs[0], 7, new Spectateur(36, "Weasley", "Ronald", new DateTime(1990, 7, 14), "5 rue des hiboux", "ron.weasley@gmail.com")));
            reservations.Add(new Reservation(37, matchs[1], 2, new Spectateur(38, "Potter", "Harry", new DateTime(1991, 6, 8), "28 impasse du chaudron", "harry.potter@gmail.com")));
            reservations.Add(new Reservation(39, matchs[1], 1, new Spectateur(40, "Granger", "Hermione", new DateTime(1989, 2, 25), "9 avenue Dumbledore", "hermione.granger@gmail.com")));

            return reservations;
        }

        public Utilisateur GetUtilsateurByLogin(string inLogin)
        {
            Utilisateur utilReturn = null;
            foreach (Utilisateur utilisateur in GetAllUtilisateurs())
            {
                if (utilisateur.Login.Equals(inLogin))
                {
                    utilReturn = utilisateur;
                    break;
                }
            }

            return utilReturn;
        }

        public Coupe GetCoupeById(int inId)
        {
            Coupe coupeReturn = null;
            foreach (Coupe coupe in GetAllCoupes())
            {
                if (coupe.Id == inId)
                {
                    coupeReturn = coupe;
                    break;
                }
            }

            return coupeReturn;
        }
    }
}
