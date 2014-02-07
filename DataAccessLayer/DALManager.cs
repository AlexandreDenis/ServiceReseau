using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntitiesLayer;

namespace DataAccessLayer
{
    public enum DALProvider
    {
        SQLSERVER = 0,
        ORACLE
    }

    public class DalManager : IDal
    {
        private static DalManager _theUniqueInstance = null;

        private IDal _dal;
        public IDal DataAccessLayer
        {
            get { return _dal; }
            set { _dal = value; }
        }

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

        public static DalManager GetInstance(DALProvider provider)
        {
            if (_theUniqueInstance == null)
                _theUniqueInstance = new DalManager(provider);

            return _theUniqueInstance;
        }

        public List<Coupe> GetAllCoupes()
        {
            return DataAccessLayer.GetAllCoupes();
        }

        public List<Joueur> GetAllJoueurs()
        {
            return DataAccessLayer.GetAllJoueurs();
        }

        public List<Equipe> GetAllEquipes()
        {
            return DataAccessLayer.GetAllEquipes();
        }

        public List<Stade> GetAllStades()
        {
            return DataAccessLayer.GetAllStades();
        }

        public List<Match> GetAllMatchs()
        {
            return DataAccessLayer.GetAllMatchs();
        }

        public List<Utilisateur> GetAllUtilisateurs()
        {
            return DataAccessLayer.GetAllUtilisateurs();
        }

        public List<Reservation> GetAllReservations()
        {
            return DataAccessLayer.GetAllReservations();
        }

        public Utilisateur GetUtilsateurByLogin(string inLogin)
        {
            return DataAccessLayer.GetUtilsateurByLogin(inLogin);
        }

        public Coupe GetCoupeById(int inId)
        {
            return DataAccessLayer.GetCoupeById(inId);
        }

        public void AjouterMatch(int inId, int inCoupeID, DateTime inDate, Equipe inDom, Equipe inVisiteur, double inPrix, int inSED, int inSEV, Stade inStade)
        {
            DataAccessLayer.AjouterMatch(inId, inCoupeID, inDate, inDom, inVisiteur, inPrix, inSED, inSEV, inStade);
        }

        public void SupprimerMatch(int inId)
        {
            DataAccessLayer.SupprimerMatch(inId);
        }

        public void UpdateMatch(int inId, int inCoupeID, DateTime inDate, Equipe inDom, Equipe inVisiteur, double inPrix, int inSED, int inSEV, Stade inStade)
        {
            DataAccessLayer.UpdateMatch(inId, inCoupeID, inDate, inDom, inVisiteur, inPrix, inSED, inSEV, inStade);
        }
    
    }
}
