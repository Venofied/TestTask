using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Data;
using TestTask.interfaces;
using TestTask.models;

namespace TestTask.PostgreRepository
{

    public interface IDepartmentRepository : IRepository<Department>
    {

    }
    public class DepartmentPostgre : IDepartmentRepository
    {
        DB db;// = new DB();

        public void Create(Department item)
        {
            using (db = new DB())
            {
                item.ID = db.Departments.OrderBy(i => i.ID).Select(i => i.ID).LastOrDefault() + 1;
                db.Departments.Add(item);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (db = new DB())
            {
                Department department = new Department();
                department = db.Departments.Where(d => d.ID == id).FirstOrDefault();
                db.Departments.Remove(department);
                db.SaveChanges();
            }
        }

        public IList<Department> GetAll()
        {
            List<Department> list = new List<Department>();
            using (db = new DB())
            {
                list = db.Departments.OrderBy(l => l.ID).ToList();
            }
            return list;
        }

        public Department GetById(int id)
        {
            Department department = new Department();
            using (db = new DB())
            {
                department = db.Departments.Where(d => d.ID == id).First();
            }
            return department;
        }

        public void Update(Department item)
        {
            using (db = new DB())
            {
                db.Departments.Update(item);
                db.SaveChanges();
            }
        }
        public Department TakeDep(int id)
        {
            Department department = new Department();
            using (db = new DB())
            {
                department = db.Departments.Where(d => d.ID == id).First();
            }
            return department;
        }
    }
}
