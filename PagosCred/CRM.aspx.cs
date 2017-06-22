using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PagosCred
{
    public partial class CRM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["idOpportunity"] != null)
            {
                string idOpportunity = Request.QueryString["idOpportunity"];
                //string URL = String.Format("https://un-appdemo-01:90/CREDIUN/main.aspx?etc=3&id={0}&histKey=457335477&newWindow=true&pagetype=entityrecord#772517742", idOpportunity);
                string URL = String.Format("http://192.168.21.118:55/CREDIUN/main.aspx?etc=3&id={0}&histKey=457335477&newWindow=true&pagetype=entityrecord#772517742", idOpportunity);
                lblGUID.Text = idOpportunity + "</br>" + URL;
                Response.Write("<script>window.open('" + URL + "','_blank');</script>");
            }
        }
    }
}