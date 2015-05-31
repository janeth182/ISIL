using System;
using ValidationHOL.BusinessLogic;

namespace ValidationHOL.Web
{
    public partial class FollowUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.StatusLabel.Text = "Processed customer " + ((Customer)Context.Items["customer"]).FirstName;
        }
    }
}
