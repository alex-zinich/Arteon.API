using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arteon.Core.Entities
{
    public class Client : BaseEntity
    {
        public Client(string fullName, string email, Guid? id = null)
        {
            FullName = fullName;
            Email = email;
            Id = id ?? Guid.Empty;
        }

        private Client() { }

        [Required, MaxLength(128)]
        public string FullName { get; private set; }
        [Required, MaxLength(64)]
        public string Email { get; private set; }

        // Navigation properties
        public ICollection<Booking> Bookings { get; private set; }
    }
}
