using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntitiesLayer;
using System.Windows.Input;
using System.Windows;

namespace QuidditchWPF
{
    //Hey
    public class GestionReservationViewModel
    {
        private int nextId;

        private ReservationViewModel _selectedReservation;
        public ReservationViewModel SelectedReservation
        {
            get { return _selectedReservation; }
            set { _selectedReservation = value; }
        }
        
        private ObservableCollection<ReservationViewModel> _reservations;
        public ObservableCollection<ReservationViewModel> Reservations
        {
            get { return _reservations; }
            set { _reservations = value; }
        }

        public GestionReservationViewModel(ObservableCollection<Reservation> inReservations)
        {
            _reservations = new ObservableCollection<ReservationViewModel>();

            foreach (Reservation reserv in inReservations)
            {
                _reservations.Add(new ReservationViewModel(reserv));
            }
        }

        public void AddReservation()
        {
            _reservations.Add(new ReservationViewModel(new Reservation
                (nextId++, _selectedReservation.Match,
                _selectedReservation.NbPlaces,
                new Spectateur
                    (nextId++, _selectedReservation.Nom, _selectedReservation.Prenom, DateTime.MinValue, _selectedReservation.Adresse, null)
                    )));
        }

        public void SuppReservation()
        {
            _reservations.Remove(SelectedReservation);
        }

        public void ModifReservation()
        {
            //TODO
        }

        public bool CanAddReservation()
        {
            bool res = true;
            string places = _selectedReservation.NbPlaces.ToString();

            if(_selectedReservation.Nom == ""
                || _selectedReservation.Prenom == ""
                || _selectedReservation.Adresse == ""
                || places == ""
                || _selectedReservation.NbPlaces < 0
                )
            {
                res = false; 
            }

            return res;
        }

        private ICommand _ajoutCommande;
        public ICommand ajoutCommande
        {
            get
            {
                if (_ajoutCommande == null)
                    _ajoutCommande = new RelayCommand(() => AddReservation(), () => CanAddReservation());

                return _ajoutCommande;
            }
        }

        private ICommand _suppCommande;
        public ICommand suppCommande
        {
            get
            {
                if (_suppCommande == null)
                    _suppCommande = new RelayCommand(() => SuppReservation());

                _selectedReservation = _reservations[0];

                return _suppCommande;
            }
        }

        private ICommand _modifCommande;
        public ICommand modifCommande
        {
            get
            {
                if (_modifCommande == null)
                    _modifCommande = new RelayCommand(() => ModifReservation());

                _selectedReservation = _reservations[0];

                return _modifCommande;
            }
        }

        public GestionReservationViewModel ()
	    {
            nextId = 200;
	    }

        public int Count()
        {
            return _reservations.Count;
        }
    }
}
