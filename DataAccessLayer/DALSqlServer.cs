using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Security.Cryptography;

using EntitiesLayer;

namespace DataAccessLayer
{
    public class DalSqlServer : IDal
    {
        /// <summary>
        /// Chaîne de connexion à la BDD
        /// </summary>
        private string _connectionString;

        /// <summary>
        /// Constructeur de la classe DalSqlServer
        /// </summary>
        /// <param name="inConnexion">Chaîne de connexion</param>
        public DalSqlServer(string inConnexion)
        {
            _connectionString = inConnexion;
        }

        /// <summary>
        /// Méthode d'accès à la BDD
        /// </summary>
        /// <param name="request">Requête à appeler sur la BDD</param>
        /// <returns>Réponse de la BDD sous forme de tableau</returns>
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

        /// <summary>
        /// Renvoie toutes les coupes
        /// </summary>
        /// <returns>Liste des coupes</returns>
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

        /// <summary>
        /// Renvoie tous les joueurs
        /// </summary>
        /// <returns>Liste des joueurs</returns>
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

        /// <summary>
        /// Renvoie toutes les équipes
        /// </summary>
        /// <returns>Liste des équipes</returns>
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

        /// <summary>
        /// Renvoie tous les stades
        /// </summary>
        /// <returns>Liste des stades</returns>
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

        /// <summary>
        /// Renvoie tous les matchs
        /// </summary>
        /// <returns>Liste des matchs</returns>
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
                
                //Récupération des Entities selon les Ids récupérés
                inStade = getStadeById(inStadeID);
                inDom = getEquipeById(inDomID);
                inVisiteur = getEquipeById(inVisiteurID);
                
                result.Add(new Match(inId, inCoupeID, (DateTime)inDate, inDom, inVisiteur, 50.0, inSED, inSEV, inStade));
                
            }
            
