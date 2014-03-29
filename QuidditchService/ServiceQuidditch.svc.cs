using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using BusinessLayer;
using EntitiesLayer;

namespace QuidditchService
{
    /// <summary>
    /// Web Service du projet
    /// </summary>
    public class ServiceQuidditch : IServiceQuidditch
    {
        /// <summary>
        /// Accès à la couche métier
        /// </summary>
        private CoupeManager _manager;

        /// <summary>
        /// Constructeur du web service
        /// </summary>
        public ServiceQuidditch ()
	    {
            _manager = new CoupeManager();
	    }

        /// <summary>
        /// Création d'un utilisateur dans la base
        /// </summary>
        /// <param name="inLogin">Login de ce nouvel utilisateur</param>
        /// <param name="inPassword">Mot de passe de ce nouvel utilisateur</param>
        public void CreateUser(string inLogin, string inPasswd)
        {
            _manager.CreateUser(inLogin, inPasswd);
        }

        /// <summary>
        /// Vérification du login et du mot de passe
        /// </summary>
        /// <param name="inLogin">Login à vérifier</param>
        /// <param name="inPassword">Mot de passe à vérifier</param>
        /// <returns>Booléen -> true si le mot de passe correspond bien au login entré, false sinon</returns>
        public bool CheckUser(string inLogin, string inPasswd)
        {
            return _manager.CheckConnexionUser(inLogin, inPasswd);
        }

        /// <summary>
        /// Renvoie toutes les coupes
        /// </summary>
        /// <returns>Liste des coupes</returns>
        public List<SCoupe> GetAllCoupes()
        {
            List<Coupe> coupes = _manager.GetCoupes();
            List<SCoupe> scoupes = new List<SCoupe>();

            foreach(Coupe cp in coupes)
            {
                scoupes.Add(new SCoupe(cp));
            }

            return scoupes;
        }

        /// <summary>
        /// Renvoie toutes les équipes
        /// </summary>
        /// <returns>Liste des équipes</returns>
        public List<SEquipe> GetAllEquipes()
        {
            List<Equipe> equipes = _manager.GetEquipes();
            List<SEquipe> sequipes = new List<SEquipe>();

            foreach (Equipe equ in equipes)
            {
                sequipes.Add(new SEquipe(equ));
            }

            return sequipes;
        }

        /// <summary>
        /// Renvoie la liste de tous les joueurs d'une équipe
        /// </summary>
        /// <param name="inEquipeId">Id de l'équipe pour laquelle on veut les joueurs</param>
        /// <returns>Liste des joueurs de l'équipe correspondante</returns>
        public List<SJoueur> GetJoueursOfEquipe(SEquipe inEquipe)
        {
            List<Joueur> joueurs = _manager.GetJoueursOfEquipe(inEquipe.Id);
            List<SJoueur> sjoueurs = new List<SJoueur>();

            foreach (Joueur jou in joueurs)
            {
                sjoueurs.Add(new SJoueur(jou));
            }

            return sjoueurs;
        }

        /// <summary>
        /// Renvoie tous les stades
        /// </summary>
        /// <returns>Liste des stades</returns>
        public List<SStade> GetAllStades()
        {
            List<Stade> stades = _manager.GetStades();
            List<SStade> sstades = new List<SStade>();

            foreach (Stade sta in stades)
            {
                sstades.Add(new SStade(sta));
            }

            return sstades;
        }

        /// <summary>
        /// Renvoie tous les matchs d'une coupe
        /// </summary>
        /// <returns>Liste des matchs de la coupe</returns>
        public List<SMatch> GetMatchsOfCoupe(SCoupe inCoupe)
        {
            List<Match> matchs = _manager.GetMatchs();
            List<SMatch> smatchs = new List<SMatch>();

            foreach (Match mat in matchs)
            {
                if(mat.CoupeId == inCoupe.Id)
                    smatchs.Add(new SMatch(mat));
            }

            return smatchs;
        }

