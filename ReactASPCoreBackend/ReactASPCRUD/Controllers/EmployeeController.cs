using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReactASPCRUD.Models;
namespace ReactASPCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly EmployeeDbContext _employeeDbContext;

        public EmployeeController(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }

        [HttpPost]
        [Route("AddEmployee")]

        public async Task<Employee> AddEmployee(Employee objEmployee)
        {
            _employeeDbContext.Employee.Add(objEmployee);
            await _employeeDbContext.SaveChangesAsync();
            return objEmployee;
        }

        [HttpGet]
        [Route("GetEmployee")]
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _employeeDbContext.Employee.ToListAsync();
        }

    }
}
