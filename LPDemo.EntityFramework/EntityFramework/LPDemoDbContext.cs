using System.Data.Common;
using System.Data.Entity;
using System.Threading.Tasks;
using Abp.Zero.EntityFramework;
using LPDemo.Authorization.Roles;
using LPDemo.Authorization.Users;
using LPDemo.Entities;
using LPDemo.MultiTenancy;

namespace LPDemo.EntityFramework
{
    public class LPDemoDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public LPDemoDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in LPDemoDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of LPDemoDbContext since ABP automatically handles it.
         */
        public LPDemoDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public LPDemoDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public LPDemoDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        public IDbSet<Student> student { get; set; }
    }
}
