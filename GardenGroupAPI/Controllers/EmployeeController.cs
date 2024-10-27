using Microsoft.AspNetCore.Mvc;
using Model;
using Service;

namespace GardenGroupAPI.Controllers
{
    [Controller]
    [Route("api/employee")]
    public class EmployeeController : Controller
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<List<Employee>> Get()
        {
            return await _employeeService.GetAllEmployeesAPI();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Employee employee)
        {
            await _employeeService.CreateEmployeeAsync(employee);
            return CreatedAtAction(nameof(Get), new { id = employee.EmployeeId }, employee);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] Employee employee)
        {
            await _employeeService.UpdateEmployeeAPI(id, employee);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _employeeService.DeleteEmployeeByID(id);
            return NoContent();
        }
    }
}