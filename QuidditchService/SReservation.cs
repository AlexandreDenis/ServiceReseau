using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EntitiesLayer;
using System.Runtime.Serialization;

namespace QuidditchService
{
    [DataContract]
    public class SReservation : SEntityObject
    {
        /// <summary>
        /// Match correspondant à la réservation
        /// </summary>
        private int _matchId;
        public int MatchId
        {
            get { return _matchId; }
            set { _matchId = value; }
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
        private int _spectateurId;
        public int SpectateurId
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
        public SReservation(Reservation inReserv) : base(inReserv.Id)
        {
            this.SpectateurId = inReserv.Spectateur.Id;
            this.MatchId = inReserv.Match.Id;
            this.NombrePlacesReservees = inReserv.NombrePlacesReservees;
        }
    }
}