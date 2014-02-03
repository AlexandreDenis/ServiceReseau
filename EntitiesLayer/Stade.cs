using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Stade : EntityObject
    {
        private string _nom;
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        private string _adresse;
        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        private int _nbPlaces;
        public int NbPlaces
        {
            get { return _nbPlaces; }
            set { _nbPlaces = value; }
        }

        private double _pourcentageCommission;
        public double PourcentageCommission
        {
            get { return _pourcentageCommission; }
            set { _pourcentageCommission = value; }
        }

        public Stade(int inId, string inNom, string inAdresse, int inNbPlaces, double inPC) : base(inId)
        {
            this.Nom = inNom;
            this.Adresse = inAdresse;
            this.NbPlaces = inNbPlaces;
            this.PourcentageCommission = inPC;
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();

            /*res.Append("Stade ");
            res.Append(Id);
            res.Append(" -> ");
            res.Append(Nom);
            res.Append(" [ ");
            res.Append(Adresse);
            res.Append(" ]");
            res.Append("\n");
            res.Append("Nb de places : ");
            res.Append(NbPlaces);
            res.Append(" | Commission : ");
            res.Append(PourcentageCommission);*/

            res.Append(Nom);

            //res.Append("\n");

            return res.ToString();
        }

    }
}
