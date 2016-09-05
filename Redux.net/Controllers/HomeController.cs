using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Redux.net.Actions;
using Redux.net.Models;

namespace Redux.net.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var state = App.CounterStore.GetState();
            if (state == 0)
            {
                var model = new CounterModel();
                App.CounterStore.Subscribe(counter => model.Text = counter.ToString());
                ViewBag.Text = model.Text;
            }
            else
            {
                ViewBag.Text = state.ToString();
            }
            
            return View();
        }

        public ActionResult ClickUp()
        {
            App.CounterStore.Dispatch(new IncrementAction());
            return RedirectToAction("Index");
        }
    }
}