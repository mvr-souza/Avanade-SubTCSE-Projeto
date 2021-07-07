using System.Threading.Tasks;

namespace Avanade.SubTCS.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Repositories
{
    public interface IEmployeeRoleRepository : IBaseRepository<Entities.EmployeeRole, string>
    {
        public Task<Entities.EmployeeRole> Add(Entities.EmployeeRole employeeRole);
    }
}
