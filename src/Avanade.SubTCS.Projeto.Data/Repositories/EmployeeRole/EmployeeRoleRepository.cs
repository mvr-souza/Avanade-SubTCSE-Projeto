using Avanade.SubTCS.Projeto.Data.Repositories.Base;
using Avanade.SubTCS.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Repositories;

namespace Avanade.SubTCS.Projeto.Data.Repositories.EmployeeRole
{
    public class EmployeeRoleRepository : BaseRepository<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole, string>, IEmployeeRoleRepository
    {

    }
}
