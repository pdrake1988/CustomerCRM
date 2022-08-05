using Microsoft.AspNetCore.Mvc;
using Antra.CustomerCRM.WebAppMVC.Models;
using CustomerCrm.Core.Contracts.Services;
using CustomerCrm.Core.Models;

namespace Antra.CustomerCRM.WebAppMVC.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeServiceAsync employeeServiceAsync;

        public EmployeeController(IEmployeeServiceAsync employeeService)
        {
            this.employeeServiceAsync = employeeService;
        }

        public async Task<ActionResult> Index()
        {
            return View(await employeeServiceAsync.GetAllEmployeesAsync());
        }
        [HttpGet]
        public ActionResult Create()
        {
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