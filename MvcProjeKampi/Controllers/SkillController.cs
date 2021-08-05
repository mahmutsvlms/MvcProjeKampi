using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class SkillController : Controller
    {
        SkillManager sk = new SkillManager(new EfSkillDal());
        // GET: Skill
        public ActionResult Index()
        {
            return View(sk.GetList());
        }
    }
}