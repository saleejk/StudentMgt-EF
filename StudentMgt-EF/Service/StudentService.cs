using Microsoft.EntityFrameworkCore;
using StudentMgt_EF.Data;
using StudentMgt_EF.ModelEntity;

namespace StudentMgt_EF.Service
{
    public class StudentService:IStudent
    {

        private readonly DbContextClass _dbContextClass;
        public StudentService(DbContextClass dbContextCls)
        {
            _dbContextClass = dbContextCls;
        }

        public List<Student> GetAllStudents()
        {
            var AllStudents=_dbContextClass.newStudents.ToList();
            return AllStudents;
        }
        public Student GetStudentById(int id)
        {
            var studentt = _dbContextClass.newStudents.FirstOrDefault(x => x.Student_id == id);
            return studentt;
        }
        public List<Student> FilterStudentByAge(int age)
        {
            var ageFiltered = _dbContextClass.newStudents.Where(x => x.Student_age == age);
            return ageFiltered.ToList();
        }
        public List<Student> SearchStudentByName(string name)
        {
            var searchStudent = _dbContextClass.newStudents.Where(x => x.Student_name.StartsWith(name));
            return searchStudent.ToList();

        }

        public void AddStudent(Student student)
        {
            var sal = _dbContextClass.newStudents.Add(student);
            

            _dbContextClass.SaveChanges();
        }
        public void UpdateStudent(Student student)
        {
            var updateStudents = _dbContextClass.newStudents.FirstOrDefault(x => x.Student_id == student.Student_id);
            updateStudents.Student_name = student.Student_name;
            updateStudents.Student_age = student.Student_age;
            updateStudents.Student_dep = student.Student_dep;
            _dbContextClass.SaveChanges();
        }
        public void UpdateAge(int id, int age)
        {
            var updateAge=_dbContextClass.newStudents.FirstOrDefault(x=>x.Student_id==id);
            updateAge.Student_age = age;
            _dbContextClass.SaveChanges();
        }
        public void DeleteStudent(int id)
        {
            var deleteStd = _dbContextClass.newStudents.FirstOrDefault(x => x.Student_id == id);
            if (deleteStd != null)
            {
                _dbContextClass.Remove(deleteStd);
            }
               _dbContextClass.SaveChanges();
        }
    }
}


