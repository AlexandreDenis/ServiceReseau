using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EntitiesLayer;
using System.Runtime.Serialization;

namespace QuidditchService
{
    [DataContract]
    public class SUtilisateur 
    {
        /// <summary>
        /// Nom de l'utilisateur
        /// </summary>
        private string _nom;
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        /// <summary>
        /// Prénom de l'utilisateur
        /// </summary>
        private string _prenom;
        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        /// <summary>
        /// Login de l'utilisateur
        /// </summary>
        private string _login;
        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        /// <summary>
        /// Mot de passe de l'utilisateur
        /// </summary>
        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        /// <summary>
        /// Constructeur de la classe Utilisateur
        /// </summary>
        /// <param name="inNom">Nom du nouvel utilisateur</param>
        /// <param name="inPrenom">Prénom du nouvel utilisateur</param>
        /// <param name="inLogin">Login du nouvel utilisateur</param>
        /// <param name="inPassword">Mot de passe du nouvel utilisateur</param>
        public SUtilisateur(string inNom, string inPrenom, string inLogin, string inPassword)
        {
            this.Nom = inNom;
            this.Prenom = inPrenom;
            this.Login = inLogin;
            this.Password = inPassword;
        }
    }
}