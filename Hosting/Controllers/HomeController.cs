using Models.ViewModels.Home;
using Models.Shared;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Hosting.Controllers
{
    public class HomeController : BaseController
    {
        private readonly HostingPlansService _hostingPlansService;

        public HomeController()
        {
            _hostingPlansService = new HostingPlansService();
        }

        public async Task<ActionResult> Index()
        {
            return View(new IndexViewModel
            {
                HostingPlans = await _hostingPlansService.GetHostingPlansAsync()
            });
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
    }
}