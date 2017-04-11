using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Intranet.Models;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Intranet.Controllers
{
    public class AdminUsuariosController : Controller
    {
        // GET: AdminUsuarios
        public ActionResult Index()
        {
            return View();
        }

        //GET
        public ActionResult CrearPerfil()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> CrearPerfil(CrearPerfilesViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var RoleManager = new RoleManager<IdentityRole>(
                                  new RoleStore<IdentityRole>(new ApplicationDbContext()));
                var roleresult = RoleManager.Create(new IdentityRole(model.Perfil));
                if(roleresult.Succeeded)
                    return RedirectToAction("Index", "AdminUsuarios");


            }

            return View(model);
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}