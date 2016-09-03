using System.Web.Http;

namespace ServiceProd.Controllers
{
    public class DevelController : ApiController
    {
        // GET /api/devel
        public string Get()
        {
            return "Devel";
        }
    }
}
