using MVVMProject.MVVM;

namespace MVVMProject.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private INavigationService  _navigation ;

        public INavigationService Navigation
        {
            get => _navigation;
            private set
            {
                _navigation = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand NavigateToReservationListingCommand { get; }
        public RelayCommand NavigateToMakeReservationCommand { get; }
        public RelayCommand NavigateToHomeCommand { get; }

        public MainViewModel(INavigationService navService)
        {
            Navigation = navService;
            Navigation.NavigateTo<ReservationListingViewModel>();
            NavigateToReservationListingCommand = new RelayCommand(execute => Navigation.NavigateTo<ReservationListingViewModel>(),canExecute => true);
            NavigateToMakeReservationCommand = new RelayCommand(execute => Navigation.NavigateTo<MakeReservationViewModel>(),canExecute => true);
        }


    }
}
