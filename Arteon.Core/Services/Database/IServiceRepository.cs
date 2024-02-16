using Arteon.Core.Entities;

namespace Arteon.Core.Services.Database
{
    public interface IServiceRepository
    {
        IEnumerable<Service> GetAll();
    }
}
