using project_xo2.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_xo2.user
{
   public class UCourseWM
    {
        public DataTable show()
        {
            CourseRepository courseRepository = new CourseRepository();
            return courseRepository.ShowCourse();
        }
        public DataTable search(string ID)
        {
            CourseRepository courseRepository   = new CourseRepository();
            return courseRepository.SearchCourse(ID);
        }
    }
}
