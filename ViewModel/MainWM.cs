using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_xo2.Model;


namespace project_xo2.ViewModel
{
    public class MainWM: Utilities.ViewModelBase
    {
        private readonly Main _Main;
        public MainWM() 
        {
            _Main = new Main();
        }
    }
}
