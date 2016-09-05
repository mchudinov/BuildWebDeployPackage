using System;
using System.Configuration;

namespace BuildWebDeployPackage
{
    public partial class Default : System.Web.UI.Page
    {
        protected string MyConfigOption = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            MyConfigOption = ConfigurationManager.AppSettings["MyConfigOption"];
        }
    }
}