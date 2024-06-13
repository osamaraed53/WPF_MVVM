﻿namespace MVVMProject.Models;

public class Reservation
{
    public RoomID RoomID { get; }
    public string Username { get; }
    public DateTime StartTime { get; }
    public DateTime EndTime { get; }

    public TimeSpan Length => EndTime.Subtract(StartTime);
    
    public Reservation(RoomID roomID,string username , DateTime startTime, DateTime endTime)
    {
        this.RoomID = roomID;
        this.Username = username;
        this.StartTime = startTime;   
        this.EndTime = endTime;
    }


    public bool Conflicts(Reservation reservation)
    {
        if(reservation.RoomID != RoomID) return false;

        return reservation.StartTime < EndTime && reservation.EndTime > StartTime;
    }
}
