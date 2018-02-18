using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SamerCs.Authorization.Roles;
using SamerCs.Authorization.Users;
using SamerCs.MultiTenancy;

namespace SamerCs.EntityFrameworkCore
{
    public class SamerCsDbContext : AbpZeroDbContext<Tenant, Role, User, SamerCsDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<TaskModel.Task> Tasks { get; set; }

        public SamerCsDbContext(DbContextOptions<SamerCsDbContext> options)
            : base(options)
        {
        }
    }
}
