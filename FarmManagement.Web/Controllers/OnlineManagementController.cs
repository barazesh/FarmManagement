using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FarmManagement.Web.Models;
using FarmManagement.Web.Services;

namespace FarmManagement.Web.Controllers
{
    public class OnlineManagementController : Controller
    {
        private readonly IFarmManager _farmManager;
        public OnlineManagementController(IFarmManager farmManager)
        {
            _farmManager = farmManager;
        }
        [HttpGet]
        public IActionResult Status()
        {
            IEnumerable<ContactorStatusViewModel> currentstatus = _farmManager.GetCurrentStatus();
            return View(currentstatus);
        }

        [HttpGet]
        public IActionResult Control()
        {
            IEnumerable<ContactorStatusViewModel> currentstatus = _farmManager.GetCurrentStatus();
            return View(currentstatus);
        }

        [HttpPost]
        public IActionResult Control(IEnumerable<ContactorStatusViewModel> model)
        {
            bool success = _farmManager.UpdateContactorStates(model);
            if (true)
            {
                return RedirectToAction("Status");
            }

        }
    }
}
