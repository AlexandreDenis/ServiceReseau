using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public enum DALProvider
    {
        SQLSERVER = 0,
        ORACLE
    }

    class DALManager : IDAL
    {
        private static DALManager _theUniqueInstance = null;

        private IDAL _dal;
        public IDAL DataAccessLayer
        {
            get { return _dal; }
            set { _dal = value; }
        }

        private DALManager(DALProvider provider)
        {
            string connexion = @"Data Source=jwdaec5gna.database.windows.net;Initial Catalog=QuidditchWorldCup;Integrated Security=False;User ID=QuidditchWorldCups@jwdaec5gna;Password=&aqwXSZ2;Connect Timeout=15;TrustServerCertificate=False";
            switch (provider)
            {
                case DALProvider.ORACLE:
                    break;
                case DALProvider.SQLSERVER:
                    DataAccessLayer = new DALSqlServer(connexion);
                    break;
            }
        }

        public static DALManager GetInstance(DALProvider provider)
        {
            if (_theUniqueInstance == null)
                _theUniqueInstance = new DALManager(provider);

            return _theUniqueInstance;
        }
        
    }
}
