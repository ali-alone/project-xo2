using project_xo2.Model;
using project_xo2.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_xo2.ViewModel
{
    public class CourseWM : Utilities.ViewModelBase
    {
        private readonly Course course;

        public string CId
        {
            get { return course.ID; }
            set { course.ID = value; onPropertyChenged(); }
        }
        public string Cname
        {
            get { return course.Name; }
            set { course.Name = value; onPropertyChenged(); }
        }
        public string Ctype
        {
            get { return course.Ctype; }
            set { course.Ctype = value; onPropertyChenged(); }
        }
        public string Cunit
        {
            get { return course.Cunit; }
            set { course.Cunit = value; onPropertyChenged(); }
        }
        public CourseWM()
        {
            course = new Course();
        }

        public CourseWM(string id, string cname, string ctype, string cunit)
        {
            course = new Course();
            this.CId = id;
            this.Cname = cname;
            this.Ctype = ctype;
            this.Cunit = cunit;

        }

        public void addCourse()
        {
            Course course = new Course()
            {
                ID = this.CId,
                Name = this.Cname,
                Ctype = this.Ctype,
                Cunit = this.Cunit
            };
            CourseRepository courseRepository = new CourseRepository();
            courseRepository.AddCourse(course);
        }

        public void deleteCourse(string id)
        {

            Course course = new Course()
            {
                ID = this.CId,
                Name = this.Cname,
                Ctype = this.Ctype,
                Cunit = this.Cunit
            };


            CourseRepository courseRepository = new CourseRepository();
            courseRepository.DeleteCourse(course);
        }

        public void editCourse()
        {
            Course course = new Course()
            {
                ID = this.CId,
                Name = this.Cname,
                Ctype = this.Ctype,
                Cunit = this.Cunit
            };
            CourseRepository courseRepository = new CourseRepository();
            courseRepository.UpdateCourse(course);

        }



        public DataTable searchCOurse(string ID)
        {
            CourseRepository courseRepository = new CourseRepository();
            var result = courseRepository.SearchCourse(ID);
            return result;
        }


        public DataTable showCourse()
        {
            CourseRepository courseRepository = new CourseRepository();
            var result = courseRepository.ShowCourse();
            return result;


        }
    }
}
