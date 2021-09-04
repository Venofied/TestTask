using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TestTask.Data;
using TestTask.models;
using TestTask.PostgreRepository;

namespace TestTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : Controller
    {
        DepartmentPostgre department = new DepartmentPostgre();
        [HttpGet]
        public IEnumerable<Department> GetList()
        {
            return department.GetAll();
        }
        [HttpGet("Index")]
        public IActionResult Index()
        {
            IEnumerable<Department> d = department.GetAll();
            return View(d);
        }
        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateDep([FromForm] string nameDep)
        {
            Department _department = new Department();
            _department.Name = nameDep;
            department.Create(_department);
            return View("Create");
        }
        [HttpGet("Edit/{id}")]
        public ActionResult Edit([FromForm] int id,  int IdDep)
        {
            if (IdDep != 0)
            {
                Department _dep = department.TakeDep(IdDep);
                if (_dep != null)
                {
                    ViewBag.nameDepartment = _dep.Name;
                    return View(_dep);
                }
            }
            return NotFound();
        }
        [HttpPost("EditDep")]
        public ActionResult EditDep([FromForm] Department user)
        {
            department.Update(user);
            return RedirectToAction("Index");
        }
        [HttpPost("Index")]
        public ActionResult Delete([FromForm] int id)
        {
            department.Delete(id);
            return RedirectToAction("Index");
        }

    }
}