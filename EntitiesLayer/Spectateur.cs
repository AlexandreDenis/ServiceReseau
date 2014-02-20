using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Spectateur : Personne
    {
        /// <summary>
        /// Adresse du spectateur
        /// </summary>
        private string _adresse;
        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

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
        public Spectateur(int inId, string inNom, string inPrenom, DateTime inDateNaiss, string inAdresse, string inEmail)
            : base(inId, inNom, inPrenom, inDateNaiss)
        {
            this.Adresse = inAdresse;
            this.Email = inEmail;
        }
    }
}
