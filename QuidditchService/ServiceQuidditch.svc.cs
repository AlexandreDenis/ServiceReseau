using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using BusinessLayer;
using EntitiesLayer;

namespace QuidditchService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ServiceQuidditch" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez ServiceQuidditch.svc ou ServiceQuidditch.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ServiceQuidditch : IServiceQuidditch
    {
        private CoupeManager _manager;

        public ServiceQuidditch ()
	    {
            _manager = new CoupeManager();
	    }

        public void CreateUser(string inLogin, string inPasswd)
        {
            _manager.CreateUser(inLogin, inPasswd);
        }

        public bool CheckUser(string inLogin, string inPasswd)
        {
            return _manager.CheckConnexionUser(inLogin, inPasswd);
        }

        public List<SCoupe> GetAllCoupes()
        {
            List<Coupe> coupes = _manager.GetCoupes();
            List<SCoupe> scoupes = new List<SCoupe>();

            foreach(Coupe cp in coupes)
            {
                scoupes.Add(new SCoupe(cp));
            }

            return scoupes;
        }

        public List<SEquipe> GetAllEquipes()
        {
            List<Equipe> equipes = _manager.GetEquipes();
            List<SEquipe> sequipes = new List<SEquipe>();

            foreach (Equipe equ in equipes)
            {
                sequipes.Add(new SEquipe(equ));
            }

            return sequipes;
        }

        public List<SJoueur> GetJoueursOfEquipe(SEquipe inEquipe)
        {
            List<Joueur> joueurs = _manager.GetJoueursOfEquipe(inEquipe.Id);
            List<SJoueur> sjoueurs = new List<SJoueur>();

            foreach (Joueur jou in joueurs)
            {
                sjoueurs.Add(new SJoueur(jou));
            }

            return sjoueurs;
        }

        public List<SStade> GetAllStades()
        {
            List<Stade> stades = _manager.GetStades();
            List<SStade> sstades = new List<SStade>();

            foreach (Stade sta in stades)
            {
                sstades.Add(new SStade(sta));
            }

            return sstades;
        }

        public List<SMatch> GetMatchsOfCoupe(SCoupe inCoupe)
        {
            List<Match> matchs = _manager.GetMatchs();
            List<SMatch> smatchs = new List<SMatch>();

            foreach (Match mat in matchs)
            {
                smatchs.Add(new SMatch(mat));
            }

            return smatchs;
        }

        public SUtilisateur GetUtilisateur(string inLogin, string inPassword)
        {
            Utilisateur user = _manager.GetUser(inLogin, inPassword);
            SUtilisateur suser = null;

            if (user != null)
            {
                suser = new SUtilisateur(user.Nom, user.Prenom, user.Login, user.Password);
            }

            return suser;
        }

        public SMatch GetMatchById(int inIdMatch)
        {
            return new SMatch(_manager.GetMatchById(inIdMatch));
        }

        public SSpectateur GetSpectateurById(int inIdSpec)
        {
            return new SSpectateur(_manager.GetSpectateurById(inIdSpec));
        }

        public int ReserverPlaces(SMatch inMatch, int inNbPlaces, SSpectateur inSpect)
        {
            Match m = _manager.GetMatchById(inMatch.Id);
            Spectateur s = _manager.GetSpectateurById(inSpect.Id);
            
            return _manager.ReserverPlace(m, inNbPlaces, s);
        }

        public List<SMatch> GetAllMatchs()
        {
            List<Match> matchs = _manager.GetMatchs();
            List<SMatch> smatchs = new List<SMatch>();

            foreach (Match mat in matchs)
            {
                smatchs.Add(new SMatch(mat));
            }

            return smatchs;
        }

        public List<SSpectateur> GetAllSpectators()
        {
            List<Spectateur> spectateurs = _manager.GetSpectators();
            List<SSpectateur> sspectateurs = new List<SSpectateur>();

            foreach (Spectateur spe in spectateurs)
            {
                sspectateurs.Add(new SSpectateur(spe));
            }

            return sspectateurs;
        }

        public List<SReservation> GetAllReservations()
        {
            List<Reservation> reservations = _manager.GetReservations();
            List<SReservation> sreservations = new List<SReservation>();

            foreach (Reservation res in reservations)
            {
                sreservations.Add(new SReservation(res));
            }

            return sreservations;
        }

        public void AnnulerReservation(int inIdReservation)
        {
            _manager.AnnulerReservation(inIdReservation);
        }

        public SReservation GetReservationById(int inIdReservation)
        {
            Reservation res = _manager.GetReservationById(inIdReservation);
            SReservation sres = null;
            if(res != null)
                sres = new SReservation(res);

            return sres;
        }
    }
}
