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
    public class GestionReservationViewModel
    {
        private int nextId;

        /// <summary>
        /// Reservation sélectionnée
        /// </summary>
        private ReservationViewModel _selectedReservation;
        public ReservationViewModel SelectedReservation
        {
            get { return _selectedReservation; }
            set { _selectedReservation = value; }
        }
        
        /// <summary>
        /// Conteneurs des réservations
        /// </summary>
        private ObservableCollection<ReservationViewModel> _reservations;
        public ObservableCollection<ReservationViewModel> Reservations
        {
            get { return _reservations; }
            set { _reservations = value; }
        }

        /// <summary>
        /// Constructeur de la classe GestionReservationViewModel
        /// </summary>
        /// <param name="inReservations">Réservations à gérer</param>
        public GestionReservationViewModel(ObservableCollection<Reservation> inReservations)
        {
            _reservations = new ObservableCollection<ReservationViewModel>();

            foreach (Reservation reserv in inReservations)
            {
                _reservations.Add(new ReservationViewModel(reserv));
            }
        }

        /// <summary>
        /// Ajout d'une réservation au gestionnaire
        /// </summary>
        public void AddReservation()
        {
            _reservations.Add(new ReservationViewModel(new Reservation
                (nextId++, _selectedReservation.Match,
                _selectedReservation.NbPlaces,
                new Spectateur
                    (nextId++, _selectedReservation.Nom, _selectedReservation.Prenom, DateTime.MinValue, _selectedReservation.Adresse, null)
                    )));
        }

        /// <summary>
        /// Suppression d'une réservation au gestionnaire
        /// </summary>
        public void SuppReservation()
        {
            _reservations.Remove(SelectedReservation);
        }

        /// <summary>
        /// Modification de la réservation courante
        /// -> inutile vu que binding en place
        /// </summary>
        public void ModifReservation()
        {
            //TODO
        }

        /// <summary>
        /// Vérification à effectuer avant l'ajout d'une réservation
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Gestion du click sur le bouton d'ajout
        /// </summary>
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

        /// <summary>
        /// Gestion du click sur le bouton de suppression
        /// </summary>
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

        /// <summary>
        /// Gestion du click sur le bouton de modification
        /// </summary>
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

        /// <summary>
        /// Constructeur par défaut de la classe GestionReservationViewModel
        /// </summary>
        public GestionReservationViewModel ()
	    {
            nextId = 200;
	    }

        /// <summary>
        /// Renvoie le nombre de réservations gérées
        /// </summary>
        /// <returns>Nombre de réservations gérées</returns>
        public int Count()
        {
            return _reservations.Count;
        }
    }
}
