using Hosting.Models.Home;
using Hosting.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hosting.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.HostingPlans = new List<Models.Shared.HostingPlanModel>();
            List<FeatureModel> features = new List<FeatureModel>();
            features.Add(new FeatureModel
            {
                Name = "10 GB"
            });
            features.Add(new FeatureModel
            {
                Name = "1 MS SQL Server"
            });
            model.HostingPlans.Add(new Models.Shared.HostingPlanModel
            {
                Name = "Минимум",
                Price = 39.99m,
                Description = "Всё необходимое для старта",
                Features = features
            });

            List<FeatureModel> features2 = new List<FeatureModel>();
            features2.Add(new FeatureModel
            {
                Name = "20 GB"
            });
            features2.Add(new FeatureModel
            {
                Name = "2 MS SQL Server"
            });
            model.HostingPlans.Add(new Models.Shared.HostingPlanModel
            {
                Name = "Стандарт",
                Price = 69.99m,
                Description = "Самый оптимальный пакет",
                Features = features2
            });

            List<FeatureModel> features3 = new List<FeatureModel>();
            features3.Add(new FeatureModel
            {
                Name = "50 GB"
            });
            features3.Add(new FeatureModel
            {
                Name = "5 MS SQL Server"
            });
            model.HostingPlans.Add(new Models.Shared.HostingPlanModel
            {
                Name = "Профи",
                Price = 109.99m,
                Description = "Отличный выбор для профессионалов",
                Features = features3
            });
            return View(model);
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