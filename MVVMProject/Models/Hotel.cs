namespace MVVMProject.Models;

public interface IHotel { }
public class Hotel : IHotel
{
    public ReservationBook _reservationBook { get; private set; }


    public string Name { get; set; }


    public Hotel(string name)
    {
        this.Name = name;
        _reservationBook = new ReservationBook();

        MakeReservation(new Reservation(new RoomID(1, 2),  "OsamaRaed ", DateTime.Now, DateTime.Now));
        MakeReservation(new Reservation(new RoomID(3, 4),  "OsamaRaed ", DateTime.Now, DateTime.Now));
        MakeReservation(new Reservation(new RoomID(5, 6),  "OsamaRaed ", DateTime.Now, DateTime.Now));
        MakeReservation(new Reservation(new RoomID(7, 8),  "OsamaRaed ", DateTime.Now, DateTime.Now));
        MakeReservation(new Reservation(new RoomID(9, 10), "OsamaRaed ", DateTime.Now, DateTime.Now));

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
