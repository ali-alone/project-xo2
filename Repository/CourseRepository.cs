using project_xo2.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_xo2.Repository
{
    public class CourseRepository
    {
        private MyData db = new MyData();

        public void AddCourse(Course course)
        {
            db.cs = $"insert into course(cno, cname, ctype , cuint)" + $"values ('{course.ID}', '{course.Name}','{course.Ctype}','{course.Cunit}')";
            db.ManData();
        }
        public void DeleteCourse(Course course)
        {
            STCrepository sTC1 = new STCrepository();
            sTC1.DeleteSTCbycourse(course.ID);
            db.cs = $" delete from course where cno = '{course.ID}'";
            db.ManData();
        }
        public void UpdateCourse(Course course)
        {
            db.cs = $"update course set cno = '{course.ID}', cname = '{course.Name}', ctype = '{course.Ctype}', cuint = '{course.Cunit}'" + $"where cno = '{course.ID}'";
            db.ManData();
        }
        public DataTable ShowCourse()
        {
            MyData db = new MyData();
            return db.ShowDate($"select * from course");
        }
        public DataTable SearchCourse(string ID)
        {
            MyData db = new MyData();
            return db.ShowDate($"select * from course where cno = '{ID}'");
        }
    }
}
