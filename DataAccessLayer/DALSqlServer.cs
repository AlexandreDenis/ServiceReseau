using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

            foreach (DataRow row in dataTable.Rows)
            {
                inId = (int)row[dataTable.Columns[0].ColumnName];
                inPrenom = row[dataTable.Columns[1].ColumnName].ToString();
                inNom = row[dataTable.Columns[2].ColumnName].ToString();
                inDateNaiss = (DateTime)row[dataTable.Columns[3].ColumnName];
                inPoste = (PosteJoueur)row[dataTable.Columns[5].ColumnName];

                result.Add(new Joueur(inId, inNom, inPrenom, inDateNaiss, inPoste, 0, 0));
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
            string request = "select * from Matchs;";
            DataTable dataTable = SelectByAdapter(request);
            List<Match> result = new List<Match>();
            int inId;
            int inCoupeID;
            int inStadeID;
            Stade inStade;
            DateTime inDate;
            Equipe inDom;
            Equipe inVisiteur;
            int inDomID;
            int inVisiteurID;
            int inSED;
            int inSEV; 

            foreach (DataRow row in dataTable.Rows)
            {
                inId = (int)row[dataTable.Columns[0].ColumnName];
                inCoupeID = (int)row[dataTable.Columns[1].ColumnName];
                inStadeID = (int)row[dataTable.Columns[2].ColumnName];
                inDomID = (int)row[dataTable.Columns[4].ColumnName];
                inVisiteurID = (int)row[dataTable.Columns[5].ColumnName];
                inSED = (int)row[dataTable.Columns[6].ColumnName];
                inSEV = (int)row[dataTable.Columns[7].ColumnName];
                inDate = (DateTime)row[dataTable.Columns[8].ColumnName];

                /*Récupération des Entities selon les Ids récupérés*/
                inStade = getStadeById(inStadeID);
                inDom = getEquipeById(inDomID);
                inVisiteur = getEquipeById(inVisiteurID);

                result.Add(new Match(inId, inCoupeID, (DateTime)inDate, inDom, inVisiteur, 50.0, inSED, inSEV, inStade));
            }
            
            return result;
        }

        private Stade getStadeById(int inStadeID)
        {
            string request = "select * from Stades where ID = " + inStadeID + ";";
            DataTable dataTable = SelectByAdapter(request);
            Stade result = null;
            int inId;
            string inNom;
            string inAdresse;
            int inNbPlaces;
            float inPC;

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];

                inId = (int)row[dataTable.Columns[0].ColumnName];
                inNom = row[dataTable.Columns[1].ColumnName].ToString();
                inAdresse = row[dataTable.Columns[2].ColumnName].ToString();
                inNbPlaces = (int)row[dataTable.Columns[3].ColumnName];
                inPC = (float)row[dataTable.Columns[4].ColumnName];

                result = new Stade(inId, inNom, inAdresse, inNbPlaces, inPC);
            }

            return result;
        }

        private Equipe getEquipeById(int inEquipeID)
        {
            string request = "select * from Equipes where ID = " + inEquipeID + ";";
            DataTable dataTable = SelectByAdapter(request);
            Equipe result = null;
            int inId;
            string inPays;
            string inNom;

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];

                inId = (int)row[dataTable.Columns[0].ColumnName];
                inPays = row[dataTable.Columns[1].ColumnName].ToString();
                inNom = row[dataTable.Columns[2].ColumnName].ToString();

                result = new Equipe(inId, inNom, inPays);
            }

            return result;
        }

        public List<Utilisateur> GetAllUtilisateurs()
        {
            return null;
        }

        public List<Reservation> GetAllReservations()
        {
            string request = "select * from Reservations;";
            DataTable dataTable = SelectByAdapter(request);
            List<Reservation> result = new List<Reservation>();
            int inId;
            Match inMatch;
            int inNPR;
            Spectateur inSpect;
            int inSpectId;
            int inMatchId;

            foreach (DataRow row in dataTable.Rows)
            {
                inId = (int)row[dataTable.Columns[0].ColumnName];
                inSpectId = (int)row[dataTable.Columns[1].ColumnName];
                inMatchId = (int)row[dataTable.Columns[2].ColumnName];
                inNPR = (int)row[dataTable.Columns[3].ColumnName];

                /*Récupération des Entities selon les Ids récupérés*/
                inSpect = getSpectateurById(inSpectId);
                inMatch = getMatchById(inMatchId);

                result.Add(new Reservation(inId,inMatch,inNPR,inSpect));
            }

            return result;
        }

        private Match getMatchById(int inMatchId)
        {
            string request = "select * from Matchs where ID = " + inMatchId + ";";
            DataTable dataTable = SelectByAdapter(request);
            Match result = null;
            int inId;
            int inCoupeID;
            int inStadeID;
            Stade inStade;
            DateTime inDate;
            Equipe inDom;
            Equipe inVisiteur;
            int inDomID;
            int inVisiteurID;
            int inSED;
            int inSEV; 

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];

                inId = (int)row[dataTable.Columns[0].ColumnName];
                inCoupeID = (int)row[dataTable.Columns[1].ColumnName];
                inStadeID = (int)row[dataTable.Columns[2].ColumnName];
                inDomID = (int)row[dataTable.Columns[4].ColumnName];
                inVisiteurID = (int)row[dataTable.Columns[5].ColumnName];
                inSED = (int)row[dataTable.Columns[6].ColumnName];
                inSEV = (int)row[dataTable.Columns[7].ColumnName];
                inDate = (DateTime)row[dataTable.Columns[8].ColumnName];

                /*Récupération des Entities selon les Ids récupérés*/
                inStade = getStadeById(inStadeID);
                inDom = getEquipeById(inDomID);
                inVisiteur = getEquipeById(inVisiteurID);

                result = new Match(inId, inCoupeID, (DateTime)inDate, inDom, inVisiteur, 50.0, inSED, inSEV, inStade);
            }

            return result;
        }

        private Spectateur getSpectateurById(int inSpectId)
        {
            string request = "select * from Spectateurs where ID = " + inSpectId + ";";
            DataTable dataTable = SelectByAdapter(request);
            Spectateur result = null;
            int inId;
            string inNom;
            string inPrenom;
            DateTime inDateNaiss;
            string inAdresse;
            string inEmail;

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];

                inId = (int)row[dataTable.Columns[0].ColumnName];
                inPrenom = row[dataTable.Columns[1].ColumnName].ToString();
                inNom = row[dataTable.Columns[2].ColumnName].ToString();
                inDateNaiss = (DateTime)row[dataTable.Columns[3].ColumnName];
                inAdresse = row[dataTable.Columns[4].ColumnName].ToString();
                inEmail = row[dataTable.Columns[5].ColumnName].ToString();

                result = new Spectateur(inId, inNom, inPrenom, inDateNaiss, inAdresse, inEmail);
            }

            return result;
        }

        public List<Joueur> GetJoueursOfEquipe(int inEquipeId)
        {
            string request = "select * from Joueurs where EquipeID = " + inEquipeId + ";";
            DataTable dataTable = SelectByAdapter(request);
            List<Joueur> result = new List<Joueur>();
            int inId;
            string inNom;
            string inPrenom;
            DateTime inDateNaiss;
            PosteJoueur inPoste;

            foreach (DataRow row in dataTable.Rows)
            {
                inId = (int)row[dataTable.Columns[0].ColumnName];
                inPrenom = row[dataTable.Columns[1].ColumnName].ToString();
                inNom = row[dataTable.Columns[2].ColumnName].ToString();
                inDateNaiss = (DateTime)row[dataTable.Columns[3].ColumnName];
                inPoste = (PosteJoueur)row[dataTable.Columns[5].ColumnName];

                result.Add(new Joueur(inId, inNom, inPrenom, inDateNaiss, inPoste, 0, 0));
            }

            return result;
        }

        public Utilisateur GetUtilsateurByLogin(string inLogin)
        {
            return null;
        }

        public Coupe GetCoupeById(int inCoupeId)
        {
            string request = "select * from Coupes where ID = " + inCoupeId + ";";
            DataTable dataTable = SelectByAdapter(request);
            Coupe result = null;
            int inId;
            int inYear;
            string inLibelle;

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];

                inId = (int)row[dataTable.Columns[0].ColumnName];
                inYear = (int)row[dataTable.Columns[1].ColumnName];
                inLibelle = row[dataTable.Columns[2].ColumnName].ToString();

                result = new Coupe(inId, inYear, inLibelle);
            }

            return result;
        }

        private int UpdateByCommandBuilder(string request, DataTable authors)
        {
            int result = 0;

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(request.ToString(), sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

                sqlDataAdapter.UpdateCommand = sqlCommandBuilder.GetUpdateCommand();
                sqlDataAdapter.InsertCommand = sqlCommandBuilder.GetInsertCommand();
                sqlDataAdapter.DeleteCommand = sqlCommandBuilder.GetDeleteCommand();

                sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                result = sqlDataAdapter.Update(authors);
            }

            return result;
        }

        public void AjouterMatch(int inCoupeID, DateTime inDate, Equipe inDom, Equipe inVisiteur, double inPrix, int inSED, int inSEV, Stade inStade)
        {
            /*DataTable dataTable = SelectByAdapter("select * from Matchs;");

            dataTable.Rows.Add(

            request.Append("insert into Matchs values(");
            //request.Append(inId);
            //request.Append(",");
            request.Append(inCoupeID);
            request.Append(",");
            request.Append(inStade.Id);
            request.Append(",");
            request.Append(inDom.Id);
            request.Append(",");
            request.Append(inVisiteur.Id);
            request.Append(",");
            request.Append(inSED);
            request.Append(",");
            request.Append(inSEV);
            request.Append(");");

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand commandeInsert = new SqlCommand(request.ToString(), sqlConnection);
                commandeInsert.ExecuteNonQuery();
            }*/
        }

        public void SupprimerMatch(int inId)
        {
            /*Suppression des réservations liées au match à supprimer*/
            DataTable dataTable = SelectByAdapter("select * from Reservations;");

            int matchId;

            foreach (DataRow row in dataTable.Rows)
            {
                matchId = (int)row[dataTable.Columns[2].ColumnName];

                if (matchId == inId)
                    row.Delete();
            }

            UpdateByCommandBuilder("select * from Reservations;", dataTable);

            /*Suppression du match*/
            dataTable = SelectByAdapter("select * from Matchs;");

            foreach (DataRow row in dataTable.Rows)
            {
                matchId = (int)row[dataTable.Columns[0].ColumnName];

                if (matchId == inId)
                    row.Delete();
            }

            UpdateByCommandBuilder("select * from Matchs;", dataTable);
        }

        public void UpdateMatch(int inId, int inCoupeID, DateTime inDate, Equipe inDom, Equipe inVisiteur, double inPrix, int inSED, int inSEV, Stade inStade)
        {
            StringBuilder request = new StringBuilder();

            request.Append("update Matchs set CoupeID=");
            request.Append(inCoupeID);
            request.Append(",StadeID=");
            request.Append(inStade.Id);
            request.Append(",DomicileID=");
            request.Append(inDom.Id);
            request.Append(",VisiteurID=");
            request.Append(inVisiteur.Id);
            request.Append(",ScoreDomicile=");
            request.Append(inSED);
            request.Append(",ScoreVisiteur=");
            request.Append(inSEV);
            request.Append(",Date=");
            request.Append(inDate.ToString());
            request.Append(" where ID=");
            request.Append(inId);
            request.Append(";");

            SqlCommand commandeUpdate = new SqlCommand(request.ToString());
            commandeUpdate.ExecuteNonQuery();
        }
    }
}
