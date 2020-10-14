using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssistPurchaseBackend.Services
{
    public interface IFilter
    {

        List<MonitoringDevice> Filter(string value);
    }
}
