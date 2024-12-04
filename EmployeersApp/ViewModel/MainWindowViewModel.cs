using EmployeersApp.ViewModel.MVVMHelper;
using System.Security.RightsManagement;

namespace EmployeersApp.ViewModel
{
    internal class MainWindowViewModel : BindingHelper
    {
        public BindableCommand AddCommand { get; set; }

        public RequistionPageViewModel RPViewModel;

        private object _cuurrentView;
        public object CurrentView
        {
            get { return _cuurrentView; }
            set
            {
                _cuurrentView = value;
                OnPropertyChanged();
            }
        }


        public MainWindowViewModel()
        {
            RPViewModel = new RequistionPageViewModel();
            CurrentView = RPViewModel;
        }
    }
}
