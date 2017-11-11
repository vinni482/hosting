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

		string ByteToString(byte[] buff)
		{
			string sbinary = "";
			for (int i = 0; i < buff.Length; i++)
				sbinary += buff[i].ToString("X2"); /* hex format */
			return sbinary;
		}

		public string Hash(string value)
		{
			UTF8Encoding encoding = new UTF8Encoding();
			return ByteToString(new HMACMD5(encoding.GetBytes("flk3409refn54t54t*FNJRET")).ComputeHash(encoding.GetBytes(value)));
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