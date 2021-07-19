using System.Web.Mvc;

namespace VideoRentalApps.Controllers
{
    public class RentalsController : Controller
    {
        // GET: Rentals
        public ActionResult New()
        {
            return View();
        }
        public ActionResult Reset()
        {
            ModelState.Clear();
            return View("New");
        }
    }
}