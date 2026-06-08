using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace task2.Models
{
    public class instructor
    {
        public int Id { get; set; }

        public string Imag { get; set; }

        public string Name { get; set; }

        public int Salary { get; set; }

        public string Address { get; set; }

        [ForeignKey("Department")]
        public int dept_id { get; set; }
        public Department Department { get; set; }

        [ForeignKey("Course")]
        public int course_id { get; set; }

        public Course Course { get; set; }


    }
}
