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
    /// Logique d'interaction pour ListeDesMatchs.xaml
    /// </summary>
    public partial class ListeDesMatchs : Window
    {
        protected List<Coupe> _listCoupes;
        protected List<Match> _listMatchsCourant;
        protected CoupeManager cp;
        protected PreferenceUtilisateur _preferenceUtilisateur;
        private MainWindow _mainWindow;

        /// <summary>
        /// Constructeur de la classe ListeDesMatchs
        /// </summary>
        /// <param name="prefUser">Gestion des préférences utilisateurs</param>
        /// <param name="mainWindow">Fenêtre principale</param>
        public ListeDesMatchs(PreferenceUtilisateur prefUser, MainWindow mainWindow)
        {
            InitializeComponent();

            _mainWindow = mainWindow;

            _preferenceUtilisateur = prefUser;

            cp = new CoupeManager();
            _listCoupes = cp.GetCoupes();

            comboBoxCoupes.ItemsSource = _listCoupes;
            inputStade.ItemsSource = cp.GetStades();
            inputEquipeVisiteur.ItemsSource = cp.GetEquipes();
            inputEquipeDomicile.ItemsSource = cp.GetEquipes();

            if (_listCoupes.Count > 0)
            {
                _listMatchsCourant = cp.GetListeMatchsCoupe(_listCoupes[0].Id);
                listviewMatchs.DataContext = _listMatchsCourant;
                comboBoxCoupes.SelectedItem = _listCoupes[0];
            }
        }

        /// <summary>
        /// Lorsqu'on change de coupe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void onComboBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listviewMatchs.DataContext = cp.GetListeMatchsCoupe(_listCoupes[comboBoxCoupes.SelectedIndex].Id);
            Grid.DataContext = listviewMatchs.SelectedItem;
            this.DataContext = comboBoxCoupes.SelectedItem;
        }

        /// <summary>
        /// Lorsqu'on change de match
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void onListViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Grid.DataContext = listviewMatchs.SelectedItem;
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

                if (_preferenceUtilisateur.HeightWindowMatchs != 0 && _preferenceUtilisateur.WidthWindowMatchs != 0)
                {
                    this.WindowState = _preferenceUtilisateur.WindowStateMatchs;
                    this.Height = _preferenceUtilisateur.HeightWindowMatchs;
                    this.Width = _preferenceUtilisateur.WidthWindowMatchs;
                    this.Top = _preferenceUtilisateur.TopWindowMatchs;
                    this.Left = _preferenceUtilisateur.LeftWindowMatchs;
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
            _preferenceUtilisateur.WindowStateMatchs = this.WindowState;
            this.WindowState = (WindowState)FormWindowState.Normal;
            _preferenceUtilisateur.WidthWindowMatchs = this.ActualWidth;
            _preferenceUtilisateur.HeightWindowMatchs = this.ActualHeight;
            _preferenceUtilisateur.TopWindowMatchs = this.Top;
            _preferenceUtilisateur.LeftWindowMatchs = this.Left;
            _preferenceUtilisateur.Save();

            _mainWindow.IsEnabled = true;

            base.OnClosing(e);
        }

        /// <summary>
        /// Rafraîchit la liste des matchs en les rappelant à partir de la BDD
        /// </summary>
        private void RefreshMatchs()
        {
            _listMatchsCourant = cp.GetListeMatchsCoupe(_listCoupes[comboBoxCoupes.SelectedIndex].Id);
            listviewMatchs.DataContext = _listMatchsCourant;
            comboBoxCoupes.SelectedItem = _listCoupes[comboBoxCoupes.SelectedIndex];
        }

        /// <summary>
        /// Gestion du click sur le bouton d'ajout d'un match
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onAjouterClick(object sender, RoutedEventArgs e)
        {
            Match match = ((Match)listviewMatchs.SelectedItem);

            int coupeId = ((Coupe)comboBoxCoupes.SelectedItem).Id;
            DateTime date = Convert.ToDateTime(inputDate.Text);
            Equipe dom = (Equipe)inputEquipeDomicile.SelectedItem;
            Equipe visiteur = (Equipe)inputEquipeVisiteur.SelectedItem;
            double prix = Convert.ToDouble(inputPrix.Text);
            int scoreD = Convert.ToInt32(inputScoreDomicile.Text);
            int scoreV = Convert.ToInt32(inputScoreVisiteur.Text);
            Stade stade = (Stade)inputStade.SelectedItem;

            cp.AjouterMatch(coupeId, date, dom, visiteur, prix, scoreD, scoreV, stade);

            RefreshMatchs();
        }

        /// <summary>
        /// Gestion du click sur le bouton de modification d'un match
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onModifierClick(object sender, RoutedEventArgs e)
        {
            Match match = ((Match)listviewMatchs.SelectedItem);

            if (match != null)
            {
                int Id = match.Id;
                int coupeId = match.CoupeId;
                DateTime date = match.Date;
                Equipe dom = match.EquipeDomicile;
                Equipe visiteur = match.EquipeVisiteur;
                double prix = match.Prix;
                int scoreD = match.ScoreEquipeDomicile;
                int scoreV = match.ScoreEquipeVisiteur;
                Stade stade = match.Stade;

                cp.UpdateMatch(Id, coupeId, date, dom, visiteur, prix, scoreD, scoreV, stade);
            }
        }

        /// <summary>
        /// Gestion du click sur le bouton de suppression d'un match
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onSupprimerClick(object sender, RoutedEventArgs e)
        {
            Match match = (Match)listviewMatchs.SelectedItem;

            if(match != null)
                cp.SupprimerMatch(match.Id);

            RefreshMatchs();
        }
    }
}
