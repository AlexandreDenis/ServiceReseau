﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntitiesLayer;

namespace DataAccessLayer
{
    /// <summary>
    /// Enumération des différents types de DataAccessLayer
    /// </summary>
    public enum DALProvider
    {
        SQLSERVER = 0,
        ORACLE
    }

    public class DalManager : IDal
    {
        private static DalManager _theUniqueInstance = null;

        /// <summary>
        /// DataAccessLayer
        /// </summary>
        private IDal _dal;
        public IDal DataAccessLayer
        {
            get { return _dal; }
            set { _dal = value; }
        }

        /// <summary>
        /// Constructeur de la classe DalManager
        /// </summary>
        /// <param name="provider">Type de DataAccessLayer</param>
        private DalManager(DALProvider provider)
        {
            string connexion = @"Data Source=jwdaec5gna.database.windows.net;Initial Catalog=QuidditchWorldCup;Integrated Security=False;User ID=QuidditchWorldCups@jwdaec5gna;Password=&aqwXSZ2;Connect Timeout=15;TrustServerCertificate=False";
            switch (provider)
            {
                case DALProvider.ORACLE:
                    break;
                case DALProvider.SQLSERVER:
                    DataAccessLayer = new DalSqlServer(connexion);
                    break;
            }
        }

        /// <summary>
        /// Singleton du DalManager
        /// </summary>
        /// <param name="provider">Type de DataAccessLayer</param>
        /// <returns>Instance unique du DalManager</returns>
        public static DalManager GetInstance(DALProvider provider)
        {
            if (_theUniqueInstance == null)
                _theUniqueInstance = new DalManager(provider);

            return _theUniqueInstance;
        }

        /// <summary>
        /// Renvoie toutes les coupes
        /// </summary>
        /// <returns>Liste des coupes</returns>
        public List<Coupe> GetAllCoupes()
        {
            return DataAccessLayer.GetAllCoupes();
        }

        /// <summary>
        /// Renvoie tous les joueurs
        /// </summary>
        /// <returns>Liste des joueurs</returns>
        public List<Joueur> GetAllJoueurs()
        {
            return DataAccessLayer.GetAllJoueurs();
        }

        /// <summary>
        /// Renvoie toutes les équipes
        /// </summary>
        /// <returns>Liste des équipes</returns>
        public List<Equipe> GetAllEquipes()
        {
            return DataAccessLayer.GetAllEquipes();
        }

        /// <summary>
        /// Renvoie tous les stades
        /// </summary>
        /// <returns>Liste des stades</returns>
        public List<Stade> GetAllStades()
        {
            return DataAccessLayer.GetAllStades();
        }

        /// <summary>
        /// Renvoie tous les matchs
        /// </summary>
        /// <returns>Liste des matchs</returns>
        public List<Match> GetAllMatchs()
        {
            return DataAccessLayer.GetAllMatchs();
        }

        public List<Spectateur> GetAllSpectators()
        {
            return DataAccessLayer.GetAllSpectators();
        }


        /// <summary>
        /// Renvoie tous les utilisateurs du programme
        /// </summary>
        /// <returns>Liste des utilisateurs</returns>
        public List<Utilisateur> GetAllUtilisateurs()
        {
            return DataAccessLayer.GetAllUtilisateurs();
        }

        /// <summary>
        /// Renvoie toutes les réservations
        /// </summary>
        /// <returns>Liste des réservations</returns>
        public List<Reservation> GetAllReservations()
        {
            return DataAccessLayer.GetAllReservations();
        }

        /// <summary>
        /// Renvoie la liste de tous les joueurs d'une équipe
        /// </summary>
        /// <param name="inEquipeId">Id de l'équipe pour laquelle on veut les joueurs</param>
        /// <returns>Liste des joueurs de l'équipe correspondante</returns>
        public List<Joueur> GetJoueursOfEquipe(int inEquipeId)
        {
            return DataAccessLayer.GetJoueursOfEquipe(inEquipeId);
        }

        /// <summary>
        /// Renvoie la liste des matchs correspondant à une coupe donnée
        /// </summary>
        /// <param name="inCoupeId">Id de la coupe dont on cherche les matchs</param>
        /// <returns>Liste des matchs correspondant</returns>
        public List<Match> GetMatchsOfCoupe(int inCoupeId)
        {
            return DataAccessLayer.GetMatchsOfCoupe(inCoupeId);
        }

        /// <summary>
        /// Renvoie l'utilisateur correspondant au login
        /// </summary>
        /// <param name="inLogin">Login à rechercher dans la base</param>
        /// <param name="inPassword">Mot de passe entré pour le login</param>
        /// <returns>Une instance d'utilisateur ou null</returns>
        public Utilisateur GetUtilsateurByLogin(string inLogin, string inPassword)
        {
            return DataAccessLayer.GetUtilsateurByLogin(inLogin,inPassword);
        }

        /// <summary>
        /// Renvoie la coupe associée à un Id
        /// </summary>
        /// <param name="inId">Id de la coupe à rechercher</param>
        /// <returns>Une instance de coupe ou null</returns>
        public Coupe GetCoupeById(int inId)
        {
            return DataAccessLayer.GetCoupeById(inId);
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
            DataAccessLayer.AjouterMatch(inCoupeID, inDate, inDom, inVisiteur, inPrix, inSED, inSEV, inStade);
        }

        /// <summary>
        /// Suppression d'un match de la BDD
        /// </summary>
        /// <param name="inId">Id du match à supprimer de la BDD</param>
        public void SupprimerMatch(int inId)
        {
            DataAccessLayer.SupprimerMatch(inId);
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
            DataAccessLayer.UpdateMatch( inId, inCoupeID, inDate, inDom, inVisiteur, inPrix, inSED, inSEV, inStade);
        }

        /// <summary>
        /// Création d'un utilisateur dans la base
        /// </summary>
        /// <param name="inLogin">Login de ce nouvel utilisateur</param>
        /// <param name="inPassword">Mot de passe de ce nouvel utilisateur</param>
        public void CreateUser(string inLogin, string inPassword)
        {
            DataAccessLayer.CreateUser(inLogin, inPassword);
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
            return DataAccessLayer.ReserverPlace(inMatchId, inNbPlaces, inSpectId);
        }

        /// <summary>
        /// Renvoie le match associé à un Id
        /// </summary>
        /// <param name="inId">Id du match à rechercher</param>
        /// <returns>Une instance de match ou null</returns>
        public Match GetMatchById(int inIdMatch)
        {
            return DataAccessLayer.GetMatchById(inIdMatch);
        }

        /// <summary>
        /// Renvoie le spectateur associé à un Id
        /// </summary>
        /// <param name="inId">Id du spectateur à rechercher</param>
        /// <returns>Une instance de spectateur ou null</returns>
        public Spectateur GetSpectateurById(int inIdSpec)
        {
            return DataAccessLayer.GetSpectateurById(inIdSpec);
        }

        /// <summary>
        /// Annulation d'une réservation
        /// </summary>
        /// <param name="inIdReservation">Identifiant de la réservation à annuler</param>
        public void AnnulerReservation(int inIdReservation)
        {
            DataAccessLayer.AnnulerReservation(inIdReservation);
        }

        /// <summary>
        /// Obtention d'une réservation via son identifiant
        /// </summary>
        /// <param name="inIdReservation">Identifiant de la réservation recherchée</param>
        /// <returns>Réservation correspondante</returns>
        public Reservation GetReservationById(int inIdReservation)
        {
            return DataAccessLayer.GetReservationById(inIdReservation);
        }
    
    }
}
