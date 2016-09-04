using System.Web.Http;

namespace ServiceProd.Controllers
{
    public class ReleaseController : ApiController
    {
        // GET /api/prod
        public string Get()
        {
            return "Release";
        }
    }
}
