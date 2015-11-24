using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lektion9
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        private Number num;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                num = new Number();
                Session["Num"] = num;
            }
            else
                num = (Number)Session["Num"];
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            GenerateNumber();
        }

        protected void btnRandom_Click(object sender, EventArgs e)
        {
            num.Max = Convert.ToInt32(txtInput.Text);
            Session["Num"] = num;
            GenerateNumber();
        }

        public void GenerateNumber()
        {
            txtResult.Text = num.Next().ToString();
        }
    }
}