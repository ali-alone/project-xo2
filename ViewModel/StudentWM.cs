using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_xo2.Model;
namespace project_xo2.ViewModel
{
   public class StudentWM:Utilities.ViewModelBase
    { 
        private readonly Student student;

        private int Id
        {
            get { return student.Id; }
            set {student.Id = value; onPropertChenged(); }
        }
        public StudentWM() 
        {
            student = new Student();
            Id = 10;
        }
    }
}
