using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using Sa_pro_chefe.Models;

namespace Sa_pro_chefe.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
    public class AdmController : Controller
    {
        // GET: Adm
        public ActionResult Index()
        {
            using (pro_chef_webEntities bd = new pro_chef_webEntities())
            {
                return View();
            }
        }
    }
}