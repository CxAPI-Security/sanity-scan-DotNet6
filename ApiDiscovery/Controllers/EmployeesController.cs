using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ApiDiscovery.App_Data;
using ApiDiscovery.Models;

namespace ApiDiscovery.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (var dbContext = new EmployeeDbContext())
            {
                return dbContext.Employees.ToList();
            }
        }

        public IHttpActionResult Get(int id)
        {
            using (var dbContext = new EmployeeDbContext())
            {
                var entity = dbContext.Employees.FirstOrDefault(e => e.Id == id);

                if (entity == null)
                    return NotFound();

                return Ok(entity);
            }
        }

        public void Post([FromBody] Employee employee)
        {
            using (var dbContext = new EmployeeDbContext())
            {
                dbContext.Employees.Add(employee);
                dbContext.SaveChanges();
            }
        }

        public void Put(int id, [FromBody] Employee employee)
        {
            using (var dbContext = new EmployeeDbContext())
            {
                var entity = dbContext.Employees.FirstOrDefault(e => e.Id == id);

                entity.FirstName = employee.FirstName;
                entity.LastName = employee.LastName;
                entity.Gender = employee.Gender;
                entity.Salary = employee.Salary;

                dbContext.SaveChanges();
            }
        }

        public IHttpActionResult Delete(int id)
        {
            try
            {
                using (var dbContext = new EmployeeDbContext())
                {
                    var entity = dbContext.Employees.FirstOrDefault(e => e.Id == id);
                    if (entity == null) return NotFound();

                    dbContext.Employees.Remove(entity);
                    dbContext.SaveChanges();
                    return Ok();
                }
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
        
        [HttpGet]
        public IHttpActionResult LoadAllEmployees()
        {
            using (var dbContext = new EmployeeDbContext())
            {
                var employees = dbContext.Employees.ToList();
                return Ok(employees);
            }
        }

        [HttpGet]
        public IHttpActionResult LoadAllMaleEmployees()
        {
            using (var dbContext = new EmployeeDbContext())
            {
                var employees = dbContext.Employees.Where(x => x.Gender == "Male").ToList();
                return Ok(employees);
            }
        }

        [HttpGet]
        [ActionName("Email")]
        public IEnumerable<Employee> FetchEmployeeEmail()
        {
            using (var dbContext = new EmployeeDbContext())
            {
                var employees = dbContext.Employees.ToList();

                return employees;
            }
        }
        
    }
}