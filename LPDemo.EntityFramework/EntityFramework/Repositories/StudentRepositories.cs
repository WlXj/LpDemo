using Abp.EntityFramework;
using LPDemo.Entities;
using LPDemo.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPDemo.EntityFramework.Repositories
{
    public class StudentRepositories : LPDemoRepositoryBase<Student>, IStudentRepositories
    {

        public StudentRepositories(IDbContextProvider<LPDemoDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }


        public List<Student> GetStudentByName(string name)
        {
            var query = GetAll();

            if (name != null)
            {
                query = query.Where(t => t.Name == name);
            }

            return query.ToList();
        }

    }
}
