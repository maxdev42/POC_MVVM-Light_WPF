using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ExampleProjectWpfMvvmLightIHM.Model
{
    public class PairValue : DependencyObject
    {
        public static readonly DependencyProperty DatabaseValueProperty = DependencyProperty.Register("DatabaseValue", typeof(string), typeof(PairValue));

        public string DatabaseValue
        {
            get { return (string)GetValue(DatabaseValueProperty); }
            set { SetValue(DatabaseValueProperty, value); }
        }

        public static readonly DependencyProperty EnvironmentValueProperty = DependencyProperty.Register("EnvironmentValue", typeof(string), typeof(PairValue));

        public string EnvironmentValue
        {
            get { return (string)GetValue(EnvironmentValueProperty); }
            set { SetValue(EnvironmentValueProperty, value); }
        }

        public override string ToString()
        {
            return EnvironmentValue + ";" + DatabaseValue;
        }

    }
}
