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

        public int ReserverPlaces(SMatch inMatch, int inNbPlaces, SSpectateur inSpect)
        {
            //TODO
            return 0;
        }
    }
}
