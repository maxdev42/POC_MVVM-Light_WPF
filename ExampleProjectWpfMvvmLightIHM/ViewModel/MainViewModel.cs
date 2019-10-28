using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows.Input;

namespace ExampleProjectWpfMvvmLightIHM.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            LeaveApplicationCommand = new RelayCommand(LeaveApplication);
        }

        public ICommand LeaveApplicationCommand { get; private set; }

        public void LeaveApplication()
        {
            Environment.Exit(1);
        }
    }
}