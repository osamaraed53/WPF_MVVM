using MVVMProject.Models;
using System.Windows;

namespace MVVMProject;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{




    protected override void OnStartup(StartupEventArgs e)
    {

        Hotel hotel = new("Osama Hotel");

        hotel.MakeReservation(new Reservation(new RoomID(1, 1),"osama" , new DateTime(2000,1,3) ,new DateTime(2000,1,4) ) );
        hotel.MakeReservation(new Reservation(new RoomID(1, 1), "osama", new DateTime(2000, 1,4 ), new DateTime(2000, 1, 5)));

        IEnumerable<Reservation> reservation = hotel.GetReservauionsForUser("osama");

        base.OnStartup(e);
    }


}
