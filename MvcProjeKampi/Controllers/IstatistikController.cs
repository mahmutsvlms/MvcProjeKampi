using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class IstatistikController : Controller
    {
        // GET: Istatistik
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        public ActionResult Index()
        {
            ViewBag.CategoryCount = cm.GetList().Count();
            ViewBag.HeadlineOfSoftware = hm.GetList().Where(x => x.CategoryID == 16).Count();
            ViewBag.AuthorGetByWord = wm.GetList().Where(x => x.WriterName.ToLower().Contains('a')).Count();
            ViewBag.StatusDifference = 
                cm.GetList().Count(x => x.CategoryStatus == true) -
                cm.GetList().Count(x => x.CategoryStatus == false);
            Context context = new Context();
            ViewBag.MaxHeadline = context.Headings.Max(x => x.Category.CategoryName);
            return View();
        }
    }
}