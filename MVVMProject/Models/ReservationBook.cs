using MVVMProject.Exceptions;

namespace MVVMProject.Models;

public class ReservationBook
{

    public readonly List<Reservation> _reservations;

    public ReservationBook()
    {
        _reservations = new List<Reservation>();
    }

    public IEnumerable<Reservation> GetReservauionsForUser(string username)
    {
        return _reservations.Where(obj => obj.UserName == username);
    }

    public IEnumerable<Reservation> GetAllReservauions()
    {
        return _reservations;
    }

    public void AddReservation(Reservation reservation)
    {
        foreach(Reservation existingReservation  in _reservations)
        {
            if(existingReservation.Conflicts(reservation))
            {
                throw new ReservationConflictException(existingReservation ,reservation);
            }
        }

        _reservations.Add(reservation);
    }


}
