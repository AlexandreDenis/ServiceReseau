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
        List<Utilisateur> GetAllUtilisateurs();
        List<Reservation> GetAllReservations();
        Coupe GetCoupeById(int inId);
        Utilisateur GetUtilsateurByLogin(string inLogin);

        void AjouterMatch(int inId, int inCoupeID, DateTime inDate, Equipe inDom, Equipe inVisiteur, double inPrix, int inSED, int inSEV, Stade inStade);
        void SupprimerMatch(int inId);
        void UpdateMatch(int newId, int oldId, int inCoupeID, DateTime inDate, Equipe inDom, Equipe inVisiteur, double inPrix, int inSED, int inSEV, Stade inStade);
        List<Joueur> GetJoueursOfEquipe(int inEquipeId);
    }
}
