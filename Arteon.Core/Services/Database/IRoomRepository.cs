using Arteon.Core.Entities;

namespace Arteon.Core.Services.Database
{
    public interface IRoomRepository
    {
        IEnumerable<Room> GetRooms();
    }
}
