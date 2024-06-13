using MVVMProject.Exceptions;
using MVVMProject.Models;
using MVVMProject.MVVM;
using System.Windows;
using System.Windows.Input;

namespace MVVMProject.ViewModel;

public class MakeReservationViewModel : ViewModelBase
{

    //private Hotel _hotel;
    private string _username;
    private int _roomNumber;
    private int _floorNumber;
    private DateTime _startDate = DateTime.Now;
    private DateTime _endDate = DateTime.Now;
    public RelayCommand SubmitCommand { get; }
    public RelayCommand CancelCommand { get; }
    //public RelayCommand NavigateToReservationListingCommand { get; set; }

    //public RelayCommand MakeReservationCommand { get; }
    public MakeReservationViewModel()
    {

        //_hotel = (Hotel) hotel;
        SubmitCommand = new RelayCommand(execute => Submit(), canExecute => CanSubmit());
        CancelCommand = new RelayCommand(execute => Cancel(), canExecute => true);

    }



    public string Username
    {
        get { return _username; }
        set { _username = value; }
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

    private void Submit()
    {
        try
        {
            Reservation newReservation = new(new RoomID(FloorNumber, RoomNumber), Username, StartDate, EndDate);
            //_hotel.MakeReservation(newReservation);

        }
        catch (ReservationConflictException ex)
        {
            MessageBox.Show($"this room not ex","error",MessageBoxButton.OK,MessageBoxImage.Error);
        }
        
    }

    private bool CanSubmit()
    {
        return !string.IsNullOrEmpty(Username?.Trim()) && RoomNumber != 0 && FloorNumber != 0; 
    }




}
