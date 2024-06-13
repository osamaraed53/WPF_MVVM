using MVVMProject.Models;
using MVVMProject.MVVM;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MVVMProject.ViewModel;

public  class ReservationListingViewModel : ViewModelBase,IViewModeBase
{
    private readonly ObservableCollection<Reservation> _reservationsl;
    public IEnumerable<Reservation> Reservations => _reservationsl;



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

    public ReservationListingViewModel(INavigationService navService)
    {
        Navigation = navService;
        NavigateToMakeReservationCommand = new RelayCommand(execute => NavigationCommand(), canExecute => true);


        _reservationsl =
        [
            new Reservation(new RoomID(1, 2), "OsamaRaed ", DateTime.Now, DateTime.Now),
            new Reservation(new RoomID(3, 4), "OsamaRaed ", DateTime.Now, DateTime.Now),
            new Reservation(new RoomID(5, 6), "OsamaRaed ", DateTime.Now, DateTime.Now),
            new Reservation(new RoomID(7, 8), "OsamaRaed ", DateTime.Now, DateTime.Now),
            new Reservation(new RoomID(9, 10), "OsamaRaed ", DateTime.Now, DateTime.Now),
        ];
    }

    private void NavigationCommand()
    {
        Navigation.NavigateTo<MakeReservationViewModel>();
    }
}
