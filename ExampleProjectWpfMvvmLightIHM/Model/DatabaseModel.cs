using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProjectWpfMvvmLightIHM.Model
{
    public class DatabaseModel
    {
        public static ObservableCollection<string> databases = new ObservableCollection<string>()
        {
            @"PRUPOOL01", @"PRUPOOL02", @"PRUPOOL03"
        };

    }
}
