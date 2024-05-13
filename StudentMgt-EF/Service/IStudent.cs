using StudentMgt_EF.ModelEntity;

namespace StudentMgt_EF.Service
{
    public interface IStudent
    {
        public List<Student> GetAllStudents();
        public Student GetStudentById(int id);
        public List<Student>FilterStudentByAge(int age);
        public List<Student> SearchStudentByName(string name);
        public void AddStudent(Student student);
        public void UpdateStudent(Student student);
        
        public void UpdateAge(int id, int age);
        public void DeleteStudent(int id);


    }
}
