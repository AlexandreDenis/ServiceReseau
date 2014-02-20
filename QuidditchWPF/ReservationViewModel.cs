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

        /// <summary>
        /// Réservation correspondante
        /// </summary>
        private Reservation _reservation;
        public Reservation Reservation
        {
            get { return _reservation; }
            set { _reservation = value; }
        }

        /// <summary>
        /// Id de la coupe du match de la réservation
        /// </summary>
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

        /// <summary>
        /// Match de la réservation
        /// </summary>
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

        /// <summary>
        /// Nom du spectateur ayant effectué la réservation
        /// </summary>
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

        /// <summary>
        /// Prénom du spectateur ayant effectué la réservation
        /// </summary>
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

        /// <summary>
        /// Adresse du spectateur ayant effectué la réservation
        /// </summary>
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

        /// <summary>
        /// Nombre de places réservées
        /// </summary>
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

        /// <summary>
        /// Prix total de la réservation
        /// </summary>
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

        /// <summary>
        /// Prix unitaire de chaque place pour la réservation
        /// </summary>
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

        /// <summary>
        /// Constructeur de la classe ReservationViewModel
        /// </summary>
        /// <param name="inReserv"></param>
        public ReservationViewModel(Reservation inReserv)
        {
            _reservation = inReserv;
            cp = new CoupeManager();
        }
    }
}
