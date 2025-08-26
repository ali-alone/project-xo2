using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using project_xo2.Model;
namespace project_xo2.ViewModel
{
    public class Navigation : Utilities.ViewModelBase
    {
        private object _CurrentView;
        public object CurrentView
        {
            get { return _CurrentView; }
            set { _CurrentView = value; onPropertyChenged(); }

        }
        public ICommand MainCommand { get; set; }
        public ICommand TeacherCommand { get; set; }
        public ICommand CourseCommand { get; set; }
        public ICommand STCCommand { get; set; }
        public ICommand StudentCommand { get; set; }


        private void Home(object obj) => CurrentView = new MainWM();

        private void Teacher(object obj) => CurrentView = new TeacherWM();

        private void Course(object obj) => CurrentView = new CourseWM();

        private void STC(object obj) => CurrentView = new STCWM();

        private void Student(object obj) => CurrentView = new StudentWM();

        public Navigation()
        {
            MainCommand = new Utilities.RelayCommand(Home);
            TeacherCommand = new Utilities.RelayCommand(Teacher);
            CourseCommand = new Utilities.RelayCommand(Course);
            STCCommand = new Utilities.RelayCommand(STC);
            StudentCommand = new Utilities.RelayCommand(Student);

            CurrentView = new MainWM();
        }
    }
}
