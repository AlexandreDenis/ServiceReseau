using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;

namespace DataAccessLayer
{
    public interface IDAL
    {
        IList<Joueur> GetAllJoueurs();
        IList<Equipe> GetAllEquipes();
        IList<Stade> GetAllStades();
        IList<Match> GetAllMatchs();
        IList<Coupe> GetAllCoupes();
        IList<Utilisateur> GetAllUtilisateurs();
        IList<Reservation> GetAllReservations();

        void AjouterMatch(int inId, int inCoupeID, DateTime inDate, Equipe inDom, Equipe inVisiteur, double inPrix, int inSED, int inSEV, Stade inStade);
        void SupprimerMatch(int inId);
        void UpdateMatch(int inId, int inCoupeID, DateTime inDate, Equipe inDom, Equipe inVisiteur, double inPrix, int inSED, int inSEV, Stade inStade);
    }
}
