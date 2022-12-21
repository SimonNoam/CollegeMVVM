using ExerciseOnData.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOnData.Services
{

    public class DataService
    {
        private readonly SchoolModelContainer1 data = new SchoolModelContainer1();
        public Action<Teacher> GetStudentsByTeacher { get; set; }
        public IEnumerable<Teacher> GetTeachers() => data.Persons.OfType<Teacher>();
        public IEnumerable<TeachersCourse> GetCourses() => Enum.GetValues(typeof(TeachersCourse)).Cast<TeachersCourse>();

        internal void AddCourseToTeacher(Teacher teacher, TeachersCourse course)
        {
            if (teacher != null)
            {
                if (!teacher.Course.HasFlag(course))
                    teacher.Course |= course;
                data.SaveChanges();
            }
        }
        internal void RemoveCourseFromTeacher(Teacher teacher, TeachersCourse course)
        {
            if (teacher.Course.HasFlag(course))
                teacher.Course -= course;
            data.SaveChanges();
        }
        internal void ChangStudenteGrade(Student student, double newgrade)
        {
            student.Grade = newgrade;
            data.SaveChanges();
        }
        public void GetStudents(Teacher teacher) => GetStudentsByTeacher?.Invoke(teacher);
    }

    // public IEnumerable<Student> GetStudentByTeacher(Teacher teacher) => teacher.Student;

}
