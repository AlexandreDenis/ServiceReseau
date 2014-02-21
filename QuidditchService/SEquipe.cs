using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EntitiesLayer;
using System.Runtime.Serialization;

namespace QuidditchService
{
    [DataContract]
    public class SEquipe : SEntityObject
    {
        /// <summary>
        /// Nom de l'équipe
        /// </summary>
        private string _nom;
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        /// <summary>
        /// Pays de l'équipe
        /// </summary>
        private string _pays;
        public string Pays
        {
            get { return _pays; }
            set { _pays = value; }
        }

        /// <summary>
        /// Constructeur de la classe Equipe
        /// </summary>
        /// <param name="inId">Id de la nouvelle équipe</param>
        /// <param name="inNom">Nom de la nouvelle équipe</param>
        /// <param name="inPays">Pays de la nouvelle équipe</param>
        public SEquipe(Equipe inEquipe) : base(inEquipe.Id)
        {
            this.Nom = inEquipe.Nom;
            this.Pays = inEquipe.Pays;
        }
    }
}