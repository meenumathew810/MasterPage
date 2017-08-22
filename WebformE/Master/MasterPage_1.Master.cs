using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebformE
{
    public partial class MasterPage_1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //this.ContentPlaceHolder1 = "Master Page";
            }
        }
        public string PageName { get { return lblPage.Text; } set { lblPage.Text = value; } }
    }
}