namespace Arteon.Application.Models
{
    public class RoomFilterParametersDTO
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? CountOfPerson { get; set; }
        public int? RoomType { get; set; }
    }
}
