using Avanade.SubTCS.Projeto.Application.Dtos.EmployeeRole;
using System.Threading.Tasks;

namespace Avanade.SubTCS.Projeto.Application.Interfaces.EmployeeRole
{
    public interface IEmployeeRoleAppService
    {
        Task<EmployeeRoleDto> AddEmployeeRoleService(EmployeeRoleDto employeeRoleDto);
    }
}
