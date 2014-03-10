using QuidditchService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteWebQuidditch
{
    public partial class reservation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        [ScriptMethod]
        public static List<int> GetPanier()
        {
            List<int> listId = (List<int>)HttpContext.Current.Session["ListeMatchsReserves"];

            return listId;
        }

        [WebMethod]
        [ScriptMethod]
        public static void CancelReservations(List<int> inListId)
        {
           List<int> reservations = (List<int>)HttpContext.Current.Session["ListeMatchsReserves"];

           foreach (int i in inListId)
            {
                if (reservations.Contains(i))
                {
                    reservations.Remove(i);
                }
            }

            HttpContext.Current.Session["ListeMatchsReserves"] = reservations;
        }

        [WebMethod]
        [ScriptMethod]
        public static void ClearPanier()
        {
            HttpContext.Current.Session["ListeMatchsReserves"] = null;
        }
    }
}