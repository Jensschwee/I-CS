using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lektion9
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Dette bruges sammen med <tittel> </tittel>koden på masterpagen
        /// Den henter fil navnet på den aktive side og sætter den til page tittel,
        /// vis ikke der er skrævet noget andet i <tittel></tittel> taget på den aktive side.
        /// </summary>
        protected string GetFileNameOrFileTittel()
        {
            if (string.IsNullOrEmpty(Page.Title))
            {
                string sPath = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
                System.IO.FileInfo oInfo = new System.IO.FileInfo(sPath);
                string sRet = oInfo.Name.Replace(".aspx", "");
                return sRet;
            }
            else
            {
                return Page.Title;
            }

        }
    }
}