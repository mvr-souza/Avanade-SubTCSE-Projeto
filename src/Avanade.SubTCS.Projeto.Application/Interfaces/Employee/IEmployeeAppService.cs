using System.Threading.Tasks;

namespace Avanade.SubTCS.Projeto.Application.Interfaces.Employee
{
    public interface IEmployeeAppService
    {
        public Task<Dtos.Employee.EmployeeDto> addEmployeeService(Dtos.Employee.EmployeeDto employeeDto);
    }
}
