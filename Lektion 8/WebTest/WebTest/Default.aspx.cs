using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Providers.Entities;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebTest.Models;

namespace WebTest
{
    public partial class _Default : Page
    {
        private static List<Address> addresses;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                addresses = new List<Address>();
                addresses.Add(new Address("Test", "Test"));
                addresses.Add(new Address("Test1", "Test3"));
                addresses.Add(new Address("Test2", "Test4"));
                gridAddresView.DataSource = addresses;
                gridAddresView.DataBind();
                Session["Addresses"] = addresses;
            }
            else
            {
                addresses = (List<Address>)Session["Addresses"];
                gridAddresView.DataSource = addresses;
            }
        }

        protected void gridAddresView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            addresses.Remove(addresses[e.RowIndex]);
            Session["Addresses"] = addresses;
            gridAddresView.DataBind();
        }

        protected void gridAddresView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            addresses[e.RowIndex].RoadName = ((TextBox)(gridAddresView.Rows[e.RowIndex].FindControl("txtRoadName"))).Text;
            addresses[e.RowIndex].Number = ((TextBox)(gridAddresView.Rows[e.RowIndex].FindControl("txtNumber"))).Text; ;
            Session["Addresses"] = addresses;
            gridAddresView.EditIndex = -1;
            gridAddresView.DataBind();

        }

        protected void gridAddresView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridAddresView.EditIndex = -1;
            gridAddresView.DataBind();
        }

        protected void gridAddresView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gridAddresView.EditIndex = e.NewEditIndex;
            gridAddresView.DataBind();
        }
    }
}