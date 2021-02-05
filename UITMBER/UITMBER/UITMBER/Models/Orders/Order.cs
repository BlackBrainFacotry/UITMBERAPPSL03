﻿using System;
using System.Collections.Generic;
using System.Text;
using UITMBER.Enums;

namespace UITMBER.Models.Order
{
    public class Order
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long? DriverId { get; set; }
        public double? ClientRating { get; set; }
        public double? DriverRating { get; set; }
        public CarType Type { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Photo { get; set; }
        public string PhoneNumber { get; set; }
        public double StartLat { get; set; }
        public double StartLong { get; set; }
        public double EndLat { get; set; }
        public double EndLong { get; set; }
        public double Cost { get; set; }
    }
}
