using DAL;
using Model;

namespace Service
{
    public class EmployeeService
    {
        private readonly EmployeeDao _employeeDao = new();

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await _employeeDao.GetAllEmployeesAsync();
        }
    }
}