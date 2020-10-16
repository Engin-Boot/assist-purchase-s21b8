using System.Collections.Generic;
using AssistPurchaseData;

namespace AssistPurchaseBackend.Services
{
    public class FilterDeviceName : IFilter
    {
        private UtilityFunctions _utilityFunctions;
        private List<MonitoringDevice> _filteredList;
        private List<MonitoringDevice> _monitoringDevices;
        public List<MonitoringDevice> Filter(string value)
        {
            _filteredList = new List<MonitoringDevice>();
            _utilityFunctions = new UtilityFunctions();
            _monitoringDevices = _utilityFunctions.GetList();

            foreach (var device in _monitoringDevices)
            {
                if (device.DeviceName.Equals(value))
                    _filteredList.Add(device);
            }
            return _filteredList;

        }

    }
}
