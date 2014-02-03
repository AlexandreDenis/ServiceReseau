using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Spectateur : Personne
    {
        private string _adresse;
        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public Spectateur(int inId, string inNom, string inPrenom, DateTime inDateNaiss, string inAdresse, string inEmail)
            : base(inId, inNom, inPrenom, inDateNaiss)
        {
            this.Adresse = inAdresse;
            this.Email = inEmail;
        }
    }
}
