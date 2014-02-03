using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntitiesLayer;
using BusinessLayer;
using System.ComponentModel;

namespace QuidditchWPF
{
    public class ReservationViewModel : ViewModelBase
    {
        private CoupeManager cp;

        private Reservation _reservation;
        public Reservation Reservation
        {
            get { return _reservation; }
            set { _reservation = value; }
        }

        public int CoupeId
        {
            /*get
            {
                if (_reservation.Match != null)
                    return cp.GetCoupeById(_reservation.Match.CoupeId);
                else
                    return null;
            }

            set
            {
                _reservation.Match.CoupeId = value.Id;
            }*/
            get
            {
                return _reservation.Match.CoupeId;
            }
            set
            {
                _reservation.Match.CoupeId = value;
            }
        }

        public Match Match
        {
            get
            {
                return _reservation.Match; 
            }

            set
            {
                _reservation.Match = value;
                OnPropertyChanged("PrixUnite");
                OnPropertyChanged("Prix");
                OnPropertyChanged("Match");
            }
        }

        public string Nom
        {
            get
            {
                return _reservation.Spectateur.Nom;
            }

            set
            {
                _reservation.Spectateur.Nom = value;
                OnPropertyChanged("Nom");
            }
        }

        public string Prenom
        {
            get
            {
                return _reservation.Spectateur.Prenom;
            }
            set
            {
                _reservation.Spectateur.Prenom = value;
            }
        }

        public string Adresse
        {
            get
            {
                return _reservation.Spectateur.Adresse;
            }
            set
            {
                _reservation.Spectateur.Adresse = value;
            }
        }

        public int NbPlaces
        {
            get
            {
                return _reservation.NombrePlacesReservees;
            }

            set
            {
                _reservation.NombrePlacesReservees = value;
                OnPropertyChanged("Prix");
                
            }
        }

        public double Prix
        {
            get
            {
                double res = 0;
                if (_reservation.Match != null)
                {
                    res = _reservation.NombrePlacesReservees * _reservation.Match.Prix;
                    res += res * _reservation.Match.Stade.PourcentageCommission / 100;
                }
                res = Convert.ToDouble(string.Format("{0:0.00}", res));
                return res;
            }
        }

        public double PrixUnite
        {
            get
            {
                double res = 0;
                if (_reservation.Match != null)
                {
                    res = _reservation.Match.Prix;
                    res += res * _reservation.Match.Stade.PourcentageCommission / 100;
                    res = Convert.ToDouble(string.Format("{0:0.00}", res));
                }

                return res;
            }
        }

        public ReservationViewModel(Reservation inReserv)
        {
            _reservation = inReserv;
            cp = new CoupeManager();
        }
    }
}
