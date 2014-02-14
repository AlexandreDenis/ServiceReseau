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

        public CoupeManager()
        {
            _manager = DalManager.GetInstance(DALProvider.SQLSERVER);
            //_manager = new DalManager();
        }

        /*renvoie toutes les coupes*/
        public List<Coupe> GetCoupes()
        {
            return _manager.GetAllCoupes();
        }

        /*renvoie tous les joueurs*/
        public List<Joueur> GetJoueurs()
        {
            return _manager.GetAllJoueurs();
        }

        /*renvoie toutes les équipes*/
        public List<Equipe> GetEquipes()
        {
            return _manager.GetAllEquipes();
        }

        /*renvoie tous les stades*/
        public List<Stade> GetStades()
        {
            return _manager.GetAllStades();
        }

        /*renvoie tous les matchs*/
        public List<Match> GetMatchs()
        {
            return _manager.GetAllMatchs();
        }

        /*renvoie l'utilisateur correspondant au login*/
        public Utilisateur GetUser(string inLogin)
        {
            return _manager.GetUtilsateurByLogin(inLogin);
        }

        public List<Reservation> GetReservations()
        {
            return _manager.GetAllReservations();
        }

        public Coupe GetCoupeById(int inId)
        {
            return _manager.GetCoupeById(inId);
        }

        /*retourne la liste des matchs prévus classés par date*/
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

        /*retourne la liste des stades pour lesquels au moins un match est programmé*/
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

        /*retourne la liste des attrapeurs qui ont joués à domicile*/
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

        /*verification du login et du mot de passe*/
        public bool checkConnexionUser(string inLogin, string inPassword)
        {
            bool res = false;
            Utilisateur user = GetUser(inLogin);

            if (user != null)
            {
                if (user.Password == inPassword)
                    res = true;
            }

            return res;
        }

        public List<Joueur> GetJoueursOfEquipe(int inEquipeId)
        {
            return _manager.GetJoueursOfEquipe(inEquipeId);
        }

        public void AjouterMatch(int inId, int inCoupeID, DateTime inDate, Equipe inDom, Equipe inVisiteur, double inPrix, int inSED, int inSEV, Stade inStade)
        {
            _manager.AjouterMatch(inId, inCoupeID, inDate, inDom, inVisiteur, inPrix, inSED, inSEV, inStade);
        }
    }
}
