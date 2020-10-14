using System.Collections.Generic;

namespace AssistPurchaseBackend
{
    public class UtilityFunctions
    {
        private List<MonitoringDevice> monitoringDevices = new List<MonitoringDevice>();
        public void AddDevice(MonitoringDevice newMonitoringDevice)
        {
            monitoringDevices.Add(newMonitoringDevice);
        }
        public void RemoveDevice(string deviceName)
        {
            foreach (var device in monitoringDevices)
            {
                if (device.DeviceName == deviceName)
                {
                    //delete from list
                }
            }
        }
        public MonitoringDevice ReadDevice(string deviceName)
        {
            MonitoringDevice foundDevice = new MonitoringDevice();
            foreach (var device in monitoringDevices)
            {
                if (device.DeviceName == deviceName)
                {
                    foundDevice = device;
                }
            }
            return foundDevice;
            // when calling the function, check if this object is empty, i.e the object wasn't found.
        }
    }
}
