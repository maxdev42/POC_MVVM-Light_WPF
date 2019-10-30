using ExampleProjectWpfMvvmLightIHM.Commons;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExampleProjectWpfMvvmLightIHM.Model
{
    public class PairValueViewModel : ViewModelBase
    {
        // Environments
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

        // Databases
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

        // Pair Values
        private ObservableCollection<PairValue> pairValuesList;
        public ObservableCollection<PairValue> PairValuesList
        {
            get
            {
                return pairValuesList;
            }
            set
            {
                pairValuesList = value;
                RaisePropertyChanged("PairValuesList");
            }
        }

        // Current environment
        private string currentEnvironment;
        public string CurrentEnvironment
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

        // Current database
        private string currentDatabase;
        public string CurrentDatabase
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

        // Constructeur
        public PairValueViewModel()
        {
            this.listEnvironment = EnvironmentModel.environments;
            this.listDatabase = DatabaseModel.databases;

            this.pairValuesList = new ObservableCollection<PairValue>();
            
            AddPairValueCommand = new RelayCommand(AddPairValue);
            RemovePairValueCommand = new RelayCommand<int>(RemovePairValue);
            ExportPairValueToCsvCommand = new RelayCommand<int>(ExportPairValueToCsv);
        }


        // Commandes
        public ICommand AddPairValueCommand { get; set; }
        public ICommand RemovePairValueCommand { get; set; }
        public ICommand ExportPairValueToCsvCommand { get; set; }

        // COmmandes implementations
        public void AddPairValue()
        {
            var pairValue = new PairValue();
            pairValue.EnvironmentValue = CurrentEnvironment;
            pairValue.DatabaseValue = CurrentDatabase;
        
            pairValuesList.Add(pairValue);
        }

        public void RemovePairValue(int index)
        {
            pairValuesList.RemoveAt(index);
        }

        public void ExportPairValueToCsv(int index)
        {
            DirectoryManager.CreateAndWriteContentInCsvFile(@"C:\Users\maxen_xkerrno\OneDrive\Bureau\test.csv", pairValuesList);
        }
    }
}
