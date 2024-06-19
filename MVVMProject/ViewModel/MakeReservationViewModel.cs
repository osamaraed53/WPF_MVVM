using MVVMProject.Exceptions;
using MVVMProject.Models;
using MVVMProject.MVVM;
using System.Windows;
using System.Windows.Input;

namespace MVVMProject.ViewModel;

public class MakeReservationViewModel : ViewModelBase
{

    private Hotel _hotel;
    private string _username;
    private int _roomNumber;
    private int _floorNumber;
    private DateTime _startDate = DateTime.Now;
    private DateTime _endDate = DateTime.Now;
    private bool _isLoading;
    public RelayCommand SubmitCommand { get; }
    public RelayCommand CancelCommand { get; }
    public RelayCommand NavigateToReservationListingCommand { get; set; }

    private INavigationService _navigation;

    public INavigationService Navigation
    {
        get { return _navigation; }
        set { _navigation = value; }
    }


    public MakeReservationViewModel(INavigationService navService, IHotel hotel)
    {
        Navigation = navService;
        _hotel = (Hotel)hotel;
        SubmitCommand = new RelayCommand( async execute => await SubmitAsync(), canExecute => CanSubmit());
        CancelCommand = new RelayCommand(execute => Cancel(), canExecute => true);
        NavigateToReservationListingCommand = new RelayCommand(execute => Navigation.NavigateTo<ReservationListingViewModel>(), canExecute => true);


    }

    

    public bool IsLoading
    {
        get { return _isLoading; }
        set
        {
            _isLoading = value;
            OnPropertyChanged();
        }
    }

    public string Username
    {
        get { return _username; }
        set { _username = value;
            OnPropertyChanged();
        }
    }



    public int RoomNumber
    {
        get { return _roomNumber; }
        set
        {
            _roomNumber = value;
            OnPropertyChanged();
        }
    }
    public int FloorNumber
    {
        get { return _floorNumber; }
        set
        {
            _floorNumber = value;
            OnPropertyChanged();
        }
    }


    public DateTime StartDate
    {
        get { return _startDate; }
        set
        {
            _startDate = value;
            OnPropertyChanged();
        }
    }

    public DateTime EndDate
    {
        get { return _endDate; }
        set
        {
            _endDate = value;
            OnPropertyChanged();
        }
    }
    private void Cancel()
    {

    }

    private async Task SubmitAsync()
    {
        try
        {
            Reservation newReservation = new(new RoomID(FloorNumber, RoomNumber), Username, StartDate, EndDate);
            _hotel.MakeReservation(newReservation);
            IsLoading = true;
            await Task.Delay(20000);
            IsLoading = false;

            Navigation.NavigateTo<ReservationListingViewModel>();

        }
        catch 
        {
            MessageBox.Show($"this room not ex","error",MessageBoxButton.OK,MessageBoxImage.Error);
        }
        
    }

    private bool CanSubmit()
    {
        return !string.IsNullOrEmpty(Username?.Trim()) && RoomNumber != 0 && FloorNumber != 0; 
    }




}
