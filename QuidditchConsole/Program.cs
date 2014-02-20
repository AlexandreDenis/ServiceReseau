using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLayer;
using EntitiesLayer;

namespace QuidditchConsole
{
    class Program
    {
        /// <summary>
        /// Point d'entrée du programme pour la version console
        /// </summary>
        /// <param name="args">Arguments passés au programme</param>
        static void Main(string[] args)
        {
            CoupeManager cp = new CoupeManager();
            int choix = -1;
            bool fin = false;
            List<string> lstrings;

            /*Boucle principale*/
            while (true)
            {
                /*Saisie du choix par l'utilisateur*/
                do
                {
                    /*MENU*/
                    Console.WriteLine("Que voulez-vous faire?");
                    Console.WriteLine("     0 : Afficher la liste des joueurs");
                    Console.WriteLine("     1 : Afficher la liste des équipes");
                    Console.WriteLine("     2 : Afficher la liste des stades");
                    Console.WriteLine("     3 : Afficher la liste des matchs");
                    Console.WriteLine("     4 : Afficher la liste des coupes");
                    Console.WriteLine("     5 : Afficher la liste des matchs prévus pour une coupe donnée");
                    Console.WriteLine("     6 : Afficher la liste des stades pour lesquels au moins un match est programmé pour une coupe donnée");
                    Console.WriteLine("     7 : Afficher la liste des attrapeurs qui ont joués à domicile pour une coupe donnée");
                    Console.WriteLine("     8 : Quitter");
                    try
                    {
                        choix = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                } while (choix < 0 || choix > 8);

                //Gestion du choix
                switch (choix)
                {
                    case 0:
                        List<Joueur> ljoueurs = cp.GetJoueurs();

                        Console.WriteLine("Liste des joueurs existants :");
                        foreach (Joueur pl in ljoueurs)
                        {
                            Console.WriteLine(pl.ToString());
                        }
                        break;
                    case 1:
                        List<Equipe> lequipes = cp.GetEquipes();

                        Console.WriteLine("Liste des équipes existantes :");
                        foreach (Equipe pl in lequipes)
                        {
                            Console.WriteLine(pl.ToString());
                        }
                        break;
                    case 2:
                        List<Stade> lstades = cp.GetStades();

                        Console.WriteLine("Liste des stades existants :");
                        foreach (Stade pl in lstades)
                        {
                            Console.WriteLine(pl.ToString());
                        }
                        break;
                    case 3:
                        List<Match> lmatchs = cp.GetMatchs();

                        Console.WriteLine("Liste des matchs existants :");
                        foreach (Match pl in lmatchs)
                        {
                            Console.WriteLine(pl.ToString());
                        }
                        break;
                    case 4:
                        List<Coupe> lcoupes = cp.GetCoupes();

                        Console.WriteLine("Liste des coupes existantes :");
                        foreach (Coupe pl in lcoupes)
                        {
                            Console.WriteLine(pl.ToString());
                        }
                        break;
                    case 5:
                        Console.WriteLine("Taper le numero de la coupe :");
                        try
                        {
                            choix = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            continue;
                        }

                        lmatchs = cp.GetListeMatchsCoupe(choix);

                        if (lmatchs != null)
                        {
                            Console.WriteLine("Liste des matchs prévus pour la coupe " + choix + " :");
                            foreach (Match s in lmatchs)
                                Console.WriteLine(s);
                        }
                        else
                        {
                            Console.WriteLine("Numéro de coupe non valide !\n");
                        }

                        break;
                    case 6:
                        Console.WriteLine("Taper le numero de la coupe :");
                        try
                        {
                            choix = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            continue;
                        }

                        lstrings = cp.GetListeStades(choix);

                        if (lstrings != null)
                        {
                            Console.WriteLine("Liste des stades pour lesquels au moins un match est programmé pour la coupe " + choix + " :");
                            foreach (string s in lstrings)
                                Console.WriteLine(s);
                        }
                        else
                        {
                            Console.WriteLine("Numéro de coupe non valide !\n");
                        }

                        break;
                    case 7:
                        Console.WriteLine("Taper le numero de la coupe :");
                        try
                        {
                            choix = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            continue;
                        }

                        lstrings = cp.GetListeAttrapeursDomicile(choix);

                        if (lstrings != null)
                        {
                            Console.WriteLine("Liste des attrapeurs qui ont joués à domicile pour la coupe " + choix + " :");
                            foreach (string s in lstrings)
                                Console.WriteLine(s);
                        }
                        else
                        {
                            Console.WriteLine("Numéro de coupe non valide !\n");
                        }

                        break;
                    case 8:
                        fin = true;
                        break;
                }

                if (fin)
                    break;
            }
        }
    }
}
