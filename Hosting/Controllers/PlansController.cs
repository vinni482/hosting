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

        public async Task<ActionResult> Select()
        {
			return View(new SelectViewModel());
        }

		public async Task<PartialViewResult> SeletedPlansAjax(List<string> ids)
		{
			var model = await _hostingPlansService.GetHostingPlansAsync();
			return PartialView("HostngPlansListPartial", model);
		}

		[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Checkout(SelectViewModel model)
        {
			
            return View();
        }
    }
}