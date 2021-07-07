using Avanade.SubTCS.Projeto.Data.Repositories.Base;
using Avanade.SubTCS.Projeto.Domain.Aggregates.Employee.Interfaces.Repositories;

namespace Avanade.SubTCS.Projeto.Data.Repositories.Employee
{
    public class EmployeeRepository : BaseRepository<Domain.Aggregates.Employee.Entities.Employee, string>, IEmployeeRepository
    {

    }
}
