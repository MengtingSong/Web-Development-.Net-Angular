﻿using System;
namespace HotelManagement.Data
{
    public class Customer
    {
        public int Id { get; set; }
        public int RoomNO { get; set; }
        public string CName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Checkin { get; set; }
        public int TotalPersons { get; set; }
        public int BookingDays { get; set; }
        public decimal Advance { get; set; }

        public Room Room { get; set; }
    }
}
