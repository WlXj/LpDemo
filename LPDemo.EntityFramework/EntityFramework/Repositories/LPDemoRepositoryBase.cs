using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace LPDemo.EntityFramework.Repositories
{
    public abstract class LPDemoRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<LPDemoDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected LPDemoRepositoryBase(IDbContextProvider<LPDemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class LPDemoRepositoryBase<TEntity> : LPDemoRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected LPDemoRepositoryBase(IDbContextProvider<LPDemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
