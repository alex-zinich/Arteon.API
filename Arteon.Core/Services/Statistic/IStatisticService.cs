using Arteon.Core.Models;

namespace Arteon.Core.Services
{
    public interface IStatisticService
    {
        public BookingReport GenerateReport(ClientStatisticFilter parameters);
    }
}
