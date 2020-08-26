using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using wan_at1_oop.Shared.Models;

namespace wan_at1_oop.Server.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController: ControllerBase
    {
        private readonly ApplicationDbContext context;

        public EmployeesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Technician>>> GetAllEmployee()
        {
            return await context.Employees.ToListAsync();
        }

        [HttpGet("{id}", Name = "GetEmployee")]
        public async Task<ActionResult<Technician>> GetEmployee(int id)
        {
            return await context.Employees.FirstOrDefaultAsync(x => x.EmployeeId == id);
        }

        [HttpPost]
        public async Task<ActionResult> CreateEmployee(Technician employee)
        {
            context.Employees.Add(employee);
            await context.SaveChangesAsync();
            return new CreatedAtRouteResult("GetEmployee", new { id = employee.EmployeeId }, employee);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateEmployee(Technician employee)
        {
            context.Entry(employee).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteEmployee(int id)
        {
            var employee = new Technician { EmployeeId = id };
            context.Employees.Remove(employee);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
