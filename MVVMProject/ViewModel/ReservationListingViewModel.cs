using MVVMProject.Models;
using MVVMProject.MVVM;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Input;

namespace MVVMProject.ViewModel;

public  class ReservationListingViewModel : ViewModelBase,IViewModeBase
{
    public IEnumerable<Reservation> Reservations => new ObservableCollection<Reservation>(_hotel.GetAllReservauions().ToList());

    private readonly Hotel _hotel;

    private INavigationService _navigation;
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



    public ReservationListingViewModel(INavigationService navService,IHotel hotel)
    {
        Navigation = navService;
        NavigateToMakeReservationCommand = new RelayCommand(execute => NavigationCommand(), canExecute => true);


         _hotel = (Hotel) hotel;



    }

    private void NavigationCommand()
    {
        Navigation.NavigateTo<MakeReservationViewModel>();
    }
}
