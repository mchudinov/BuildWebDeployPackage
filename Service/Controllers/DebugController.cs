using System.Web.Http;

namespace ServiceProd.Controllers
{
    public class DebugController : ApiController
    {
        // GET /api/devel
        public string Get()
        {
            return "Debug";
        }
    }
}
