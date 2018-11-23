using LPDemo.EntityFramework;
using EntityFramework.DynamicFilters;

namespace LPDemo.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly LPDemoDbContext _context;

        public InitialHostDbBuilder(LPDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
