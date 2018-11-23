using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPDemo.Students.Dto
{
    class StudentDto
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// 学号
        /// </summary>
        [Required]
        [StringLength(20)]
        public string StudentId { get; set; }
    }
}
