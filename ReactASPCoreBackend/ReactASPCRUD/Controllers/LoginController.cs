using Microsoft.AspNetCore.Mvc;
using ReactASPCRUD.Models;

namespace ReactASPCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly EmployeeDbContext _employeeDbContext;

        public LoginController(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }

        [HttpPost]
        [Route("PostLoginDetails")]
        public async Task<IActionResult> PostLoginDetails(Employee _empData)
        {
            if(_empData != null)
            {
                var resultLoginCheck = _employeeDbContext.Employee
                    .Where(e => e.email == _empData.email && e.password== _empData.password)
                    .FirstOrDefault();
                if (resultLoginCheck == null)
                {
                    return BadRequest("Invalid credentials");
                }
                else
                {
                    var dataLinq = from e in _employeeDbContext.Employee
                                   where e.email == _empData.email 
                                    select e;

                    return Ok(dataLinq);
                }
            }
            else
            {
                return BadRequest("No Data Posted");
            }
        }

    }
}
