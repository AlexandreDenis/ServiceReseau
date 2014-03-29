using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EntitiesLayer;
using System.Runtime.Serialization;

namespace QuidditchService
{
    /// <summary>
    /// Objet Stade vu par le web service
    /// </summary>
    [DataContract]
    public class SStade : SEntityObject
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
        /// Constructeur de la classe SStade
        /// </summary>
        /// <param name="inStade">Stade original</param>
        public SStade(Stade inStade) : base(inStade.Id)
        {
            this.Nom = inStade.Nom;
            this.Adresse = inStade.Adresse;
            this.NbPlaces = inStade.NbPlaces;
            this.PourcentageCommission = inStade.PourcentageCommission;
        }
    }
}