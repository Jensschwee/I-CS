using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebTest.Models;

namespace WebTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            list.DataSource = NameList.Instance.ListOFNames;

            if (!Page.IsPostBack)
            {
                list.DataBind();
            }

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            NameList.Instance.ListOFNames.Add(txtAdd.Text);
            txtAdd.Text = "";
            list.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            NameList.Instance.ListOFNames.Remove(NameList.Instance.ListOFNames[list.SelectedIndex]);
            list.DataBind();
        }
    }
}