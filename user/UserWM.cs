using project_xo2.Repository;
using project_xo2.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace project_xo2.user
{
    public class UserWM : Utilities.ViewModelBase
    {
        private object _CurrentView;
        public object CurrentView
        {
            get { return _CurrentView; }
            set { _CurrentView = value; onPropertyChenged(); }

        }
        public ICommand HomeCommand { get; set; }
        public ICommand UserStudentCommand { get; set; }
        public ICommand UTeacherCommand { get; set; }
        public ICommand UCourseCommand { get; set; }
        public ICommand USTCCommand { get; set; }

        
        private void userstudent(object obj) => CurrentView = new UserWM();
        private void UTeacher(object obj) => CurrentView = new UTeacherWM();
        private void UCourse(object obj) => CurrentView = new UCourseWM();
        private void UStc(object obj) => CurrentView = new USTCWM();

        private void Home(object obj) => CurrentView = new MainWM();

        public UserWM()
        {
            HomeCommand = new Utilities.RelayCommand(Home);
            UserStudentCommand = new Utilities.RelayCommand(userstudent);
            UTeacherCommand = new Utilities.RelayCommand(UTeacher);
            UCourseCommand = new Utilities.RelayCommand(UCourse);
            USTCCommand = new Utilities.RelayCommand(UStc);
            CurrentView = new MainWM();
        }

        public DataTable show()
        {
            StudentRepository studentRepository = new StudentRepository();
            return studentRepository.show();
        }
        public DataTable search(string ID)
        {
             StudentRepository studentRepository = new StudentRepository();
            return studentRepository.search(ID);
        }
    }
}
