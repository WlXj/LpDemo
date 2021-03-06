using System.Linq;
using LPDemo.EntityFramework;
using LPDemo.MultiTenancy;

namespace LPDemo.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly LPDemoDbContext _context;

        public DefaultTenantCreator(LPDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
