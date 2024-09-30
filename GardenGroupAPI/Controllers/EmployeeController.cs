using DAL;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace GardenGroupAPI.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly EmployeeDao _employeeDao;

        public EmployeeController(EmployeeDao employeeDao)
        {
            _employeeDao = employeeDao;
        }

        [HttpGet]
        public async Task<List<Employee>> Get()
        {
            return await _employeeDao.GetAllEmployeesAsync();
        }
    }
}