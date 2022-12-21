using ExerciseOnData.DataModel;
using ExerciseOnData.Services;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ExerciseOnData.ViewModel
{
    public class StudentsViewModels
    {
        private readonly DataService service;

        public Student StudentSelect { get; set; }
        public RelayCommand ChangeGradeCommand { get; set; }
        public ObservableCollection<Student> Students { get; set; }

        public StudentsViewModels(DataService service)
        {
            this.service = service;
            service.GetStudentsByTeacher = GetTeacherStudent;
            Students = new ObservableCollection<Student>();
            ChangeGradeCommand = new RelayCommand(ChangeGrades);
        }

        private void ChangeGrades()
        {
            if (StudentSelect != null)
            {
                service.ChangStudenteGrade(StudentSelect, StudentSelect.Grade);
            }
        }
        private void GetTeacherStudent(Teacher teacher)
        {
            if (teacher != null)
            {
                Students.Clear();
                teacher.Student.ToList().ForEach(s => Students.Add(s));
            }    
        }
    }
}
