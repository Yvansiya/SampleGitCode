using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Yatik_Task4.Models;
using Yatik_Task4.DataRepository;
using System.Data;

namespace Yatik_Task4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICenterMasterRepository _ICenterMasterRepository;
    
        public HomeController(ILogger<HomeController> logger,ICenterMasterRepository centerMasterRepository)
        {
            _logger = logger;
            _ICenterMasterRepository=centerMasterRepository;
        }

        public IActionResult Index()
        {
            List<Center_Master> center_Master=new List<Center_Master>();
            center_Master=  _ICenterMasterRepository.GetCenterMasterData();
            ViewBag.cntcount = center_Master.Count();
            return View(center_Master);
        }
        public IActionResult Privacy()
        {
            List<Center_Master> center_Master=new List<Center_Master>();
            center_Master= _ICenterMasterRepository.GetCenterMasterDataStoredProcedureWithCommon();
            return View(center_Master);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
