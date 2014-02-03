using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    abstract public class Personne : EntityObject
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

        private DateTime _dateDeNaissance;
        public DateTime DateDeNaissance
        {
            get { return _dateDeNaissance; }
            set { _dateDeNaissance = value; }
        }

        public Personne(int inId, string inNom, string inPrenom, DateTime inDateNaiss) : base(inId)
        {
            this.Nom = inNom;
            this.Prenom = inPrenom;
            this.DateDeNaissance = inDateNaiss;
        }

    }
}
