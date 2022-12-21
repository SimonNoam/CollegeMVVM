using ExerciseOnData.DataModel;
using ExerciseOnData.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExerciseOnData.ViewModel
{
    public class TeacherViewModels
    {
        private readonly DataService service;
        public TeachersCourse SelectedCourse { get; set; }
        public Teacher SelectedTeacher { get; set; }

        public RelayCommand AddCourseCommand { get; set; }
        public RelayCommand AddStudentsCommand { get; set; }

        public ObservableCollection<TeachersCourse> Courses { get; set; }
        public ObservableCollection<Teacher> Teachers { get; set; }

        public TeacherViewModels(DataService service)
        {
            this.service = service;
            AddCourseCommand = new RelayCommand(AddCourse);
            AddStudentsCommand = new RelayCommand(AddStudents);
            Courses = new ObservableCollection<TeachersCourse>(service.GetCourses());
            Teachers = new ObservableCollection<Teacher>(service.GetTeachers());
        }

        private void AddCourse() => service.AddCourseToTeacher(SelectedTeacher, SelectedCourse);
        private void AddStudents() => service.GetStudentsByTeacher(SelectedTeacher);
    }
}
