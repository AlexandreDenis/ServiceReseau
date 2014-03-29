using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntitiesLayer;
using DataAccessLayer;
//using StubDataAccessLayer;

namespace BusinessLayer
{
    public class CoupeManager
    {
        DalManager _manager;

        /// <summary>
        /// Constructeur de la classe CoupeManager
        /// </summary>
        public CoupeManager()
        {
            _manager = DalManager.GetInstance(DALProvider.SQLSERVER);
            //_manager = new DalManager();
        }

        /// <summary>
        /// Renvoie toutes les coupes
        /// </summary>
        /// <returns>Liste des coupes</returns>
        public List<Coupe> GetCoupes()
        {
            return _manager.GetAllCoupes();
        }

        /// <summary>
        /// Renvoie tous les joueurs
        /// </summary>
        /// <returns>Liste des joueurs</returns>
        public List<Joueur> GetJoueurs()
        {
            return _manager.GetAllJoueurs();
        }

        /// <summary>
        /// Renvoie toutes les équipes
        /// </summary>
        /// <returns>Liste des équipes</returns>
        public List<Equipe> GetEquipes()
        {
            return _manager.GetAllEquipes();
        }

        /// <summary>
        /// Renvoie tous les stades
        /// </summary>
        /// <returns>Liste des stades</returns>
        public List<Stade> GetStades()
        {
            return _manager.GetAllStades();
        }

        /// <summary>
        /// Renvoie tous les matchs
        /// </summary>
        /// <returns>Liste des matchs</returns>
        public List<Match> GetMatchs()
        {
            return _manager.GetAllMatchs();
        }

        /// <summary>
        /// Renvoie tous les spectateurs
        /// </summary>
        /// <returns>Liste des spectateurs</returns>
        public List<Spectateur> GetSpectators()
        {
            return _manager.GetAllSpectators();
        }

        /// <summary>
        /// Renvoie l'utilisateur correspondant au login
        /// </summary>
        /// <param name="inLogin">Login à rechercher dans la base</param>
        /// <param name="inPassword">Mot de passe entré pour le login</param>
        /// <returns>Une instance d'utilisateur ou null</returns>
        public Utilisateur GetUser(string inLogin, string inPassword)
        {
            return _manager.GetUtilsateurByLogin(inLogin, inPassword);
        }

        /// <summary>
        /// Renvoie toutes les réservations
        /// </summary>
        /// <returns>Liste des réservations</returns>
        public List<Reservation> GetReservations()
        {
            return _manager.GetAllReservations();
        }

        /// <summary>
        /// Renvoie la coupe associée à un Id
        /// </summary>
        /// <param name="inId">Id de la coupe à rechercher</param>
        /// <returns>Une instance de coupe ou null</returns>
        public Coupe GetCoupeById(int inId)
        {
            return _manager.GetCoupeById(inId);
        }

        /// <summary>
        /// Retourne la liste des matchs prévus classés par date
        /// </summary>
        /// <param name="inCoupeID">Id de la coupe des matchs à rechercher</param>
        /// <returns>Liste des matchs correspondante</returns>
        public List<Match> GetListeMatchsCoupe(int inCoupeID)
        {
            List<Match> result = new List<Match>();
            List<Match> matchs = this.GetMatchs();

            if (matchs != null)
            {
                result = (from x in matchs
                          where x.CoupeId == inCoupeID
                          orderby x.Date
                          select x).ToList();
            }

            if (result.Count == 0)
                result = null;

            return result;
        }

        /// <summary>
        /// Retourne la liste des stades pour lesquels au moins un match est programmé
        /// </summary>
        /// <param name="inCoupeID">Id de la coupe sur laquelle doit être effectuée la recherche</param>
        /// <returns>Liste des chaînes de caractères représentant chacun des stades correspondant</returns>
        public List<string> GetListeStades(int inCoupeID)
        {
            List<string> result = new List<string>();

            List<Match> matchs = this.GetMatchs();

            if (matchs != null)
            {
                result = (from x in matchs
                           where x.CoupeId == inCoupeID
                           orderby x.Stade.Id
                           select x.Stade.ToString()).Distinct().ToList();
            }

            if (result.Count == 0)
                result = null;

            return result;
        }

        /// <summary>
        /// Retourne la liste des attrapeurs qui ont joués à domicile
        /// </summary>
        /// <param name="coupeID">Id de la coupe sur laquelle doit être effectuée la recherche</param>
        /// <returns>Liste des chaînes de caractères représentant chacun des joueurs correspondant</returns>
        public List<string> GetListeAttrapeursDomicile(int coupeID)
        {
            List<string> result = new List<string>();
            List<Match> matches = GetMatchs();

            if (matches != null)
            {
                result = (from x in matches
                           from y in x.EquipeDomicile.Joueurs
                           where x.CoupeId == coupeID && y.Poste == PosteJoueur.Attrapeur
                           orderby y.Nom
                           select y.ToString() + " => " + x.EquipeDomicile.ToString()).Distinct().ToList();
            }

            if (result.Count == 0)
                result = null;

            return result;
        }

