using System.Web.Http;

namespace ServiceProd.Controllers
{
    public class ProdController : ApiController
    {
        // GET /api/prod
        public string Get()
        {
            return "Prod";
        }
    }
}
