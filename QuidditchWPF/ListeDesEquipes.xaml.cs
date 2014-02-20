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
    /// Logique d'interaction pour ListeDesEquipes.xaml
    /// </summary>
    public partial class ListeDesEquipes : Window
    {
        protected List<Equipe> _listEquipe;
        protected PreferenceUtilisateur _preferenceUtilisateur;
        private MainWindow _mainWindow;

        /// <summary>
        /// Constructeur de la classe ListeDesEquipes
        /// </summary>
        /// <param name="prefUser">Gestion des préférences utilisateurs</param>
        /// <param name="mainWindow">Fenêtre principale</param>
        public ListeDesEquipes(PreferenceUtilisateur prefUser, MainWindow mainWindow)
        {
            InitializeComponent();

            _mainWindow = mainWindow;

            _preferenceUtilisateur = prefUser;

            /*charge la liste des coupes*/
            CoupeManager cp = new CoupeManager();
            _listEquipe = cp.GetEquipes();
            _listEquipe.Sort(compareEquipes);

            /*on remplit la listbox des coupes*/
            ListViewEquipes.ItemsSource = _listEquipe;
            this.DataContext = _listEquipe.First();
        }

        /// <summary>
        /// Quand on change d'équipe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void onClickListView(object sender, SelectionChangedEventArgs e)
        {
            this.DataContext = ListViewEquipes.SelectedItem;
        }

        /// <summary>
        /// Comparaison entre deux équipes
        /// </summary>
        /// <param name="equipe1"></param>
        /// <param name="equipe2"></param>
        /// <returns></returns>
        public static int compareEquipes(Equipe equipe1, Equipe equipe2)
        {
            return equipe1.Nom.CompareTo(equipe2.Nom);
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

                if (_preferenceUtilisateur.HeightWindowEquipes != 0 && _preferenceUtilisateur.WidthWindowEquipes != 0)
                {
                    this.WindowState = _preferenceUtilisateur.WindowStateEquipes;
                    this.Height = _preferenceUtilisateur.HeightWindowEquipes;
                    this.Width = _preferenceUtilisateur.WidthWindowEquipes;
                    this.Top = _preferenceUtilisateur.TopWindowEquipes;
                    this.Left = _preferenceUtilisateur.LeftWindowEquipes;
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
            _preferenceUtilisateur.WindowStateEquipes = this.WindowState;
            this.WindowState = (WindowState)FormWindowState.Normal;
            _preferenceUtilisateur.WidthWindowEquipes = this.ActualWidth;
            _preferenceUtilisateur.HeightWindowEquipes = this.ActualHeight;
            _preferenceUtilisateur.TopWindowEquipes = this.Top;
            _preferenceUtilisateur.LeftWindowEquipes = this.Left;
            _preferenceUtilisateur.Save();

            _mainWindow.IsEnabled = true;

            base.OnClosing(e);
        }
    }
}
