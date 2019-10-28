using CommonServiceLocator;
using ExampleProjectWpfMvvmLightIHM.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;

namespace ExampleProjectWpfMvvmLightIHM.ViewModel
{

    public class ViewModelLocator
    {

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<PairValueViewModel>();
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public PairValueViewModel PairValues
        {
            get
            {
                return ServiceLocator.Current.GetInstance<PairValueViewModel>();
            }
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}