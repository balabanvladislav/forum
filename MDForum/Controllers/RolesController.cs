using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.EntityFramework;
using MDF.BLogic;

namespace MDForum.Controllers
{
    public class RolesController : Controller
    {
        private ApplicationDbContext context;
        // GET
        public RolesController()
        {
            context = new ApplicationDbContext();
        }

        [Authorize(Roles = "admin")]
        public ActionResult Index()
        {
            var role = context.Roles.ToList();
            return View(role);
        }

        [Authorize(Roles = "admin")]
        public ActionResult Create()
        {
            var role = new IdentityRole();
            return View(role);
        }


        [HttpPost]
        [Authorize(Roles = "admin")]
        public ActionResult Create(IdentityRole role)
        {
            context.Roles.Add(role);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}