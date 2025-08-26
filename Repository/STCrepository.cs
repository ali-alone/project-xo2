using project_xo2.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_xo2.Repository
{
    public class STCrepository
    {
        private MyData db = new MyData();
        public void AddSTC(STC stc)
        {
            db.cs = $"insert into STC(stno, tno, cno , term, grade)" + $"values ('{stc.Stno}', '{stc.Tno}','{stc.Cno}','{stc.Term}', '{stc.Grade}')";
            db.ManData();
        }
        public void DeleteSTCbyADMIN(STC stc)
        {
            db.cs = $"DELETE FROM STC WHERE stno = '{stc.Stno}'";

            db.ManData();
        }
        public void UpdateSTC(STC stc)
        {
            db.cs = $"update STC  set stno = '{stc.Stno}', tno = '{stc.Tno}', cno = '{stc.Cno}', term = '{stc.Term}', grade = '{stc.Grade}'" + $"where stno = '{stc.Stno}'";
            db.ManData();
        }
        public DataTable ShowSTC()
        {
            MyData db = new MyData();
            return db.ShowDate("select * from STC");
        }
        public DataTable SearchSTC(string Stno, string Tno, string Cno)
        {
            MyData db = new MyData();
            return db.ShowDate($"select * from STC where stno = '{Stno}' or tno = '{Tno}' or cno = '{Cno}'");
        }
        public void DeleteSTCbystudent(string Stno)
        {
            db.cs = $"DELETE FROM STC WHERE stno = '{Stno}'";

            db.ManData();
        }
        public void DeleteSTCbyteacher(string tno)
        {
            db.cs = $"DELETE FROM STC WHERE tno = '{tno}'";

            db.ManData();
        }
        public void DeleteSTCbycourse(string Cno)
        {
            db.cs = $"DELETE FROM STC WHERE stno = '{Cno}'";

            db.ManData();
        }
    }
}
