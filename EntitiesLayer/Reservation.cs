using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Reservation : EntityObject
    {
        private Match _match;
        public Match Match
        {
            get { return _match; }
            set { _match = value; }
        }

        private int _nombrePlacesReservees;
        public int NombrePlacesReservees
        {
            get { return _nombrePlacesReservees; }
            set { _nombrePlacesReservees = value; }
        }

        private Spectateur _spectateurId;
        public Spectateur Spectateur
        {
            get { return _spectateurId; }
            set { _spectateurId = value; }
        }

        public Reservation(int inId, Match inMatch, int inNPR, Spectateur inSpect) : base(inId)
        {
            this.Match = inMatch;
            this.NombrePlacesReservees = inNPR;
            this.Spectateur = inSpect;
        }
    }
}
