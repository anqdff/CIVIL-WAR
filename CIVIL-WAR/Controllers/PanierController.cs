using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CIVIL_WAR.Controllers
{
    public class PanierController : Controller
    {
        [HttpPost]
        [Route("AJoutAuPanier")]
        public ActionResult Index()
        {
            return View();
        }

       
    }
}
