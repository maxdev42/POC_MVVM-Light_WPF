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
    public class EnvironmentViewModel : ViewModelBase
    {

        private ObservableCollection<string> listEnvironment;

        public ObservableCollection<string> ListEnvironment
        {
            get
            {
                return listEnvironment;
            }
            set
            {
                listEnvironment = value;
                RaisePropertyChanged("ListEnvironment");
            }
        }

        private String currentEnvironment;

        public String CurrentEnvironment
        {
            get
            {
                return currentEnvironment;
            }
            set
            {
                if (currentEnvironment == value) return;
                currentEnvironment = value;
                RaisePropertyChanged("CurrentEnvironment");
            }
        }

        public EnvironmentViewModel()
        {
            this.listEnvironment = new ObservableCollection<string>();

            listEnvironment.Add(EnvironmentModel.Environment1);
            listEnvironment.Add(EnvironmentModel.Environment2);
            listEnvironment.Add(EnvironmentModel.Environment3);

        }

    }
}
