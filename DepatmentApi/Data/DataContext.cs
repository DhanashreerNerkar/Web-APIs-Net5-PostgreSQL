using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DepatmentApi.Models;

namespace DepatmentApi.Data
{
    public class DataContext:DbContext,IDataContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
             
        }
 
        public DbSet<Department> Departments { get; init; }
    }
}