using System;
using System.Collections.Generic;
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
using System.Windows.Forms;
using System.IO;

using BusinessLayer;
using EntitiesLayer;

namespace QuidditchWPF
{
    /// <summary>
    /// Logique d'interaction pour ListeDesJoueurs.xaml
    /// </summary>
    public partial class ListeDesJoueurs : Window
    {
        protected List<Equipe> _listEquipes;
        protected List<Joueur> _listJoueurs;
        protected PreferenceUtilisateur _preferenceUtilisateur;
        private MainWindow _mainWindow;
        CoupeManager cp;

        /// <summary>
        /// Constructeur de la classe ListeDesJoueurs
        /// </summary>
        /// <param name="prefUser">Gestion des préférences utilisateurs</param>
        /// <param name="mainWindow">Fenêtre principale</param>
        public ListeDesJoueurs(PreferenceUtilisateur prefUser, MainWindow mainWindow)
        {
            InitializeComponent();

            _mainWindow = mainWindow;

            _preferenceUtilisateur = prefUser;

            cp = new CoupeManager();
            _listEquipes = cp.GetEquipes();

            if (_listEquipes.Count > 0)
            {
                _listJoueurs = cp.GetJoueursOfEquipe(_listEquipes[0].Id);

                comboBoxEquipes.ItemsSource = _listEquipes;
                inputPoste.ItemsSource = Enum.GetValues(typeof(PosteJoueur));

                listviewEquipe.DataContext = _listJoueurs;
                comboBoxEquipes.SelectedItem = _listEquipes[0];
                this.DataContext = _listEquipes[0];
                Grid.DataContext = _listJoueurs[0];
            }
            /*if (_listEquipes.Count > 0)
            {
                listviewEquipe.DataContext = _listEquipes[0].Joueurs;
                comboBoxEquipes.SelectedItem = _listEquipes[0];
                this.DataContext = _listEquipes[0];
                if (_listEquipes[0].Joueurs.Count > 0)
                    Grid.DataContext = _listEquipes[0].Joueurs[0];
            }*/
        }

        /// <summary>
        /// Lorsqu'on change d'équipe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void onComboBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _listJoueurs = cp.GetJoueursOfEquipe(_listEquipes[comboBoxEquipes.SelectedIndex].Id);
            this.DataContext = comboBoxEquipes.SelectedItem;
            listviewEquipe.DataContext = _listJoueurs;
            if (_listJoueurs.Count > 0)
                Grid.DataContext = _listJoueurs[0];
            /*this.DataContext = comboBoxEquipes.SelectedItem;
            listviewEquipe.DataContext = _listEquipes[comboBoxEquipes.SelectedIndex].Joueurs;
            if(_listEquipes[comboBoxEquipes.SelectedIndex].Joueurs.Count > 0)
                Grid.DataContext = _listEquipes[comboBoxEquipes.SelectedIndex].Joueurs[0];*/
        }

        /// <summary>
        /// Lorsqu'on clique sur un autre joueur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void onListViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Grid.DataContext = listviewEquipe.SelectedItem;
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

                if (_preferenceUtilisateur.HeightWindowJoueurs != 0 && _preferenceUtilisateur.WidthWindowJoueurs != 0)
                {
                    this.WindowState = _preferenceUtilisateur.WindowStateJoueurs;
                    this.Height = _preferenceUtilisateur.HeightWindowJoueurs;
                    this.Width = _preferenceUtilisateur.WidthWindowJoueurs;
                    this.Top = _preferenceUtilisateur.TopWindowJoueurs;
                    this.Left = _preferenceUtilisateur.LeftWindowJoueurs;
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
            _preferenceUtilisateur.WindowStateJoueurs = this.WindowState;
            this.WindowState = (WindowState)FormWindowState.Normal;
            _preferenceUtilisateur.WidthWindowJoueurs = this.ActualWidth;
            _preferenceUtilisateur.HeightWindowJoueurs = this.ActualHeight;
            _preferenceUtilisateur.TopWindowJoueurs = this.Top;
            _preferenceUtilisateur.LeftWindowJoueurs = this.Left;
            _preferenceUtilisateur.Save();

            _mainWindow.IsEnabled = true;

            base.OnClosing(e);
        }
    }
}
