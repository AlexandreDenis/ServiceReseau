using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Stade : EntityObject
    {
        /// <summary>
        /// Nom du stade
        /// </summary>
        private string _nom;
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        /// <summary>
        /// Adresse du stade
        /// </summary>
        private string _adresse;
        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        /// <summary>
        /// Nombre de places disponibles dans le stade
        /// </summary>
        private int _nbPlaces;
        public int NbPlaces
        {
            get { return _nbPlaces; }
            set { _nbPlaces = value; }
        }

        /// <summary>
        /// Pourcentage de commission du stade
        /// </summary>
        private double _pourcentageCommission;
        public double PourcentageCommission
        {
            get { return _pourcentageCommission; }
            set { _pourcentageCommission = value; }
        }

        /// <summary>
        /// Constructeur de la classe Stade
        /// </summary>
        /// <param name="inId">Id du nouveau stade</param>
        /// <param name="inNom">Nom du nouveau stade</param>
        /// <param name="inAdresse">Adresse du nouveau stade</param>
        /// <param name="inNbPlaces">Nombre de places du nouveau stade</param>
        /// <param name="inPC">Pourcentage de commission du nouveau stade</param>
        public Stade(int inId, string inNom, string inAdresse, int inNbPlaces, double inPC) : base(inId)
        {
            this.Nom = inNom;
            this.Adresse = inAdresse;
            this.NbPlaces = inNbPlaces;
            this.PourcentageCommission = inPC;
        }

        /// <summary>
        /// Chaîne de caractères du stade
        /// </summary>
        /// <returns>Chaîne correspondante</returns>
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
