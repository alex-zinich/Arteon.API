using Arteon.Core.Entities;
using Arteon.Core.Models;

namespace Arteon.Core.Services
{
    public interface IRoomService
    {
        public IEnumerable<Room> Filter(RoomFilterParameters parameters);
    }
}