        /// <summary>
        /// Vérification du login et du mot de passe
        /// </summary>
        /// <param name="inLogin">Login à vérifier</param>
        /// <param name="inPassword">Mot de passe à vérifier</param>
        /// <returns>Booléen -> true si le mot de passe correspond bien au login entré, false sinon</returns>
        public bool CheckConnexionUser(string inLogin, string inPassword)
        {
            bool res = false;
            Utilisateur user = GetUser(inLogin,inPassword);

            if (user != null)
            {
                if (user.Password == inPassword)
                    res = true;
            }

            return res;
        }

        /// <summary>
        /// Renvoie la liste de tous les joueurs d'une équipe
        /// </summary>
        /// <param name="inEquipeId">Id de l'équipe pour laquelle on veut les joueurs</param>
        /// <returns>Liste des joueurs de l'équipe correspondante</returns>
        public List<Joueur> GetJoueursOfEquipe(int inEquipeId)
        {
            return _manager.GetJoueursOfEquipe(inEquipeId);
        }

        /// <summary>
        /// Renvoie la liste des matchs correspondant à une coupe donnée
        /// </summary>
        /// <param name="inCoupeId">Id de la coupe dont on cherche les matchs</param>
        /// <returns>Liste des matchs correspondant</returns>
        public List<Match> GetMatchsOfCoupe(int inCoupeId)
        {
            return _manager.GetMatchsOfCoupe(inCoupeId);
        }

        /// <summary>
        /// Ajout d'un match dans la BDD
        /// </summary>
        /// <param name="inCoupeID">Id de la coupe du match</param>
        /// <param name="inDate">Date du match</param>
        /// <param name="inDom">Equipe à domicile</param>
        /// <param name="inVisiteur">Equipe visiteur</param>
        /// <param name="inPrix">Prix des places pour le match</param>
        /// <param name="inSED">Score de l'équipe à domicile</param>
        /// <param name="inSEV">Score de l'équipe extérieure</param>
        /// <param name="inStade">Stade du match</param>
        public void AjouterMatch(int inCoupeID, DateTime inDate, Equipe inDom, Equipe inVisiteur, double inPrix, int inSED, int inSEV, Stade inStade)
        {
            _manager.AjouterMatch(inCoupeID, inDate, inDom, inVisiteur, inPrix, inSED, inSEV, inStade);
        }

        /// <summary>
        /// Suppression d'un match de la BDD
        /// </summary>
        /// <param name="inId">Id du match à supprimer de la BDD</param>
        public void SupprimerMatch(int inId)
        {
            _manager.SupprimerMatch(inId);
        }

        /// <summary>
        /// Mise à jour des informations sur un match dans la BDD
        /// </summary>
        /// <param name="inCoupeID">Id de la coupe du match</param>
        /// <param name="inDate">Date du match</param>
        /// <param name="inDom">Equipe à domicile</param>
        /// <param name="inVisiteur">Equipe visiteur</param>
        /// <param name="inPrix">Prix des places pour le match</param>
        /// <param name="inSED">Score de l'équipe à domicile</param>
        /// <param name="inSEV">Score de l'équipe extérieure</param>
        /// <param name="inStade">Stade du match</param>
        public void UpdateMatch(int inId, int inCoupeID, DateTime inDate, Equipe inDom, Equipe inVisiteur, double inPrix, int inSED, int inSEV, Stade inStade)
        {
            _manager.UpdateMatch(inId, inCoupeID, inDate, inDom, inVisiteur, inPrix, inSED, inSEV, inStade);
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
        /// Réservation de places dans la base de données
        /// </summary>
        /// <param name="inMatchId">Identifiant du match pour lequel effectuer les réservations</param>
        /// <param name="inNbPlaces">Nombre de places à réserver</param>
        /// <param name="inSpectId">Identifiant du spectateur qui effectue la réservation</param>
        /// <returns>Identifiant de la réservation effectuée</returns>
        public int ReserverPlace(int inMatchId, int inNbPlaces, int inSpectId)
        {
            return _manager.ReserverPlace(inMatchId, inNbPlaces, inSpectId);
        }

        /// <summary>
        /// Renvoie le match associé à un Id
        /// </summary>
        /// <param name="inId">Id du match à rechercher</param>
        /// <returns>Une instance de match ou null</returns>
        public Match GetMatchById(int inIdMatch)
        {
            return _manager.GetMatchById(inIdMatch);
        }

        /// <summary>
        /// Renvoie le spectateur associé à un Id
        /// </summary>
        /// <param name="inId">Id du spectateur à rechercher</param>
        /// <returns>Une instance de spectateur ou null</returns>
        public Spectateur GetSpectateurById(int inSpectId)
        {
            return _manager.GetSpectateurById(inSpectId);
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
        public Reservation GetReservationById(int inIdReservation)
        {
            return _manager.GetReservationById(inIdReservation);
        }
    }
}
