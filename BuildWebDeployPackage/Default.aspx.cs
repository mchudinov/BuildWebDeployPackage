using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Http;

namespace BuildWebDeployPackage
{
    public partial class Default : System.Web.UI.Page
    {
        protected string serviceresponse = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string uri = ConfigurationManager.AppSettings["ServiceUri"];
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream resStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(resStream);
                serviceresponse = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                //
            }
        }
    }
}