using System.Collections.Generic;
using AssistPurchaseData;

namespace Services
{
    public interface IFilter
    {

        List<MonitoringDevice> GetCardiacType();
        List<MonitoringDevice> GetPneumoniaType();
        List<MonitoringDevice> GetCovid19Type();
        List<MonitoringDevice> GetHighBpType();
        List<MonitoringDevice> GetNumberofMeasurmentParams(string value);
        List<MonitoringDevice> GetBatteryLifeType(string value);
        List<MonitoringDevice> GetMobileorStaticType(string value);
        List<MonitoringDevice> GetAdvancedFeaturesType();
        List<MonitoringDevice> GetDisplay(string value);
        List<MonitoringDevice> GetAlaramingType();
    }
}
