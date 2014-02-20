using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows;

namespace QuidditchWPF
{
    [Serializable]
    public class PreferenceUtilisateur
    {
        /// <summary>
        /// Login de l'utilisateur courant du programme
        /// </summary>
        private string _login;
        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        /*Main Window*/
        private double _widthWindow;
        public double WidthWindow
        {
            get { return _widthWindow; }
            set { _widthWindow = value; }
        }
        private double _heightWindow;
        public double HeightWindow
        {
            get { return _heightWindow; }
            set { _heightWindow = value; }
        }
        private double _topWindow;
        public double TopWindow
        {
            get { return _topWindow; }
            set { _topWindow = value; }
        }
        private double _leftWindow;
        public double LeftWindow
        {
            get { return _leftWindow; }
            set { _leftWindow = value; }
        }

        /*ListeDesCoupes Window*/
        private double _widthWindowCoupes;
        public double WidthWindowCoupes
        {
            get { return _widthWindowCoupes; }
            set { _widthWindowCoupes = value; }
        }
        private double _heightWindowCoupes;
        public double HeightWindowCoupes
        {
            get { return _heightWindowCoupes; }
            set { _heightWindowCoupes = value; }
        }
        private double _topWindowCoupes;
        public double TopWindowCoupes
        {
            get { return _topWindowCoupes; }
            set { _topWindowCoupes = value; }
        }
        private double _leftWindowCoupes;
        public double LeftWindowCoupes
        {
            get { return _leftWindowCoupes; }
            set { _leftWindowCoupes = value; }
        }
        private WindowState _windowStateCoupes;
        public WindowState WindowStateCoupes
        {
            get { return _windowStateCoupes; }
            set { _windowStateCoupes = value; }
        }

        /*ListeDesEquipes Window*/
        private double _widthWindowEquipes;
        public double WidthWindowEquipes
        {
            get { return _widthWindowEquipes; }
            set { _widthWindowEquipes = value; }
        }
        private double _heightWindowEquipes;
        public double HeightWindowEquipes
        {
            get { return _heightWindowEquipes; }
            set { _heightWindowEquipes = value; }
        }
        private double _topWindowEquipes;
        public double TopWindowEquipes
        {
            get { return _topWindowEquipes; }
            set { _topWindowEquipes = value; }
        }
        private double _leftWindowEquipes;
        public double LeftWindowEquipes
        {
            get { return _leftWindowEquipes; }
            set { _leftWindowEquipes = value; }
        }
        private WindowState _windowStateEquipes;
        public WindowState WindowStateEquipes
        {
            get { return _windowStateEquipes; }
            set { _windowStateEquipes = value; }
        }

        /*ListeDesJoueurs Window*/
        private double _widthWindowJoueurs;
        public double WidthWindowJoueurs
        {
            get { return _widthWindowJoueurs; }
            set { _widthWindowJoueurs = value; }
        }
        private double _heightWindowJoueurs;
        public double HeightWindowJoueurs
        {
            get { return _heightWindowJoueurs; }
            set { _heightWindowJoueurs = value; }
        }
        private double _topWindowJoueurs;
        public double TopWindowJoueurs
        {
            get { return _topWindowJoueurs; }
            set { _topWindowJoueurs = value; }
        }
        private double _leftWindowJoueurs;
        public double LeftWindowJoueurs
        {
            get { return _leftWindowJoueurs; }
            set { _leftWindowJoueurs = value; }
        }
        private WindowState _windowStateJoueurs;
        public WindowState WindowStateJoueurs
        {
            get { return _windowStateJoueurs; }
            set { _windowStateJoueurs = value; }
        }

        /*ListeDesMatchs Window*/
        private double _widthWindowMatchs;
        public double WidthWindowMatchs
        {
            get { return _widthWindowMatchs; }
            set { _widthWindowMatchs = value; }
        }
        private double _heightWindowMatchs;
        public double HeightWindowMatchs
        {
            get { return _heightWindowMatchs; }
            set { _heightWindowMatchs = value; }
        }
        private double _topWindowMatchs;
        public double TopWindowMatchs
        {
            get { return _topWindowMatchs; }
            set { _topWindowMatchs = value; }
        }
        private double _leftWindowMatchs;
        public double LeftWindowMatchs
        {
            get { return _leftWindowMatchs; }
            set { _leftWindowMatchs = value; }
        }
        private WindowState _windowStateMatchs;
        public WindowState WindowStateMatchs
        {
            get { return _windowStateMatchs; }
            set { _windowStateMatchs = value; }
        }


