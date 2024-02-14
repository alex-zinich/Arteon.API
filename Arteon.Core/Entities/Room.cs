using Arteon.Core.Common.Enums;

namespace Arteon.Core.Entities
{
    public class Room : BaseEntity
    {
        public Room(RoomType type, int countOfPerson, DateTime? lockStart, DateTime? lockEnd, Guid? id = null)
        {
            Type = type;
            CountOfPerson = countOfPerson;
            LockStart = lockStart;
            LockEnd = lockEnd;
            Id = id ?? Guid.Empty;
        }

        private Room() { }

        public RoomType Type { get; private set; }
        public int CountOfPerson { get; private set; }
        public DateTime? LockStart { get; private set; }
        public DateTime? LockEnd { get; private set; }
        public bool IsLocked => LockStart.HasValue && LockEnd.HasValue;
    }
}
