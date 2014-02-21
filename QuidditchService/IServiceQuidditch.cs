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
        List<SCoupe> GetAllCoupes();

        [OperationContract]
        List<SEquipe> GetAllEquipes();

        [OperationContract]
        List<SJoueur> GetJoueursOfEquipe(SEquipe inEquipe);

        [OperationContract]
        List<SStade> GetAllStades();
    }
}
