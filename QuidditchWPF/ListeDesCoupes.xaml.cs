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
    public partial class ListeDesCoupes : Window
    {
        protected List<Coupe> _listCoupes;
        protected PreferenceUtilisateur _preferenceUtilisateur;
        private MainWindow _mainWindow;

        public ListeDesCoupes(PreferenceUtilisateur prefUser, MainWindow mainWindow)
        {
            InitializeComponent();

            _mainWindow = mainWindow;

            _preferenceUtilisateur = prefUser;

            /*charge la liste des coupes*/
            CoupeManager cp = new CoupeManager();
            _listCoupes = cp.GetCoupes();

            /*on remplit la listbox des coupes*/
            ListBoxCoupes.DataContext = _listCoupes;
            this.DataContext = _listCoupes.First();
        }

        protected void onClickListBox(object sender, SelectionChangedEventArgs e)
        {
            this.DataContext = ListBoxCoupes.SelectedItem;
        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            if (File.Exists(_preferenceUtilisateur.Login + ".xml"))
            {
                _preferenceUtilisateur.Load();

                if (_preferenceUtilisateur.HeightWindowCoupes != 0 && _preferenceUtilisateur.WidthWindowCoupes != 0)
                {
                    this.WindowState = _preferenceUtilisateur.WindowStateCoupes;
                    this.Height = _preferenceUtilisateur.HeightWindowCoupes;
                    this.Width = _preferenceUtilisateur.WidthWindowCoupes;
                    this.Top = _preferenceUtilisateur.TopWindowCoupes;
                    this.Left = _preferenceUtilisateur.LeftWindowCoupes;
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
            _preferenceUtilisateur.WindowStateCoupes = this.WindowState;
            this.WindowState = (WindowState)FormWindowState.Normal;
            _preferenceUtilisateur.WidthWindowCoupes = this.ActualWidth;
            _preferenceUtilisateur.HeightWindowCoupes = this.ActualHeight;
            _preferenceUtilisateur.TopWindowCoupes = this.Top;
            _preferenceUtilisateur.LeftWindowCoupes = this.Left;
            _preferenceUtilisateur.Save();

            _mainWindow.IsEnabled = true;

            base.OnClosing(e);
        }
    }
}
