using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReportEmployeeSalary.Controllers
{
    public class EmployeeController : Controller
    {
        BusinessLayer.EmployeeBL objEmployeeBL = new BusinessLayer.EmployeeBL();
        // GET: Employee

        public ActionResult Index()
        {
            
            return View(objEmployeeBL.GetEmployees().ToList());
        }

        [HttpPost]
        public ActionResult Index(int? id)
        {
            List<Employee> lstEmployee = new List<Employee>();

            if (id == null)
                lstEmployee = objEmployeeBL.GetEmployees().ToList();
            else
            {
                Employee objEmloyee = objEmployeeBL.GetEmployees((int)id);
                if (objEmloyee != null)
                    lstEmployee.Add(objEmloyee);
            }

            return View(lstEmployee);
        }

       
    }
}
