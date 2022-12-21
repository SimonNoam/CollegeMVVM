using ExerciseOnData.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExerciseOnData
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //using (var data = new SchoolModelContainer1())
            //{
            //    var t1 = new Teacher { Course = TeachersCourse.Css, Name = "Noam Simon" };
            //    var t2 = new Teacher { Course = TeachersCourse.html, Name = "Omri Ben David"};
            //    var t3 = new Teacher { Course = TeachersCourse.Java, Name = "Dr Dimitry"};
            //    var t4 = new Teacher { Course = TeachersCourse.Csharp, Name = "Roy Rachmany"};
            //    var t5 = new Teacher { Course = TeachersCourse.pyton, Name = "Yuval Asor" };
            //    var t6 = new Teacher { Course = TeachersCourse.html, Name = "Tal Levi" };
            //    var t7 = new Teacher { Course = TeachersCourse.Csharp, Name = "Or Meir" };

            //    var s1 = new Student { Name = "Yarin", Grade = 96 };
            //    var s2 = new Student { Name = "Gal", Grade = 79};
            //    var s3 = new Student { Name = "Moshe", Grade = 86 };
            //    var s4 = new Student { Name = "Elad", Grade = 88 };
            //    var s5 = new Student { Name = "Matan", Grade = 68 };
            //    var s6 = new Student { Name = "Avi", Grade = 75 };
            //    var s7 = new Student { Name = "Eyal", Grade = 94 };
            //    t1.Student = new List<Student> { s1, s3, s5 };
            //    t2.Student = new List<Student> { s2, s4, s7 };
            //    t3.Student = new List<Student> { s3, s5 };
            //    t4.Student = new List<Student> { s4, s5 ,s2};
            //    t5.Student = new List<Student> { s6, s4 };
            //    t6.Student = new List<Student> { s5, s1 };
            //    t7.Student = new List<Student> { s7, s6, s4};
            //    data.Persons.AddRange(new List<Teacher> {t1,t2,t3, t4, t5, t6, t7 });
            //    data.Persons.AddRange(new List<Student> {s1,s2,s3, s4, s5, s6, s7 });
            //    data.SaveChanges();
            //}
        }
    }
}
