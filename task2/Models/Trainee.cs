using System.ComponentModel.DataAnnotations.Schema;

namespace task2.Models
{
    public class Trainee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Imag { get; set; }

        public string Address { get; set; }

        public int grade { get; set; }


        [ForeignKey("Department")]

        public int dept_id { get; set; }

        public Department Department { get; set; }


    }
}
