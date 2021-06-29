using System.Threading.Tasks;

namespace Avanade.SubTCS.Projeto.Domain.Aggregates.Employee.Interfaces.Services
{
    public interface IEmployeeService
    {
        Task<Entities.Employee> AddEmploye(Entities.Employee employee);
    }
}
