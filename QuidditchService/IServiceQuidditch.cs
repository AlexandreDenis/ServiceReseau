using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using EntitiesLayer;

namespace QuidditchService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IServiceQuidditch" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IServiceQuidditch
    {
        [OperationContract]
        void CreateUser(string inLogin, string inPasswd);

        [OperationContract]
        bool CheckUser(string inLogin, string inPasswd);

        [OperationContract]
        List<SCoupe> GetAllCoupes();

        [OperationContract]
        List<SEquipe> GetAllEquipes();

        [OperationContract]
        List<SJoueur> GetJoueursOfEquipe(SEquipe inEquipe);

        [OperationContract]
        List<SStade> GetAllStades();

        [OperationContract]
        List<SMatch> GetMatchsOfCoupe(SCoupe inCoupe);

        [OperationContract]
        SUtilisateur GetUtilisateur(string inLogin, string inPassword);

        [OperationContract]
        int ReserverPlaces(SMatch inMatch, int inNbPlaces, SSpectateur inSpect);

        [OperationContract]
        SSpectateur GetSpectateurById(int inIdSpec);

        [OperationContract]
        SMatch GetMatchById(int inIdMatch);

        [OperationContract]
        List<SMatch> GetAllMatchs();

        [OperationContract]
        List<SSpectateur> GetAllSpectators();

        [OperationContract]
        List<SReservation> GetAllReservations();

        [OperationContract]
        void AnnulerReservation(int inIdReservation);

        [OperationContract]
        SReservation GetReservationById(int inIdReservation);
    }
}
