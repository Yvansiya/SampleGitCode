using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Yatik_Task4.Models;
using Yatik_Task4.DataRepository;

namespace Yatik_Task4.Controllers
{
    public class CenterMasterController: Controller
    {
        private readonly ICenterMasterRepository _ICenterMasterRepository;
        public CenterMasterController(ICenterMasterRepository centerMasterRepository)
        {
            _ICenterMasterRepository=centerMasterRepository;
        }
        public IActionResult UsingEF()
        {
            List<Center_Master> center_Master=new List<Center_Master>();
            center_Master=  _ICenterMasterRepository.GetCenterMasterData();
            ViewBag.cntcount = center_Master.Count();
            return View(center_Master);
        }
        public IActionResult UsingSP()
        {
            List<Center_Master> center_Master=new List<Center_Master>();
            center_Master= _ICenterMasterRepository.GetCenterMasterDataStoredProcedureWithCommon();
            return View(center_Master);
        }
        [HttpGet]
        public IActionResult CenterMasterEntry()
        {

            List<Center_Master> center_Master=new List<Center_Master>();
            
            center_Master= _ICenterMasterRepository.GetCenterMasterDataStoredProcedureWithCommon();
            return View(center_Master);
        }
        [HttpPost]
        public IActionResult CenterMasterEntry(Center_Master center_Master)
        {
            // List<Center_Master> center_Master=new List<Center_Master>();
            // center_Master= _ICenterMasterRepository.GetCenterMasterDataStoredProcedureWithCommon();
            return View(center_Master);
        }
    }
}
