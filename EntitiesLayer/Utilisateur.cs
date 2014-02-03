using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Utilisateur
    {
        private string _nom;
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        private string _prenom;
        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
        private string _login;
        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public Utilisateur(string inNom, string inPrenom, string inLogin, string inPassword)
        {
            Nom = inNom;
            Prenom = inPrenom;
            Login = inLogin;
            Password = inPassword;
        }
    }
}