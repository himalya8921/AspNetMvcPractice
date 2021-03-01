using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationDemo.Models;

namespace WebApplicationDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        List<EmployeeViewModel> employeeList;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            employeeList = new List<EmployeeViewModel>();

            employeeList.Add(new EmployeeViewModel
            {
                Id = 1,
                Name = "First User",
                Age = "20",
                Salary="10000",
                Designation="intern",
                Gender = 1

            });

            employeeList.Add(new EmployeeViewModel
            {
                Id = 2,
                Name = "Second User",
                Age = "20",
                Salary = "20000",
                Designation = "junior",
                Gender = 1
            });

            employeeList.Add(new EmployeeViewModel
            {
                Id = 3,
                Name = "Third User",
                Age = "30",
                Salary = "30000",
                Designation = "senior",
                Gender = 2
            });

        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Index()
        {
           // return View();

            return RedirectToAction("Employee", "Home");
        }


        public IActionResult Employee()
        {
            return View(employeeList);
        }

        public IActionResult IndexActionResult()
        {
            return View("Index");
        }

        public JsonResult JsonActionResult()
        {
            return Json(employeeList);
        }

        public EmployeeViewModel GetResult()
        {
            return new EmployeeViewModel { Name = "abc" , Age="9" , Designation = "intern", Id = 1, Salary = "11"};
        }

        public int IntResult()
        {
            return 2;
        }

        public string StringResult()
        {

             return "Hello";
            //return YouShallNotPass();
        }

        [NonAction]
        public EmployeeViewModel YouShallNotPass()
        {
            return new EmployeeViewModel { Name = "abc", Age = "9", Designation = "intern", Id = 1, Salary = "11" };
        }





        public IActionResult Privacy()
        {
            return View();
        }


        [HttpGet]
        public IActionResult EditEmployee(long id)
        {
            return View("_EditEmployeePartial", employeeList.FirstOrDefault(x=>x.Id == id)) ;
        }


        //[HttpPost]
        //public IActionResult EditEmployee(EmployeeViewModel model)
        //{
        //    employeeList.RemoveAt(employeeList.IndexOf(employeeList.FirstOrDefault(x => x.Id == model.Id)));
        //    employeeList.Add(model);
        //    return RedirectToAction(nameof(Employee));
        //}


        [HttpPost]
        public IActionResult EditEmployee(EmployeeViewModel model)
                {
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(Employee));
            }
            else
                return View("_EditEmployeePartial", model);
        
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
