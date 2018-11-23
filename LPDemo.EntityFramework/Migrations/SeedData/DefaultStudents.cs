using LPDemo.Entities;
using LPDemo.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPDemo.Migrations.SeedData
{
    public class DefaultStudents
    {
        private readonly LPDemoDbContext _context;

        private static readonly List<Student> _tasks;

        public DefaultStudents(LPDemoDbContext context)
        {
            _context = context;
        }

        static DefaultStudents()
        {
            _tasks = new List<Student>()
            {
                new Student("Learning ABP deom", "Learning how to use abp framework to build a MPA application."),
                new Student("Make Lunch", "Cook 2 dishs")
            };
        }

        public void Create()
        {
            foreach (var task in _tasks)
            {
                if (_context.student.FirstOrDefault(t => t.Name == task.Name) == null)
                {
                    _context.student.Add(task);
                }
                _context.SaveChanges();
            }
        }
    }
}
