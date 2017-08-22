using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebformE
{
    public partial class MasterPageDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.Master.PageName = "Child Page";
            }
        }
        public string PageName1 { get { return lblPage1.Text; } set { lblPage1.Text = value; } }
    }
}