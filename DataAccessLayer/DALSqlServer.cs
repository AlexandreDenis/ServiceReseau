using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntitiesLayer;

namespace DataAccessLayer
{
    public class DalSqlServer : IDal
    {
        private string _connectionString;

        public DalSqlServer(string inConnexion)
        {
            _connectionString = inConnexion;
        }

        private DataTable SelectByAdapter(string request)
        {
            DataTable results = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(request, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(results);
            }

            return results;
        }

        public List<Coupe> GetAllCoupes()
        {
            string request = "select * from Coupes;";
            DataTable dataTable = SelectByAdapter(request);
            List<Coupe> result = new List<Coupe>();
            int inId;
            int inYear;
            string inLibelle;

            foreach (DataRow row in dataTable.Rows)
            {
                inId = (int)row[dataTable.Columns[0].ColumnName];
                inYear = (int)row[dataTable.Columns[1].ColumnName];
                inLibelle = row[dataTable.Columns[2].ColumnName].ToString();

                result.Add(new Coupe(inId, inYear, inLibelle));
            }

            return result;
        }

        public List<Joueur> GetAllJoueurs()
        {
            string request = "select * from Joueurs;";
            DataTable dataTable = SelectByAdapter(request);
            List<Joueur> result = new List<Joueur>();
            int inId;
            string inNom;
            string inPrenom;
            DateTime inDateNaiss;
            PosteJoueur inPoste;
            int inSelection;
            int inScore;

            foreach (DataRow row in dataTable.Rows)
            {
                inId = (int)row[dataTable.Columns[0].ColumnName];
                inPrenom = row[dataTable.Columns[1].ColumnName].ToString();
                inNom = row[dataTable.Columns[2].ColumnName].ToString();
                inDateNaiss = (DateTime)row[dataTable.Columns[3].ColumnName];
                inPoste = (PosteJoueur)row[dataTable.Columns[4].ColumnName];
                inSelection = (int)row[dataTable.Columns[5].ColumnName];
                inScore = (int)row[dataTable.Columns[6].ColumnName];

                result.Add(new Joueur(inId, inNom, inPrenom, inDateNaiss, inPoste, inSelection, inScore));
            }

            return result;
        }

        public List<Equipe> GetAllEquipes()
        {
            string request = "select * from Equipes;";
            DataTable dataTable = SelectByAdapter(request);
            List<Equipe> result = new List<Equipe>();
            int inId;
            string inPays;
            string inNom;

            foreach (DataRow row in dataTable.Rows)
            {
                inId = (int)row[dataTable.Columns[0].ColumnName];
                inPays = row[dataTable.Columns[1].ColumnName].ToString();
                inNom = row[dataTable.Columns[2].ColumnName].ToString();

                result.Add(new Equipe(inId, inNom, inPays));
            }

            return result;
        }

        public List<Stade> GetAllStades()
        {
            string request = "select * from Stades;";
            DataTable dataTable = SelectByAdapter(request);
            List<Stade> result = new List<Stade>();
            int inId;
            string inNom;
            string inAdresse;
            int inNbPlaces;
            float inPC;

            foreach (DataRow row in dataTable.Rows)
            {
                inId = (int)row[dataTable.Columns[0].ColumnName];
                inNom = row[dataTable.Columns[1].ColumnName].ToString();
                inAdresse = row[dataTable.Columns[2].ColumnName].ToString();
                inNbPlaces = (int)row[dataTable.Columns[3].ColumnName];
                inPC = (float)row[dataTable.Columns[4].ColumnName];

                result.Add(new Stade(inId, inNom, inAdresse, inNbPlaces, inPC));
            }

            return result;
        }

        public List<Match> GetAllMatchs()
        {
            string request = "select * from Stades;";
            DataTable dataTable = SelectByAdapter(request);
            List<Match> result = new List<Match>();
           /* int inId;
            int inCoupeID;
            DateTime inDate;
            Equipe inDom;
            Equipe inVisiteur;
            double inPrix;
            int inSED;
            int inSEV; 
            Stade inStade;

            foreach (DataRow row in dataTable.Rows)
            {
                inId = (int)row[dataTable.Columns[0].ColumnName];
                inCoupeID = (int)row[dataTable.Columns[1].ColumnName];
                inNom = row[dataTable.Columns[1].ColumnName].ToString();
                inAdresse = row[dataTable.Columns[2].ColumnName].ToString();
                inNbPlaces = (int)row[dataTable.Columns[3].ColumnName];
                inPC = (float)row[dataTable.Columns[4].ColumnName];

                result.Add(new Stade(inId, inNom, inAdresse, inNbPlaces, inPC));
            }
            */
            return result;
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

        public void AjouterMatch(int inId, int inCoupeID, DateTime inDate, Equipe inDom, Equipe inVisiteur, double inPrix, int inSED, int inSEV, Stade inStade)
        {
        }

        public void SupprimerMatch(int inId)
        {
        }

        public void UpdateMatch(int inId, int inCoupeID, DateTime inDate, Equipe inDom, Equipe inVisiteur, double inPrix, int inSED, int inSEV, Stade inStade)
        {
        }
    }
}
