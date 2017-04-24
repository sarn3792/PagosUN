using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PagosCredijal
{
    public partial class Redirect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["idOpportunity"] != null)
                {
                    CRMInformation information = new CRMInformation(Request.QueryString["idOpportunity"]);
                    String url = String.Format("Default.aspx?idCustomer={0}", information.GetCustomerByOpportunity());
                    Response.Redirect(url);
                }
                else
                {
                    lblMessage.Text = "Parámetro nulo";
                    lblMessage.CssClass = "error";
                    lblMessage.Visible = true;
                }
            } catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
                lblMessage.CssClass = "error";
                lblMessage.Visible = true;
            }
        }
    }
}