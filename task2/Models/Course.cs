using System.ComponentModel.DataAnnotations.Schema;

namespace task2.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Degree { get; set; }

        public int CreditHours { get; set; }

        public int MinDegree { get; set; }


        [ForeignKey("Department")]
        public int dept_id { get; set; }

        public Department Department { get; set; }


    }
}
