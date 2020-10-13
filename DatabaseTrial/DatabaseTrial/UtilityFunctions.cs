using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTrial
{
    public class UtilityFunctions
    {
        public List<MonitoringDevice> monitoringDevices = new List<MonitoringDevice>();
        public void AddDevice(MonitoringDevice newMonitoringDevice)
        {
            monitoringDevices.Add(newMonitoringDevice);
        }
        public void RemoveDevice(string DeviceName)
        {
            foreach(var device in monitoringDevices)
            {
                if(device.DeviceName == DeviceName)
                {
                    //delete from list
                }
            }
        }
        public MonitoringDevice ReadDevice(string DeviceName)
        {
            MonitoringDevice foundDevice = new MonitoringDevice();
            foreach (var device in monitoringDevices)
            {
                if (device.DeviceName == DeviceName)
                {
                    foundDevice = device;
                }
            }
            return foundDevice;
            // when calling the function, check if this object is empty, i.e the object wasn't found.
        }
    }
}
