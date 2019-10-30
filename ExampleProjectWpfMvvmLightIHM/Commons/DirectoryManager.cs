using ExampleProjectWpfMvvmLightIHM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProjectWpfMvvmLightIHM.Commons
{
    public class DirectoryManager
    {

        public static void CreateAndWriteContentInCsvFile(string path, ObservableCollection<PairValue> listData)
        {
            StreamWriter file = new StreamWriter(path);
            
            foreach(PairValue data in listData)
            {
                file.WriteLine(data);
            }
            file.Close();
        }
    }
}
