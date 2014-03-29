using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

using QuidditchService;

namespace SiteWebQuidditch
{
    public partial class matchs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Renvoie la liste des matchs de la base de données
        /// </summary>
        /// <returns>Liste des matchs</returns>
        [WebMethod]
        [ScriptMethod]
        public static List<SMatch> GetAllMatchs()
        {
            ServiceQuidditch service = new ServiceQuidditch();

            SCoupe coupe = service.GetAllCoupes()[0];

            return service.GetMatchsOfCoupe(coupe);
        }

        /// <summary>
        /// Créer une session/panier pour les matchs sélectionnés
        /// par l'utilisateur
        /// </summary>
        /// <param name="inListId">Liste des identifiants de matchs sélectionnés</param>
        [WebMethod]
        [ScriptMethod]
        public static void SetReservations(List<int> inListId)
        {
            HttpContext.Current.Session["ListeMatchsReserves"] = inListId;
        }
    }
}