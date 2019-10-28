using ExampleProjectWpfMvvmLightIHM.Model;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProjectWpfMvvmLightIHM.ViewModel
{
    public class DatabaseViewModel : ViewModelBase
    {

        private ObservableCollection<string> listDatabase;

        public ObservableCollection<string> ListDatabase
        {
            get
            {
                return listDatabase;
            }
            set
            {
                listDatabase = value;
                RaisePropertyChanged("ListDatabase");
            }
        }

        private String currentDatabase;

        public String CurrentDatabase
        {
            get
            {
                return currentDatabase;
            }
            set
            {
                if (currentDatabase == value) return;
                currentDatabase = value;
                RaisePropertyChanged("CurrentDatabase");
            }
        }

        public DatabaseViewModel()
        {
            this.listDatabase = new ObservableCollection<string>();

            listDatabase.Add(DatabaseModel.Database1);
            listDatabase.Add(DatabaseModel.Database2);
            listDatabase.Add(DatabaseModel.Database3);

        }

    }
}
