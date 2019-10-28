using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProjectWpfMvvmLightIHM.Model
{
    public class EnvironmentModel
    {
        public static ObservableCollection<string> environments = new ObservableCollection<string>() {
            @"DEV", @"PREPROD", @"PROD"
        };

    }
}
