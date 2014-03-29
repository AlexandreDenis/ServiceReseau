using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EntitiesLayer;
using System.Runtime.Serialization;

namespace QuidditchService
{
    /// <summary>
    /// Objet Personne vu par le web service
    /// </summary>
    [DataContract]
    public class SPersonne : SEntityObject
    {
        /// <summary>
        /// Nom de la personne
        /// </summary>
        private string _nom;
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        /// <summary>
        /// Prénom de la personne
        /// </summary>
        private string _prenom;
        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        /// <summary>
        /// Date de naissance de la personne
        /// </summary>
        private DateTime _dateDeNaissance;
        public DateTime DateDeNaissance
        {
            get { return _dateDeNaissance; }
            set { _dateDeNaissance = value; }
        }

        /// <summary>
        /// Constructeur de la classe SPersonne
        /// </summary>
        /// <param name="inId">Id de la personne originale</param>
        /// <param name="inNom">Nom de la personne originale</param>
        /// <param name="inPrenom">Prénom de la personne originale</param>
        /// <param name="inDateNaiss">Date de naissance de la personne originale</param>
        public SPersonne(int inId, string inNom, string inPrenom, DateTime inDateNaiss) : base(inId)
        {
            this.Nom = inNom;
            this.Prenom = inPrenom;
            this.DateDeNaissance = inDateNaiss;
        }
    }
}