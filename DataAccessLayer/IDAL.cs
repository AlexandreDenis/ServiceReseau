using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;

namespace DataAccessLayer
{
    public interface IDal
    {
        List<Coupe> GetAllCoupes();
        List<Joueur> GetAllJoueurs();
        List<Equipe> GetAllEquipes();
        List<Stade> GetAllStades();
        List<Match> GetAllMatchs();
        List<Spectateur> GetAllSpectators();
        List<Utilisateur> GetAllUtilisateurs();
        List<Reservation> GetAllReservations();
        Coupe GetCoupeById(int inId);
        Utilisateur GetUtilsateurByLogin(string inLogin, string inPassword);
        void CreateUser(string inLogin, string inPassword);

        void AjouterMatch(int inCoupeID, DateTime inDate, Equipe inDom, Equipe inVisiteur, double inPrix, int inSED, int inSEV, Stade inStade);
        void SupprimerMatch(int inId);
        void UpdateMatch(int inId, int inCoupeID, DateTime inDate, Equipe inDom, Equipe inVisiteur, double inPrix, int inSED, int inSEV, Stade inStade);
        List<Joueur> GetJoueursOfEquipe(int inEquipeId);
        List<Match> GetMatchsOfCoupe(int inCoupeId);

        int ReserverPlace(int inMatchId, int inNbPlaces, int inSpectId);
        Match GetMatchById(int inMatchId);
        Spectateur GetSpectateurById(int inSpectId);
        void AnnulerReservation(int inIdReservation);
        Reservation GetReservationById(int inIdReservation);
    }
}
