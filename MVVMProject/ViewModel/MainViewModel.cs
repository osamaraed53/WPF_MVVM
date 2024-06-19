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
        public RelayCommand NavigateToMakeReservationCommand { get; }
        public RelayCommand NavigateToReservationListingCommand { get; }

        public MainViewModel(INavigationService navService)
        {
            Navigation = navService;
            NavigateToMakeReservationCommand = new RelayCommand(execute => Navigation.NavigateTo<MakeReservationViewModel>(), canExecute => true); 
            NavigateToReservationListingCommand = new RelayCommand(execute => Navigation.NavigateTo<ReservationListingViewModel>(), canExecute => true);

            Navigation.NavigateTo<ReservationListingViewModel>();
        }


    }
}
