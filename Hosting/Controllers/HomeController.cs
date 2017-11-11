using Models.ViewModels.Home;
using Models.Shared;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Security.Cryptography;
using System.Text;

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

		public string Hash(string value)
		{
			UTF8Encoding encoding = new UTF8Encoding();
			return Convert.ToBase64String(new HMACMD5(encoding.GetBytes("flk3409refn54t54t*FNJRET")).ComputeHash(encoding.GetBytes("test_merch_n1www.market.uaSimpleSignatureDH78302314153798631547.36UAHПроцессор Intel Core i5-4670 3.4GHz10001ВасяВасечкинsome@mail.com380631234567")));
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