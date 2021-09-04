using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Data;
using TestTask.interfaces;
using TestTask.models;

namespace TestTask.PostgreRepository
{
    public interface IEmployeePostgre : IRepository<Employee>
    {

    }
    public class EmployeePostgre : IEmployeePostgre
    {
        DB db;
        public void Create(Employee item)
        {
            using (db = new DB())
            {
                item.ID = db.Employees.OrderBy(i => i.ID).Select(i => i.ID).LastOrDefault() + 1;
                if (item.Id_department < 1)
                {
                    item.Id_department = 1;
                }
                item.Name_department = db.Departments.Where(i => i.ID == item.Id_department).Select(i => i.Name).FirstOrDefault();
                db.Employees.Add(item);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (db = new DB())
            {
                Employee employee = new Employee();
                employee = db.Employees.Where(d => d.ID == id).FirstOrDefault();
                db.Employees.Remove(employee);
                db.SaveChanges();
            }
        }

        public IList<Employee> GetAll()
        {
            List<Employee> list = new List<Employee>();
            using (db = new DB())
            {
                list = db.Employees.OrderBy(l => l.ID).ToList();
            }
            return list;
        }

        public IList<Employee> GetEmployeeDepartment(int id)
        {
            List<Employee> list = new List<Employee>();
            using (db = new DB())
            {
                list = db.Employees.Where(l => l.Id_department == id).OrderBy(l => l.ID).ToList();
            }
            return list;
        }

        public Employee GetById(int id)
        {
            Employee employee = new Employee();
            using (db = new DB())
            {
                employee = db.Employees.Where(d => d.ID == id).First();
            }
            return employee;
        }

        public void Update(Employee item)
        {
            using (db = new DB())
            {                
                item.Name_department = db.Departments.Where(i => i.ID == item.Id_department).Select(i => i.Name).FirstOrDefault();
                db.Employees.Update(item);
                db.SaveChanges();
            }
        }

        public Employee GetEmployee(int id)
        {
            Employee employee = new Employee();
            using (db = new DB())
            {
                employee = db.Employees.Where(d => d.ID == id).First();
            }
            return employee;
        }
        public SelectList ListDepartments()
        {
            SelectList listItems;
            db = new DB();
            listItems = new SelectList(db.Departments, "ID", "Name");
            return listItems;
        }
        public string GetDepartmentName(int id)
        {
            string name = string.Empty;
            using (db = new DB())
            {
                name = db.Departments.Where(d => d.ID == id).Select(d => d.Name).FirstOrDefault();
            }
            return name;
        }
        
        public int MiddleSalary(IList<Employee> employees)
        {
            int sum = employees.Sum(e => e.Salary);

            int middleSalary = sum / employees.Count;
            return middleSalary;
        }
    }
}