        /// <summary>
        /// Renvoie l'utilisateur correspondant au login
        /// </summary>
        /// <param name="inLogin">Login à rechercher dans la base</param>
        /// <param name="inPassword">Mot de passe entré pour le login</param>
        /// <returns>Une instance d'utilisateur ou null</returns>
        public SUtilisateur GetUtilisateur(string inLogin, string inPassword)
        {
            Utilisateur user = _manager.GetUser(inLogin, inPassword);
            SUtilisateur suser = null;

            if (user != null)
            {
                suser = new SUtilisateur(user.Nom, user.Prenom, user.Login, user.Password);
            }

            return suser;
        }

        /// <summary>
        /// Renvoie le match associé à un Id
        /// </summary>
        /// <param name="inId">Id du match à rechercher</param>
        /// <returns>Une instance de match ou null</returns>
        public SMatch GetMatchById(int inIdMatch)
        {
            return new SMatch(_manager.GetMatchById(inIdMatch));
        }

        /// <summary>
        /// Renvoie le spectateur associé à un Id
        /// </summary>
        /// <param name="inId">Id du spectateur à rechercher</param>
        /// <returns>Une instance de spectateur ou null</returns>
        public SSpectateur GetSpectateurById(int inIdSpec)
        {
            return new SSpectateur(_manager.GetSpectateurById(inIdSpec));
        }

        /// <summary>
        /// Réservation de places dans la base de données
        /// </summary>
        /// <param name="inMatchId">Identifiant du match pour lequel effectuer les réservations</param>
        /// <param name="inNbPlaces">Nombre de places à réserver</param>
        /// <param name="inSpectId">Identifiant du spectateur qui effectue la réservation</param>
        /// <returns>Identifiant de la réservation effectuée</returns>
        public int ReserverPlaces(int inMatchId, int inNbPlaces, int inSpectId)
        {
            return _manager.ReserverPlace(inMatchId, inNbPlaces, inSpectId);
        }

        /// <summary>
        /// Renvoie tous les matchs
        /// </summary>
        /// <returns>Liste des matchs</returns>
        public List<SMatch> GetAllMatchs()
        {
            List<Match> matchs = _manager.GetMatchs();
            List<SMatch> smatchs = new List<SMatch>();

            foreach (Match mat in matchs)
            {
                smatchs.Add(new SMatch(mat));
            }

            return smatchs;
        }

        /// <summary>
        /// Renvoie tous les spectateurs
        /// </summary>
        /// <returns>Liste des spectateurs</returns>
        public List<SSpectateur> GetAllSpectators()
        {
            List<Spectateur> spectateurs = _manager.GetSpectators();
            List<SSpectateur> sspectateurs = new List<SSpectateur>();

            foreach (Spectateur spe in spectateurs)
            {
                sspectateurs.Add(new SSpectateur(spe));
            }

            return sspectateurs;
        }

        /// <summary>
        /// Renvoie toutes les réservations
        /// </summary>
        /// <returns>Liste des réservations</returns>
        public List<SReservation> GetAllReservations()
        {
            List<Reservation> reservations = _manager.GetReservations();
            List<SReservation> sreservations = new List<SReservation>();

            foreach (Reservation res in reservations)
            {
                sreservations.Add(new SReservation(res));
            }

            return sreservations;
        }

        /// <summary>
        /// Annulation d'une réservation
        /// </summary>
        /// <param name="inIdReservation">Identifiant de la réservation à annuler</param>
        public void AnnulerReservation(int inIdReservation)
        {
            _manager.AnnulerReservation(inIdReservation);
        }

        /// <summary>
        /// Obtention d'une réservation via son identifiant
        /// </summary>
        /// <param name="inIdReservation">Identifiant de la réservation recherchée</param>
        /// <returns>Réservation correspondante</returns>
        public SReservation GetReservationById(int inIdReservation)
        {
            Reservation res = _manager.GetReservationById(inIdReservation);
            SReservation sres = null;
            if(res != null)
                sres = new SReservation(res);

            return sres;
        }
    }
}
