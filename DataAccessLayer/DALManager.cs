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
            return null;
        }

        public List<Equipe> GetAllEquipes()
        {
            return null;
        }

        public List<Stade> GetAllStades()
        {
            return null;
        }

        public List<Match> GetAllMatchs()
        {
            return null;
        }

        public List<Utilisateur> GetAllUtilisateurs()
        {
            return null;
        }

        public List<Reservation> GetAllReservations()
        {
            return null;
        }

        public Utilisateur GetUtilsateurByLogin(string inLogin)
        {
            return null;
        }

        public Coupe GetCoupeById(int inId)
        {
            return null;
        }
    }
}
