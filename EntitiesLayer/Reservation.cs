using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Reservation : EntityObject
    {
        /// <summary>
        /// Match correspondant à la réservation
        /// </summary>
        private Match _match;
        public Match Match
        {
            get { return _match; }
            set { _match = value; }
        }

        /// <summary>
        /// Nombre de places réservées
        /// </summary>
        private int _nombrePlacesReservees;
        public int NombrePlacesReservees
        {
            get { return _nombrePlacesReservees; }
            set { _nombrePlacesReservees = value; }
        }

        /// <summary>
        /// Id du spectateur effectuant la réservation
        /// </summary>
        private Spectateur _spectateurId;
        public Spectateur Spectateur
        {
            get { return _spectateurId; }
            set { _spectateurId = value; }
        }


        /// <summary>
        /// Constructeur de la classe Reservation
        /// </summary>
        /// <param name="inId">Id de la nouvelle réservation</param>
        /// <param name="inMatch">Match correspondant à la nouvelle réservation</param>
        /// <param name="inNPR">Nombre de places réservées pour cette nouvelle réservation</param>
        /// <param name="inSpect">Id du spectateur effectuant cette nouvelle réservation</param>
        public Reservation(int inId, Match inMatch, int inNPR, Spectateur inSpect) : base(inId)
        {
            this.Match = inMatch;
            this.NombrePlacesReservees = inNPR;
            this.Spectateur = inSpect;
        }
    }
}
