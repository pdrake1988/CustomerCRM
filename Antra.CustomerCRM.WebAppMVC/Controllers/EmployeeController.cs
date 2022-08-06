using Microsoft.AspNetCore.Mvc;
using Antra.CustomerCRM.WebAppMVC.Models;
using CustomerCrm.Core.Contracts.Services;
using CustomerCrm.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Antra.CustomerCRM.WebAppMVC.Controllers
{
    public class EmployeeController : Controller
    {
        IRegionServiceAsync regionServiceAsync;
        IEmployeeServiceAsync employeeServiceAsync;

        public EmployeeController(IEmployeeServiceAsync employeeService, IRegionServiceAsync regionService)
        {
            this.employeeServiceAsync = employeeService;
            this.regionServiceAsync = regionService;
        }

        public async Task<ActionResult> Index()
        {
            return View(await employeeServiceAsync.GetAllEmployeesAsync());
        }
        [HttpGet]
        public async Task<ActionResult> Create()
        {
            ViewBag.Regions = new SelectList(await regionServiceAsync.GetAllRegions(), "Id", "Name");
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(EmployeeModel model)
        {
            await employeeServiceAsync.InsertEmployeeAsync(model);
            return RedirectToAction("Index");
        }
    }
}