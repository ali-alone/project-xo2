using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace project_xo2.Utilities
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void onPropertChenged([CallerMemberName]string propName = null)
        {
         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));

    }
}
}
