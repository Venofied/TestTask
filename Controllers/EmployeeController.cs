using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TestTask.models;
using TestTask.PostgreRepository;

namespace TestTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        EmployeePostgre employee = new EmployeePostgre();
        [HttpGet]
        public IEnumerable<Employee> GetList()
        {
            return employee.GetAll();
        }
        [HttpGet("Index")]
        public IActionResult Index()
        {
            IEnumerable<Employee> d = employee.GetAll();
            return View(d);
        }
        [HttpGet("IndexDepartment/{id}")]
        public ActionResult IndexDepartment([FromForm] int id, int IdDep)
        {
            ViewBag.nameDepartment = employee.GetDepartmentName(IdDep);            
            IEnumerable<Employee> listEmployees = employee.GetEmployeeDepartment(IdDep);
            ViewBag.middleSalary = employee.MiddleSalary(listEmployees.ToList());
            return View(listEmployees);
        }
        [HttpPost("Index")]
        public ActionResult Delete([FromForm] int id)
        {
            employee.Delete(id);
            return RedirectToAction("Index");
        }


        [HttpGet("Create")]
        public IActionResult Create()
        {
            ViewBag.Departs = employee.ListDepartments();
            return View();
        }
        [HttpPost]
        public ActionResult CreateEmp([FromForm]  Employee _employee)
        {
            employee.Create(_employee);
            return RedirectToAction("Create");
        }
        [HttpGet("Edit/{id}")]
        public ActionResult Edit([FromForm] int id, int IdEmp)
        {
            if (IdEmp != 0)
            {
                Employee _dep = employee.GetEmployee(IdEmp);
                if (_dep != null)
                {
                    ViewBag.Departs = employee.ListDepartments();
                    return View(_dep);
                }
            }
            return NotFound();
        }
        [HttpPost("EditEmp")]
        public ActionResult EditEmp([FromForm] Employee user)
        {
            employee.Update(user);
            return RedirectToAction("Index");
        }
    }
}