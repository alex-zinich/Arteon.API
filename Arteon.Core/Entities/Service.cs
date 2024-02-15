using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arteon.Core.Entities
{
    public class Service : BaseEntity
    {
        public Service(string name, double pricePerDay, Guid? id = null)
        {
            Name = name;
            PricePerDay = pricePerDay;
            Id = id ?? Guid.Empty;
        }
        private Service() { }

        [Required, MaxLength(32)]
        public string Name { get; private set; }
        [Range(0, double.MaxValue)]
        public double PricePerDay { get; private set; }

        // Navigation properties
        public ICollection<BookingService> BookingServices { get; private set; }
    }
}
