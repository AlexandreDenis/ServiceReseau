using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EntitiesLayer;
using System.Runtime.Serialization;

namespace QuidditchService
{
    [DataContract]
    public class SSpectateur : SPersonne
    {
        /// <summary>
        /// Adresse mail du spectateur
        /// </summary>
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        /// <summary>
        /// Constructeur de la classe Spectateur
        /// </summary>
        /// <param name="inId">Id du nouveau spectateur</param>
        /// <param name="inNom">Nom du nouveau spectateur</param>
        /// <param name="inPrenom">Prénom du nouveau spectateur</param>
        /// <param name="inDateNaiss">Date de naissance du nouveau spectateur</param>
        /// <param name="inAdresse">Adresse du nouveau du nouveau spectateur</param>
        /// <param name="inEmail">Adresse mail du nouveau spectateur</param>
        public SSpectateur(Spectateur inSpect)
            : base(inSpect.Id, inSpect.Nom, inSpect.Prenom, inSpect.DateDeNaissance)
        {
            this.Email = inSpect.Email;
        }
    }
}