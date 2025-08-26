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
    public class TeacherWM :Utilities.ViewModelBase
    {
        private readonly Teacher teacher;

        public string TId
        {
            get { return teacher.ID; }
            set { teacher.ID = value; onPropertyChenged(); }
        }
        public string Tname
        {
            get { return teacher.NAME; }
            set { teacher.NAME = value; onPropertyChenged(); }
        }
        public string Tdegree
        {
            get { return teacher.Tdegree; }
            set { teacher.Tdegree = value; onPropertyChenged(); }
        }
        public string Tsalary
        {
            get { return teacher.Tsalary; }
            set { teacher.Tsalary = value; onPropertyChenged(); }
        }
        public TeacherWM()
        {
            teacher = new Teacher();
        }

        public TeacherWM(string id, string tname, string tdegree, string tsalary)
        {
            teacher = new Teacher();
            this.TId = id;
            this.Tname = tname;
            this.Tdegree = tdegree;
            this.Tsalary = tsalary;
        }



        public void AddTeacher()
        {
            Teacher teacher = new Teacher()
            {
                ID = this.TId,
                NAME = this.Tname,
                Tdegree = this.Tdegree,
                Tsalary = this.Tsalary
            };
            TeacherRepository teacherRepository = new TeacherRepository();
            teacherRepository.AddTeacher(teacher);
        }

        public void RemoveTeacher() 
        {

            Teacher teacher = new Teacher()
            {
                ID = this.TId,
                NAME = this.Tname,
                Tdegree = this.Tdegree,
                Tsalary = this.Tsalary
            };

            TeacherRepository teacherRepository = new TeacherRepository();
            teacherRepository.DeleteTeacher(teacher);
        }
        public void UpdateTeacher()
        {
            Teacher teacher = new Teacher()
            {
                ID = this.TId,
                NAME = this.Tname,
                Tdegree = this.Tdegree,
                Tsalary = this.Tsalary
            };
            TeacherRepository teacherRepository = new TeacherRepository();
            teacherRepository.EditTeacher(teacher);


        }

        public DataTable SearchTeacher(string ID)
        {
            TeacherRepository teacherRepository = new TeacherRepository();
            var result = teacherRepository.SearchTeacher(ID);
            return result;
        }


        public DataTable ShowTeachers()
        {
            TeacherRepository teacherRepository = new TeacherRepository();
            var result = teacherRepository.ShowTeacher();
            return result;
        }


    }

}
