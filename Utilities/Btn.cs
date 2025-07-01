using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace project_xo2.Utilities
{
  public class Btn :RadioButton
    {
        static Btn()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Btn), new System.Windows.PropertyMetadata(typeof(Btn)));
        }
    }
}
