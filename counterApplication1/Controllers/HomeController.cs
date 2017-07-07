using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using counterApplication1.Models;

namespace counterApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult CounterIndex()
        {
            Counter counter = new Counter();

            using (EntityModel entity = new EntityModel())
            {
                counter = entity.Counters.OrderBy(o => o.Id).FirstOrDefault();
            }

            return View(counter);
        }

        [HttpPost]
        public ActionResult CounterIndex(FormCollection collection)
        {
            int counterid = Convert.ToInt32(collection["IdValue"]);
            counterid++;
            if (counterid > 10)
            {
                counterid = 1;
            }

            Counter newCounter = new Counter();
            using (EntityModel entity = new EntityModel())
            {
                newCounter = entity.Counters.Where(f => f.Id == counterid).FirstOrDefault();
            }
            
           
            return View(newCounter);
        }
    }
}