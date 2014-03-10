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
            ServiceQuidditch service = new ServiceQuidditch();

            //SCoupe coupe = service.GetAllCoupes()[0];
            List<int> listId = (List<int>)HttpContext.Current.Session["ListeMatchsReserves"];

            return listId;
        }
    }
}