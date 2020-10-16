using System.Collections.Generic;
using AssistPurchaseData;

namespace AssistPurchaseBackend.Services
{
    public interface IFilter
    {

        List<MonitoringDevice> Filter(string value);
        
    }
}
