using project_xo2.Model;
using project_xo2.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace project_xo2.Repository
{
    public class StudentRepository
    {
        private MyData db = new MyData();

        public bool AddStudent(Student student)
        {
            if (db.SearchDate(student.ID))
            {
                MessageBox.Show("This student already exists.");
                return false;
            }
            else
            {
                db.cs = $"insert into sstudent (stno , stname, stfamily, stfield)" + $"values ('{student.ID}' , '{student.NAME}' , '{student.Sfamily}' , '{student.Sfield}')";
                db.ManData();
                return true;
            }
        }
        public void Update(Student student)
        {

            db.cs = $"update sstudent  set stno = '{student.ID}', stname = '{student.NAME}', stfamily = '{student.Sfamily}', stfield = '{student.Sfield}'" + $"where stno = '{student.ID}'";
            db.ManData();
        }
        public void Delete(Student student)
        {
            STCrepository sTC = new STCrepository();
            sTC.DeleteSTCbystudent(student.ID);
            db.cs = $"delete from sstudent where stno = '{student.ID}'";
            db.ManData();
        }
        public DataTable show()
        {
            MyData db = new MyData();
            return db.ShowDate("select * from sstudent");
        }
        public DataTable search(string ID)
        {
            MyData db = new MyData();
            return db.ShowDate($"select * from sstudent where stno = '{ID}'");
        }
    }
}
