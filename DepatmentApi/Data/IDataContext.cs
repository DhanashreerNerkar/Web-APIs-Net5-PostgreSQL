using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DepatmentApi.Models;

namespace DepatmentApi.Data
{
    public interface IDataContext
    {
         DbSet<Department> Departments { get; init; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}

