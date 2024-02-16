using System.ComponentModel.DataAnnotations;

namespace Arteon.Application.DTO
{
    public class ServiceDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        [Range(0, double.MaxValue)]
        public double PricePerDay { get; set; }
    }
}
