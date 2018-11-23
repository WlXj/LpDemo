using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPDemo.Entities
{
    [Table("SFStudents")]
    public class Student : Entity, IHasCreationTime
    {
      
        public string Name { get; set; }
   
        public string Birthday { get; set; }
      
        public string Hobbies { get; set; }
       
        public DateTime CreationTime { get; set; }


        public Student()
        {
            CreationTime = Clock.Now;

        }

        public Student(string name, string description = null) : this()
        {
            Name = name;
        }
      
    }
}