            return result;
        }

        public List<Spectateur> GetAllSpectators()
        {
            List<Spectateur> result = new List<Spectateur>();
            string request = "select * from Spectateurs;";
            DataTable dataTable = SelectByAdapter(request);
            int inId;
            string inPrenom;
            string inNom;
            DateTime inDate;
            string inAdresse;
            string inMail;
            
            foreach (DataRow row in dataTable.Rows)
            {
                
                inId = (int)row[dataTable.Columns[0].ColumnName];
                inPrenom = row[dataTable.Columns[1].ColumnName].ToString();
                inNom = row[dataTable.Columns[2].ColumnName].ToString();
                inDate = (DateTime)row[dataTable.Columns[3].ColumnName];
                inAdresse = row[dataTable.Columns[4].ColumnName].ToString();
                inMail = row[dataTable.Columns[5].ColumnName].ToString();

                result.Add(new Spectateur(inId,inNom,inPrenom,inDate,inAdresse,inMail));
            }

            return result;
        }

        /// <summary>
        /// Renvoie le stade associé à un Id
        /// </summary>
        /// <param name="inId">Id du stade à rechercher</param>
        /// <returns>Une instance de stade ou null</returns>
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

        /// <summary>
        /// Renvoie l'équipe associée à un Id
        /// </summary>
        /// <param name="inId">Id de l'équipe à rechercher</param>
        /// <returns>Une instance d'équipe ou null</returns>
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

        /// <summary>
        /// Renvoie tous les utilisateurs du programme
        /// </summary>
        /// <returns>Liste des utilisateurs</returns>
        public List<Utilisateur> GetAllUtilisateurs()
        {
            string request = "select * from Utilisateur;";
            DataTable dataTable = SelectByAdapter(request);
            List<Utilisateur> usrs = new List<Utilisateur>();
            string inId;
            string inLogin;
            string inPassword;

            foreach (DataRow row in dataTable.Rows)
            {
                inId = row[dataTable.Columns[0].ColumnName].ToString();
                inLogin = row[dataTable.Columns[1].ColumnName].ToString();
                inPassword = row[dataTable.Columns[2].ColumnName].ToString();

                usrs.Add(new Utilisateur(inId, inId, inLogin, inPassword));
            }

            return usrs;
        }

        /// <summary>
        /// Renvoie toutes les réservations
        /// </summary>
        /// <returns>Liste des réservations</returns>
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

                //Récupération des Entities selon les Ids récupérés
                inSpect = GetSpectateurById(inSpectId);
                inMatch = GetMatchById(inMatchId);

                result.Add(new Reservation(inId,inMatch,inNPR,inSpect));
            }

            return result;
        }

        /// <summary>
        /// Renvoie le match associé à un Id
        /// </summary>
        /// <param name="inId">Id du match à rechercher</param>
        /// <returns>Une instance de match ou null</returns>
        public Match GetMatchById(int inMatchId)
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

                result = new Match(inId, inCoupeID, inDate, inDom, inVisiteur, 50.0, inSED, inSEV, inStade);
            }

            return result;
        }

        /// <summary>
        /// Renvoie le spectateur associé à un Id
        /// </summary>
        /// <param name="inId">Id du spectateur à rechercher</param>
        /// <returns>Une instance de spectateur ou null</returns>
        public Spectateur GetSpectateurById(int inSpectId)
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

        /// <summary>
        /// Renvoie la liste de tous les joueurs d'une équipe
        /// </summary>
        /// <param name="inEquipeId">Id de l'équipe pour laquelle on veut les joueurs</param>
        /// <returns>Liste des joueurs de l'équipe correspondante</returns>
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

        /// <summary>
        /// Renvoie la liste des matchs correspondant à une coupe donnée
        /// </summary>
        /// <param name="inCoupeId">Id de la coupe dont on cherche les matchs</param>
        /// <returns>Liste des matchs correspondant</returns>
        public List<Match> GetMatchsOfCoupe(int inCoupeId)
        {
            string request = "select * from Matchs where CoupeID = " + inCoupeId + ";";
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

        /// <summary>
        /// Renvoie l'utilisateur correspondant au login
        /// </summary>
        /// <param name="inLogin">Login à rechercher dans la base</param>
        /// <param name="inPassword">Mot de passe entré pour le login</param>
        /// <returns>Une instance d'utilisateur ou null</returns>
        public Utilisateur GetUtilsateurByLogin(string inLogin, string inPassword)
        {
            //Utilisateur(id login password)
            string request = "select * from Utilisateur where Login = '" + inLogin + "';";
            DataTable dataTable = SelectByAdapter(request);
            Utilisateur usr = null;

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                string id = row[dataTable.Columns[0].ColumnName].ToString();
                string login = row[dataTable.Columns[1].ColumnName].ToString();
                string password = row[dataTable.Columns[2].ColumnName].ToString();

                SHA1 sha1 = SHA1.Create();
                byte[] hashData = sha1.ComputeHash(Encoding.Default.GetBytes(inPassword));
                StringBuilder stringHashData = new StringBuilder();

                for (int i = 0; i < hashData.Length; ++i)
                {
                    stringHashData.Append(hashData[i].ToString());
                }

                if (password.Equals(stringHashData.ToString()))
                    usr = new Utilisateur(id, id, inLogin, inPassword);
            }

            return usr;
        }

        /// <summary>
        /// Renvoie la coupe associée à un Id
        /// </summary>
        /// <param name="inId">Id de la coupe à rechercher</param>
        /// <returns>Une instance de coupe ou null</returns>
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

        /// <summary>
        /// Méthode de modification de la BDD
        /// </summary>
        /// <param name="request">Requête à exécuter sur la BDD</param>
        /// <param name="authors">Tableau de la table modifiée</param>
        /// <returns></returns>
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
            DataTable dataTable = SelectByAdapter("select * from Matchs;");

            dataTable.Rows.Add(null, inCoupeID, inStade.Id, 1,inDom.Id, inVisiteur.Id, inSED, inSEV, inDate);

            UpdateByCommandBuilder("select * from Matchs;", dataTable);
        }

        /// <summary>
        /// Suppression d'un match de la BDD
        /// </summary>
        /// <param name="inId">Id du match à supprimer de la BDD</param>
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
            DataTable dataTable = SelectByAdapter("select * from Matchs;");
            int matchId;

            foreach (DataRow row in dataTable.Rows)
            {
                matchId = (int)row[dataTable.Columns[0].ColumnName];

                if (matchId == inId)
                {
                    row[dataTable.Columns[1].ColumnName] = inCoupeID;
                    row[dataTable.Columns[2].ColumnName] = inStade.Id;
                    row[dataTable.Columns[4].ColumnName] = inDom.Id;
                    row[dataTable.Columns[5].ColumnName] = inVisiteur.Id;
                    row[dataTable.Columns[6].ColumnName] = inSED;
                    row[dataTable.Columns[7].ColumnName] = inSEV;
                    row[dataTable.Columns[8].ColumnName] = inDate;
                }
            }

            UpdateByCommandBuilder("select * from Matchs;", dataTable);
        }

        public void CreateUser(string inLogin, string inPassword)
        {
            DataTable dataTable = SelectByAdapter("select * from Utilisateur;");

            SHA1 sha1 = SHA1.Create();
            byte[] hashData = sha1.ComputeHash(Encoding.Default.GetBytes(inPassword));
            StringBuilder stringHashData = new StringBuilder();

            for (int i = 0; i < hashData.Length; ++i)
            {
                stringHashData.Append(hashData[i].ToString());
            }

            dataTable.Rows.Add(null,inLogin, stringHashData.ToString());
            UpdateByCommandBuilder("select * from Utilisateur;", dataTable);
        }

        public int ReserverPlace(int inMatchId, int inNbPlaces, int inSpectId)
        {
            DataTable dataTable = SelectByAdapter("select * from Reservations;");

            dataTable.Rows.Add(null, inSpectId, inMatchId,inNbPlaces,null);
            UpdateByCommandBuilder("select * from Reservations;", dataTable);

            return LastInsertedReservId();
        }

        private int LastInsertedReservId()
        {
            List<Reservation> reservations = GetAllReservations();

            int totalReserv = reservations.Count();

            return reservations[totalReserv-1].Id;
        }

        public void AnnulerReservation(int inIdReservation)
        {
            DataTable dataTable = SelectByAdapter("select * from Reservations;");
            int id;

            foreach (DataRow row in dataTable.Rows)
            {
                id = (int)row[dataTable.Columns[0].ColumnName];

                if (id == inIdReservation)
                    row.Delete();
            }

            UpdateByCommandBuilder("select * from Reservations;", dataTable);
        }

        public Reservation GetReservationById(int inIdReservation)
        {
            string request = "select * from Reservations where ID = "+inIdReservation+";";
            DataTable dataTable = SelectByAdapter(request);
            Reservation result = null;
            int inId;
            Match inMatch;
            int inNPR;
            Spectateur inSpect;
            int inSpectId;
            int inMatchId;

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];

                inId = (int)row[dataTable.Columns[0].ColumnName];
                inSpectId = (int)row[dataTable.Columns[1].ColumnName];
                inMatchId = (int)row[dataTable.Columns[2].ColumnName];
                inNPR = (int)row[dataTable.Columns[3].ColumnName];

                /*Récupération des Entities selon les Ids récupérés*/
                inSpect = GetSpectateurById(inSpectId);
                inMatch = GetMatchById(inMatchId);

                result = new Reservation(inId, inMatch, inNPR, inSpect);
            }

            return result;
        }
    }
}
