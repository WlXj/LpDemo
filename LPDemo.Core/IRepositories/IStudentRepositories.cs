using Abp.Domain.Repositories;
using LPDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPDemo.IRepositories
{
    public interface IStudentRepositories : IRepository<Student>
    {
        List<Student> GetStudentByName(string name);
    }
}
