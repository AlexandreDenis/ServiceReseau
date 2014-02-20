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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuidditchWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PreferenceUtilisateur _preferenceUtilisateur;

        private string currentUser;

        private ListeDesCoupes ldc;
        private ListeDesJoueurs ldj;
        private ListeDesEquipes lde;
        private ListedesStades lds;
        private ListeDesMatchs ldm;
        private GestionReservation gr;

        /// <summary>
        /// Constructeur de la fenêtre principale (MainWindow)
        /// </summary>
        /// <param name="inLogin">Login de l'utilisateur courant du programme</param>
        public MainWindow(string inLogin)
        {
            InitializeComponent();
            
            currentUser = inLogin;
            _preferenceUtilisateur = new PreferenceUtilisateur();
        }

        /// <summary>
        /// A l'ouverture de la fenêtre
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSourceInitialized(EventArgs e)
        {
            _preferenceUtilisateur.Login = currentUser;

            if (File.Exists(currentUser + ".xml"))
            {
                _preferenceUtilisateur.Load();
                this.Height = _preferenceUtilisateur.HeightWindow;
                this.Width = _preferenceUtilisateur.WidthWindow;
                this.Top = _preferenceUtilisateur.TopWindow;
                this.Left = _preferenceUtilisateur.LeftWindow;
            }

            base.OnSourceInitialized(e);
        }

        /// <summary>
        /// A la fermeture de la fenêtre
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            _preferenceUtilisateur.Login = currentUser;
            _preferenceUtilisateur.WidthWindow = this.ActualWidth;
            _preferenceUtilisateur.HeightWindow = this.ActualHeight;
            _preferenceUtilisateur.TopWindow = this.Top;
            _preferenceUtilisateur.LeftWindow = this.Left;
            _preferenceUtilisateur.Save();

            if (ldc != null)
                ldc.Close();

            if (ldj != null)
                ldj.Close();

            if (lde != null)
                lde.Close();

            if (lds != null)
                lds.Close();

            if (ldm != null)
                ldm.Close();

            if (gr != null)
                gr.Close();
            
            base.OnClosing(e);
        }

        /// <summary>
        /// Gestion du click sur le bouton de gestion des coupes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void onClickCoupesButton(object sender, RoutedEventArgs e)
        {
            ldc = new ListeDesCoupes(_preferenceUtilisateur, this);
            this.IsEnabled = false;
            ldc.Show();
        }

        /// <summary>
        /// Gestion du click sur le bouton de gestion des joueurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void onClickJoueursButton(object sender, RoutedEventArgs e)
        {
            ldj = new ListeDesJoueurs(_preferenceUtilisateur, this);
            this.IsEnabled = false;
            ldj.Show();
        }

        /// <summary>
        /// Gestion du click sur le bouton de gestion des équipes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onClickEquipesButton(object sender, RoutedEventArgs e)
        {
            lde = new ListeDesEquipes(_preferenceUtilisateur, this);
            this.IsEnabled = false;
            lde.Show();
        }

        /// <summary>
        /// Gestion du click sur le bouton de gestion des stades
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onClickStadesButton(object sender, RoutedEventArgs e)
        {
            lds = new ListedesStades(_preferenceUtilisateur, this);
            this.IsEnabled = false;
            lds.Show();
        }

        /// <summary>
        /// Gestion du click sur le bouton de gestion des matchs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onClickMatchsButton(object sender, RoutedEventArgs e)
        {
            ldm = new ListeDesMatchs(_preferenceUtilisateur, this);
            this.IsEnabled = false;
            ldm.Show();
        }

        /// <summary>
        /// Gestion du click sur le bouton de gestion des réservations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onClickReservationButton(object sender, RoutedEventArgs e)
        {
            gr = new GestionReservation(_preferenceUtilisateur, this);
            this.IsEnabled = false;
            gr.Show();
        }
    }
}
