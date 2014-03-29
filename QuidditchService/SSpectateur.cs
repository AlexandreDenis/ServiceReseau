using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EntitiesLayer;
using System.Runtime.Serialization;

namespace QuidditchService
{
    /// <summary>
    /// Objet Spectateur vu par le web service
    /// </summary>
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
        /// Constructeur de la classe SSpectateur
        /// </summary>
        /// <param name="inSpect">Spectateur original</param>
        public SSpectateur(Spectateur inSpect)
            : base(inSpect.Id, inSpect.Nom, inSpect.Prenom, inSpect.DateDeNaissance)
        {
            this.Email = inSpect.Email;
        }
    }
}