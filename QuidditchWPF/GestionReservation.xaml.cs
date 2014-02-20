using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using BusinessLayer;
using EntitiesLayer;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace QuidditchWPF
{
    /// <summary>
    /// Logique d'interaction pour GestionReservation.xaml
    /// </summary>
    public partial class GestionReservation : Window
    {
        protected PreferenceUtilisateur _preferenceUtilisateur;
        protected GestionReservationViewModel _reservations;
        protected CoupeManager cp;
        protected List<Coupe> _listCoupes;
        private MainWindow _mainWindow;

        /// <summary>
        /// Constructeur de la classe GestionReservation
        /// </summary>
        /// <param name="prefUser">Gestion des préférences utilisateurs</param>
        /// <param name="mainWindow">Fenêtre principale</param>
        public GestionReservation(PreferenceUtilisateur prefUser, MainWindow mainWindow)
        {
            InitializeComponent();

            _mainWindow = mainWindow;

            _preferenceUtilisateur = prefUser;
            cp = new CoupeManager();

            _listCoupes = cp.GetCoupes();

            _reservations = new GestionReservationViewModel(new ObservableCollection<Reservation>(cp.GetReservations()));
            userCtrl.comboCoupes.ItemsSource = _listCoupes;

            listViewReservations.DataContext = _reservations.Reservations;

            /*if (_reservations.Reservations.Count > 0)
            {
                userCtrl.DataContext = _reservations.Reservations[0];
            }*/

            if(_listCoupes.Count > 0)
                userCtrl.comboMatchs.ItemsSource = cp.GetListeMatchsCoupe(_listCoupes[0].Id);

            userCtrl.comboCoupes.SelectedItem = cp.GetCoupeById(_reservations.Reservations[0].CoupeId);
            userCtrl.DataContext = _reservations.Reservations[0];
            _reservations.SelectedReservation = _reservations.Reservations[0];

            userCtrl.CoupesChanged += new EventHandler(EventHandler_CoupesChanged);

            buttons.DataContext = _reservations;
        }

        /// <summary>
        /// Quand on change de coupe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void EventHandler_CoupesChanged(object sender, EventArgs e)
        {

            if (userCtrl.comboCoupes.SelectedItem != null)
            {
                int index = userCtrl.comboCoupes.SelectedIndex;

                userCtrl.comboMatchs.ItemsSource = cp.GetListeMatchsCoupe(_listCoupes[index].Id);

                if (userCtrl.comboMatchs.SelectedItem == null)
                    userCtrl.comboMatchs.SelectedItem = cp.GetListeMatchsCoupe(_listCoupes[index].Id)[0];
            }
        }

        /// <summary>
        /// A l'ouverture de la fenêtre
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSourceInitialized(EventArgs e)
        {
            if (File.Exists(_preferenceUtilisateur.Login + ".xml"))
            {
                _preferenceUtilisateur.Load();

                if (_preferenceUtilisateur.HeightWindowReservations != 0 && _preferenceUtilisateur.WidthWindowReservations != 0)
                {
                    this.WindowState = _preferenceUtilisateur.WindowStateReservations;
                    this.Height = _preferenceUtilisateur.HeightWindowReservations;
                    this.Width = _preferenceUtilisateur.WidthWindowReservations;
                    this.Top = _preferenceUtilisateur.TopWindowReservations;
                    this.Left = _preferenceUtilisateur.LeftWindowReservations;
                }
                else
                {
                    this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                }
            }

            base.OnSourceInitialized(e);
        }

        /// <summary>
        /// A la fermeture de la fenêtre
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            _preferenceUtilisateur.WindowStateReservations = this.WindowState;
            this.WindowState = (WindowState)FormWindowState.Normal;
            _preferenceUtilisateur.WidthWindowReservations = this.ActualWidth;
            _preferenceUtilisateur.HeightWindowReservations = this.ActualHeight;
            _preferenceUtilisateur.TopWindowReservations = this.Top;
            _preferenceUtilisateur.LeftWindowReservations = this.Left;
            _preferenceUtilisateur.Save();

            _mainWindow.IsEnabled = true;

            base.OnClosing(e);
        }

        /// <summary>
        /// Quand on change de réservation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onClickListview(object sender, SelectionChangedEventArgs e)
        {
            if (_reservations.Count() > 0)
            {
                if (listViewReservations.SelectedItem == null)
                    listViewReservations.SelectedIndex = 0;
                userCtrl.DataContext = listViewReservations.SelectedItem;
                _reservations.SelectedReservation = _reservations.Reservations[listViewReservations.SelectedIndex];
                Coupe coupe = cp.GetCoupeById(_reservations.Reservations[listViewReservations.SelectedIndex].CoupeId);
                userCtrl.comboCoupes.SelectedItem = coupe;
            }
        }
    }
}
