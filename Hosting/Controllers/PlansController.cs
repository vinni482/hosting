using Models.ViewModels.Plans;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Hosting.Controllers
{
    public class PlansController : BaseController
    {
        private readonly HostingPlansService _hostingPlansService;

        public PlansController()
        {
            _hostingPlansService = new HostingPlansService();
        }

        public async Task<ActionResult> Select(int id)
        {
            return View(new SelectViewModel
            {
                HostingPlan = await _hostingPlansService.GetHostingPlanByIdAsync(id)
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Checkout(SelectViewModel model)
        {

            return View();
        }
    }
}