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
    public class STCWM : Utilities.ViewModelBase
    {
        private readonly STC stc;

        public string Stno
        {
            get { return stc.Stno; }
            set { stc.Stno = value; onPropertyChenged(); }
        }
        public string Tno
        {
            get { return stc.Tno; }
            set { stc.Tno = value; onPropertyChenged(); }
        }
        public string Cno
        {
            get { return stc.Cno; }
            set { stc.Cno = value; onPropertyChenged(); }
        }

        public string Term
        {
            get { return stc.Term; }
            set { stc.Term = value; onPropertyChenged(); }
        }

        public string Grade
        {
            get { return stc.Grade; }
            set { stc.Grade = value; onPropertyChenged(); }
        }

        public STCWM()
        {
            stc = new STC();
        }
        public STCWM(string stno, string tno, string cno, string term, string grade)
        {
            stc = new STC();
            this.Stno = stno;
            this.Tno = tno;
            this.Cno = cno;
            this.Term = term;
            this.Grade = grade;
        }





        public void AddSTC()
        {
            STC stc = new STC()
            {
                Stno = this.Stno,
                Tno = this.Tno,
                Cno = this.Cno,
                Term = this.Term,
                Grade = this.Grade
            };
            STCrepository stcRepository = new STCrepository();
            stcRepository.AddSTC(stc);
        }

        public void deleteSTC()
        {
            STC stc = new STC()
            {
                Stno = this.Stno,
                Tno = this.Tno,
                Cno = this.Cno,
                Term = this.Term,
                Grade = this.Grade
            };
            STCrepository stcRepository = new STCrepository();
            stcRepository.DeleteSTCbyADMIN(stc);


        }

        public void UpdateSTC()
        {
            STC stc = new STC()
            {
                Stno = this.Stno,
                Tno = this.Tno,
                Cno = this.Cno,
                Term = this.Term,
                Grade = this.Grade
            };
            STCrepository stcRepository = new STCrepository();
            stcRepository.UpdateSTC(stc);
        }

        public DataTable ShowSTC()
        {
            STCrepository stcRepository = new STCrepository();
            var result = stcRepository.ShowSTC();
            return result;
        }

        public DataTable SearchSTC(string Stno, string Tno, string Cno)
        {
            STCrepository stcRepository = new STCrepository();
            var result = stcRepository.SearchSTC(Stno, Tno, Cno);
            return result;
        }



    }
}
