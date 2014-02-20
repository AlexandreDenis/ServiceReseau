using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    abstract public class Personne : EntityObject
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
        /// Constructeur de la classe Personne
        /// </summary>
        /// <param name="inId">Id de la nouvelle Personne</param>
        /// <param name="inNom">Nom de la nouvelle Personne</param>
        /// <param name="inPrenom">Prénom de la nouvelle Personne</param>
        /// <param name="inDateNaiss">Date de naissance de la nouvelle Personne</param>
        public Personne(int inId, string inNom, string inPrenom, DateTime inDateNaiss) : base(inId)
        {
            this.Nom = inNom;
            this.Prenom = inPrenom;
            this.DateDeNaissance = inDateNaiss;
        }

    }
}
