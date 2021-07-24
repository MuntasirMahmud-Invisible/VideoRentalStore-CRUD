using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Threading.Tasks;
using System.Web.Mvc;
using VideoRentalApps.Models;
using VideoRentalApps.ViewModels;

namespace VideoRentalApps.Controllers
{
    public class AdministratorsController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;

        public AdministratorsController()
        {

        }
        public AdministratorsController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;

        }

        //  GET: Administrator
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult NewRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> NewRole(NewRoleViewModel model)
        {


            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName,
                };
                var roleStore = new RoleStore<IdentityRole>(new ApplicationDbContext());
                var roleManager = new RoleManager<IdentityRole>(roleStore);
                IdentityResult result = await roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error);
                }
            }

            return View(model);
        }
    }
}