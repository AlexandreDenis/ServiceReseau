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

using BusinessLayer;

namespace QuidditchWPF
{
    /// <summary>
    /// Logique d'interaction pour Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        /// <summary>
        /// Constructeur de la classe Login
        /// Première fenêtre ouverte au démarrage du programme
        /// </summary>
        public Login()
        {
            InitializeComponent();
            loginWPF.Focus();
        }
        
        /// <summary>
        /// Gestion du click sur le bouton de connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void onClickConnexionButton(object sender, RoutedEventArgs e)
        {
            CoupeManager cp = new CoupeManager();

#if DEBUG
            MainWindow win = new MainWindow("alec");
            win.Show();

            this.Close();

#else
            if (cp.checkConnexionUser(loginWPF.Text.ToLower(), mdpWPF.Password))

            {
                MainWindow win = new MainWindow(loginWPF.Text.ToLower());
                win.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Login/Mot de passe incorrect !");
                loginWPF.Clear();
                mdpWPF.Clear();
                loginWPF.Focus();
            }
#endif
        }

        /// <summary>
        /// Gestion de l'appui sur Entrée pour lancer la connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onKeyDownHandler(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
                onClickConnexionButton(sender, e);
        }

        
    }
}
