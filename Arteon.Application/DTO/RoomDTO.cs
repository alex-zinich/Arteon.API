using Arteon.Core.Common.Enums;

namespace Arteon.Application.DTO
{
    public class RoomDTO
    {
        public Guid Id { get; set; }
        public RoomType Type { get; set; }
        public int CountOfPerson { get; set; }
        public DateTime? LockStart { get; set; }
        public DateTime? LockEnd { get; set; }
    }
}
