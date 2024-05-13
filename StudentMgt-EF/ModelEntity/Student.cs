using System.ComponentModel.DataAnnotations;

namespace StudentMgt_EF.ModelEntity
{
    public class Student
    {
        [Key]
       public int? Student_id {  get; set; }
        public string Student_name { get; set; }
        public int Student_age { get; set; }
        public string Student_dep { get; set; }
    }
}
