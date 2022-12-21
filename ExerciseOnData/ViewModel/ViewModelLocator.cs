/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:ExerciseOnData"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

 
*/

using CommonServiceLocator;
using ExerciseOnData.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;


namespace ExerciseOnData.ViewModel
{
   
    public class ViewModelLocator
    {
       
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            
            SimpleIoc.Default.Register<DataService>();
            SimpleIoc.Default.Register<StudentsViewModels>();
            SimpleIoc.Default.Register<TeacherViewModels>();
            SimpleIoc.Default.Register<MainViewModel>();
        }

        public MainViewModel Main=> ServiceLocator.Current.GetInstance<MainViewModel>();

        public TeacherViewModels Teachers => ServiceLocator.Current.GetInstance<TeacherViewModels>();

        public StudentsViewModels Students => ServiceLocator.Current.GetInstance<StudentsViewModels>();

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}