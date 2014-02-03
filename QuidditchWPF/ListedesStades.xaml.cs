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
    /// Logique d'interaction pour ListeDesCoupes.xaml
    /// </summary>
    public partial class ListedesStades : Window
    {
        protected List<Stade> _listStades;
        protected PreferenceUtilisateur _preferenceUtilisateur;
        private MainWindow _mainWindow;

        public ListedesStades(PreferenceUtilisateur prefUser, MainWindow mainWindow)
        {
            InitializeComponent();

            _mainWindow = mainWindow;

            _preferenceUtilisateur = prefUser;

            /*charge la liste des coupes*/
            CoupeManager cp = new CoupeManager();
            _listStades = cp.GetStades();

            /*on remplit la listbox des coupes*/
            ListBoxStades.DataContext = _listStades;
            this.DataContext = _listStades.First();
        }

        protected void onClickListBox(object sender, SelectionChangedEventArgs e)
        {
            this.DataContext = ListBoxStades.SelectedItem;
            ListBoxStades.DataContext = _listStades;
        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            if (File.Exists(_preferenceUtilisateur.Login + ".xml"))
            {
                _preferenceUtilisateur.Load();

                if (_preferenceUtilisateur.HeightWindowStades != 0 && _preferenceUtilisateur.WidthWindowStades != 0)
                {
                    this.WindowState = _preferenceUtilisateur.WindowStateStades;
                    this.Height = _preferenceUtilisateur.HeightWindowStades;
                    this.Width = _preferenceUtilisateur.WidthWindowStades;
                    this.Top = _preferenceUtilisateur.TopWindowStades;
                    this.Left = _preferenceUtilisateur.LeftWindowStades;
                }
                else
                {
                    this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                }
            }

            base.OnSourceInitialized(e);
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            _preferenceUtilisateur.WindowStateStades = this.WindowState;
            this.WindowState = (WindowState)FormWindowState.Normal;
            _preferenceUtilisateur.WidthWindowStades = this.ActualWidth;
            _preferenceUtilisateur.HeightWindowStades = this.ActualHeight;
            _preferenceUtilisateur.TopWindowStades = this.Top;
            _preferenceUtilisateur.LeftWindowStades = this.Left;
            _preferenceUtilisateur.Save();

            _mainWindow.IsEnabled = true;

            base.OnClosing(e);
        }
    }
}
