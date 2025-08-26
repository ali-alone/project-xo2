using project_xo2.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_xo2.user
{
   public  class UTeacherWM
    {
        public DataTable show()
        {
            TeacherRepository teacherRepository = new TeacherRepository();
            return teacherRepository.ShowTeacher();
        }
        public DataTable search(string ID)
        {
            TeacherRepository teacherRepository = new TeacherRepository();
            return teacherRepository.SearchTeacher(ID);
        }
    }
}
