using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using LPDemo.EntityFramework;

namespace LPDemo.Migrator
{
    [DependsOn(typeof(LPDemoDataModule))]
    public class LPDemoMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<LPDemoDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}