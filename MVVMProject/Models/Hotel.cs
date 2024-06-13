namespace MVVMProject.Models;

public interface IHotel { }
public class Hotel : IHotel
{
    public readonly ReservationBook _reservationBook;

    public string Name { get; set; }


    public Hotel(string name)
    {
        this.Name = name;
        _reservationBook = new ReservationBook();
    }

    public IEnumerable<Reservation> GetReservauionsForUser(string username)
    {
        return _reservationBook.GetReservauionsForUser(username);
    }
    public IEnumerable<Reservation> GetAllReservauions()
    {
        return _reservationBook.GetAllReservauions();
    }
    public void MakeReservation(Reservation reservation)
    {
        _reservationBook.AddReservation(reservation);
    }


}
