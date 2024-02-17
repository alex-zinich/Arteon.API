using Arteon.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arteon.Core.Services
{
    public interface IStatisticService
    {
        public IEnumerable<ClientStatistic> GetBookingStatistic(ClientStatisticFilter parameters);
    }
}
