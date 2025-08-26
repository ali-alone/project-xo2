using project_xo2.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_xo2.user
{
   public class USTCWM
    {
        public DataTable show()
        {
            STCrepository sTCrepository = new STCrepository();
            return sTCrepository.ShowSTC();
        }
        public DataTable search(string stno ,string tno ,string cno)
        {
            STCrepository sTCrepository = new STCrepository();
            return sTCrepository.SearchSTC(stno,tno,cno);
        }
    }
}
