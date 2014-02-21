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

        public List<SJoueur> GetAllJoueurs()
        {
            List<Joueur> joueurs = _manager.GetJoueurs();
            List<SJoueur> sjoueurs = new List<SJoueur>();

            foreach (Joueur jou in joueurs)
            {
                sjoueurs.Add(new SJoueur(jou));
            }

            return sjoueurs;
        }
    }
}
