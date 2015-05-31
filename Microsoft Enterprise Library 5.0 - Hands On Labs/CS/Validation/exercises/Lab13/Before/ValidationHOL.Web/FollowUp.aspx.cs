using System;
using ValidationHOL.BusinessLogic;

namespace ValidationHOL.Web
{
    public partial class FollowUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (CustomerServiceClient client = new CustomerServiceClient())
            {
                try
                {
                    this.StatusLabel.Text =
                        client.ProcessCustomer(
                            (Customer)Context.Items["customer"],
                            (string)Context.Items["notes"]);
                }
                catch (Exception ex)
                {
                    this.StatusLabel.Text = "Unknown error invoking service: " + ex.ToString() + "<br/>";
                }
            }
        }
    }
}
