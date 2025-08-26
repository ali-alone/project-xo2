using project_xo2.Model;
using project_xo2.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_xo2.Repository
{
    public class TeacherRepository
    {
        private MyData db = new MyData();
        public void AddTeacher(Teacher teacher)
        {
            db.cs = $"INSERT INTO teacher(tno, tname, tdegree , tsalary)" + $"values('{teacher.ID}' , '{teacher.NAME}' , '{teacher.Tdegree}' , '{teacher.Tsalary}')";
            db.ManData();
        }

        public void DeleteTeacher(Teacher teacher)
        {
            STCrepository sTC1 = new STCrepository();
            sTC1.DeleteSTCbyteacher(teacher.ID);
            db.cs = $"delete from teacher where tno = '{teacher.ID}'";
            db.ManData();
        }
        public void EditTeacher(Teacher teacher)
        {
            db.cs = $"update teacher set tno = '{teacher.ID}', tname = '{teacher.NAME}', tdegree = '{teacher.Tdegree}', tsalary = '{teacher.Tsalary}'" + $"where tno = '{teacher.ID}'";
            db.ManData();
        }
        public DataTable ShowTeacher()
        {
            MyData db = new MyData();
            return db.ShowDate($"select * from teacher");
        }
        public DataTable SearchTeacher(string ID)
        {
            MyData db = new MyData();
            return db.ShowDate($"select * from teacher where tno = '{ID}'");
        }
    }
}
