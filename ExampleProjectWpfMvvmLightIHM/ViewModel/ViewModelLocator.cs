using CommonServiceLocator;
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
            SimpleIoc.Default.Register<EnvironmentViewModel>();
            SimpleIoc.Default.Register<DatabaseViewModel>();
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public EnvironmentViewModel Environment
        {
            get
            {
                return ServiceLocator.Current.GetInstance<EnvironmentViewModel>();
            }
        }

        public DatabaseViewModel Database
        {
            get
            {
                return ServiceLocator.Current.GetInstance<DatabaseViewModel>();
            }
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}