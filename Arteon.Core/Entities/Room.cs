﻿using Arteon.Core.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace Arteon.Core.Entities
{
    public class Room : BaseEntity
    {
        public Room(RoomType typeId, int occupacity, int roomNumber,  Guid? id = null, double pricePerDay = 0)
        {
            TypeId = typeId;
            Occupacity = occupacity;
            PricePerDay = pricePerDay;
            Id = id ?? Guid.Empty;
        }

        private Room() { }

        public RoomType TypeId { get; private set; }
        [Range(101, int.MaxValue)]
        public int RoomNumber { get; private set; }
        [Range(1, 5)]
        public int Occupacity { get; private set; }
        [Range(0, double.MaxValue)]
        public double PricePerDay { get; private set; }

        // Navigation properties
        public ICollection<Booking> Bookings { get; private set; }
    }
}
