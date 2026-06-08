using System.ComponentModel.DataAnnotations.Schema;

namespace task2.Models
{
    public class crsResult
    {
        public int Id { get; set; }

        public int degree { get; set; }

        [ForeignKey("Course")]
        public int course_id { get; set; }
        public Course Course { get; set; }
        [ForeignKey("Trainee")]
        public int trainee_id { get; set; }
        public Trainee Trainee { get; set; }


    }
}
