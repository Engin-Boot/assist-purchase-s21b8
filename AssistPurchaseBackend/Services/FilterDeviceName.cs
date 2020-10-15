using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssistPurchaseBackend.Services
{
    public class FilterDeviceName : IFilter
    {
        private UtilityFunctions utilityFunctions = new UtilityFunctions();
        List<MonitoringDevice> FilteredList = new List<MonitoringDevice>();
        public List<MonitoringDevice> Filter(string value,string value1)
        {
            List<MonitoringDevice> monitoringDevices = utilityFunctions.GetList();
            foreach (var device in monitoringDevices)
            {
                if (device.DeviceName.Equals(value)&& device.BatteryLife.Equals(value1))
                    FilteredList.Add(device);

            }
            return FilteredList;

        }
        public List<MonitoringDevice> Filter1(string value)
        {
            List<MonitoringDevice> monitoringDevices = utilityFunctions.GetList();
            foreach (var device in monitoringDevices)
            {
                if (device.BatteryLife.Equals(value))
                    FilteredList.Add(device);

            }
            return FilteredList;

        }
    }
}
