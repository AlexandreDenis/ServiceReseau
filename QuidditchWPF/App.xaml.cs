using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace QuidditchWPF
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            DispatcherUnhandledException += App_DispatcherUnhandledException;
        }

        void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            string path = "app.log";
            FileStream logFile = File.Open(path, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(logFile);

            DateTime dt = new DateTime(System.DateTime.Now.Year,
                System.DateTime.Now.Month,
                System.DateTime.Now.Day,                
                System.DateTime.Now.Hour,
                System.DateTime.Now.Minute,
                0,
                0);
            //on reporte l'erreur dans un fichier de log
            string currentDate = String.Format("{0:dd/MM/yy - HH:mm} : ",dt);
            sw.WriteLine(currentDate + e.Exception.ToString());

            sw.Close();
            logFile.Close();

            //affichage d'un message pour l'utilisateur
            MessageBox.Show("Une erreur inattendue s'est produite (cf. app.log).");

            //on prévient que l'exception a bien été gérée par l'application
            e.Handled = true;
        }
    }
}
