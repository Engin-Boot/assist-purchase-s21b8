using System.Collections.Generic;
using AssistPurchaseData;

namespace AssistPurchaseBackend.Services
{
    public interface IFilter
    {

        List<MonitoringDevice> Cardiac();
        List<MonitoringDevice> Pneumonia();
        List<MonitoringDevice> Covid19();
        List<MonitoringDevice> HighBP();
        List<MonitoringDevice> NumberofMeasurmentParams(string value);
        List<MonitoringDevice> BatteryLife(string value);
        List<MonitoringDevice> MobileorStatic(string value);
        List<MonitoringDevice> AdvancedFeatures();
        List<MonitoringDevice> Display(string value);
    }
}