        /*ListeDesStades Window*/
        private double _widthWindowStades;
        public double WidthWindowStades
        {
            get { return _widthWindowStades; }
            set { _widthWindowStades = value; }
        }
        private double _heightWindowStades;
        public double HeightWindowStades
        {
            get { return _heightWindowStades; }
            set { _heightWindowStades = value; }
        }
        private double _topWindowStades;
        public double TopWindowStades
        {
            get { return _topWindowStades; }
            set { _topWindowStades = value; }
        }
        private double _leftWindowStades;
        public double LeftWindowStades
        {
            get { return _leftWindowStades; }
            set { _leftWindowStades = value; }
        }
        private WindowState _windowStateStades;
        public WindowState WindowStateStades
        {
            get { return _windowStateStades; }
            set { _windowStateStades = value; }
        }

        /*GestionReservation Window*/
        private double _widthWindowReservations;
        public double WidthWindowReservations
        {
            get { return _widthWindowReservations; }
            set { _widthWindowReservations = value; }
        }
        private double _heightWindowReservations;
        public double HeightWindowReservations
        {
            get { return _heightWindowReservations; }
            set { _heightWindowReservations = value; }
        }
        private double _topWindowReservations;
        public double TopWindowReservations
        {
            get { return _topWindowReservations; }
            set { _topWindowReservations = value; }
        }
        private double _leftWindowReservations;
        public double LeftWindowReservations
        {
            get { return _leftWindowReservations; }
            set { _leftWindowReservations = value; }
        }
        private WindowState _windowStateReservations;
        public WindowState WindowStateReservations
        {
            get { return _windowStateReservations; }
            set { _windowStateReservations = value; }
        }

        /// <summary>
        /// Sauvegarde des préférences de l'utilisateur
        /// </summary>
        public void Save()
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(_login + ".xml");
                XmlSerializer serializer = new XmlSerializer(typeof(PreferenceUtilisateur));
                serializer.Serialize(sw, this);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (sw != null)
                    sw.Close();
            }
        }

        /// <summary>
        /// Chargement des préférences de l'utilisateur
        /// </summary>
        public void Load()
        {
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(_login + ".xml");
                XmlSerializer serializer = new XmlSerializer(typeof(PreferenceUtilisateur));
                PreferenceUtilisateur pref = (PreferenceUtilisateur)serializer.Deserialize(sr);

                this.HeightWindow = pref.HeightWindow;
                this.WidthWindow = pref.WidthWindow;
                this.TopWindow = pref.TopWindow;
                this.LeftWindow = pref.LeftWindow;

                this.HeightWindowCoupes = pref.HeightWindowCoupes;
                this.WidthWindowCoupes = pref.WidthWindowCoupes;
                this.TopWindowCoupes = pref.TopWindowCoupes;
                this.LeftWindowCoupes = pref.LeftWindowCoupes;
                this.WindowStateCoupes = pref.WindowStateCoupes;

                this.HeightWindowEquipes = pref.HeightWindowEquipes;
                this.WidthWindowEquipes = pref.WidthWindowEquipes;
                this.TopWindowEquipes = pref.TopWindowEquipes;
                this.LeftWindowEquipes = pref.LeftWindowEquipes;
                this.WindowStateEquipes = pref.WindowStateEquipes;

                this.HeightWindowJoueurs = pref.HeightWindowJoueurs;
                this.WidthWindowJoueurs = pref.WidthWindowJoueurs;
                this.TopWindowJoueurs = pref.TopWindowJoueurs;
                this.LeftWindowJoueurs = pref.LeftWindowJoueurs;
                this.WindowStateJoueurs = pref.WindowStateJoueurs;

                this.HeightWindowMatchs = pref.HeightWindowMatchs;
                this.WidthWindowMatchs = pref.WidthWindowMatchs;
                this.TopWindowMatchs = pref.TopWindowMatchs;
                this.LeftWindowMatchs = pref.LeftWindowMatchs;
                this.WindowStateMatchs = pref.WindowStateMatchs;

                this.HeightWindowStades = pref.HeightWindowStades;
                this.WidthWindowStades = pref.WidthWindowStades;
                this.TopWindowStades = pref.TopWindowStades;
                this.LeftWindowStades = pref.LeftWindowStades;
                this.WindowStateStades = pref.WindowStateStades;

                this.HeightWindowReservations = pref.HeightWindowReservations;
                this.WidthWindowReservations = pref.WidthWindowReservations;
                this.TopWindowReservations = pref.TopWindowReservations;
                this.LeftWindowReservations = pref.LeftWindowReservations;
                this.WindowStateReservations = pref.WindowStateReservations;
            }
            catch (Exception)
            {
                this.TopWindow = 0;
                this.LeftWindow = 0;
            }
            finally
            {
                if (sr != null)
                    sr.Close();
            }
        }
    }
}
