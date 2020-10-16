using System.Collections.Generic;
using System.Runtime.InteropServices;
using AssistPurchaseData;

namespace AssistPurchaseBackend.Services
{
    public class FilterDeviceName : IFilter
    {
        private UtilityFunctions _utilityFunctions;
        private List<MonitoringDevice> _filteredList;
        private List<MonitoringDevice> _monitoringDevices;
        
        public List<MonitoringDevice> Cardiac()
        {
            _filteredList = new List<MonitoringDevice>();
            _utilityFunctions = new UtilityFunctions();
            _monitoringDevices = _utilityFunctions.GetList();

            foreach (var device in _monitoringDevices)
            {
                if (device.Ecg=="YES"&&device.Hr=="YES")
                    _filteredList.Add(device);
            }
            return _filteredList;

        }
        public List<MonitoringDevice> Pneumonia()
        {
            _filteredList = new List<MonitoringDevice>();
            _utilityFunctions = new UtilityFunctions();
            _monitoringDevices = _utilityFunctions.GetList();

            foreach (var device in _monitoringDevices)
            {
                if (device.Respiration == "YES" && device.Spo2 == "YES")
                    _filteredList.Add(device);
            }
            return _filteredList;

        }
        public List<MonitoringDevice> Covid19()
        {
            _filteredList = new List<MonitoringDevice>();
            _utilityFunctions = new UtilityFunctions();
            _monitoringDevices = _utilityFunctions.GetList();

            foreach (var device in _monitoringDevices)
            {
                if (device.Respiration == "YES" && device.BloodPressure== "YES"&& device.St=="YES")
                    _filteredList.Add(device);
            }
            return _filteredList;

        }
        public List<MonitoringDevice> HighBP()
        {
            _filteredList = new List<MonitoringDevice>();
            _utilityFunctions = new UtilityFunctions();
            _monitoringDevices = _utilityFunctions.GetList();

            foreach (var device in _monitoringDevices)
            {
                if (device.BloodPressure == "YES")
                    _filteredList.Add(device);
            }
            return _filteredList;

        }

        public List<MonitoringDevice> NumberofMeasurmentParams(string value)
        {
            _filteredList = new List<MonitoringDevice>();
            _utilityFunctions = new UtilityFunctions();
            _monitoringDevices = _utilityFunctions.GetList();

            foreach (var device in _monitoringDevices)
            {
                if (device.NumberOfMeasurementWaves == value)
                    _filteredList.Add(device);
            }
            return _filteredList;
        }
        public List<MonitoringDevice> BatteryLife(string value)
        {
            _filteredList = new List<MonitoringDevice>();
            _utilityFunctions = new UtilityFunctions();
            _monitoringDevices = _utilityFunctions.GetList();

            foreach (var device in _monitoringDevices)
            {
                if (device.BatteryLife == value)
                    _filteredList.Add(device);
            }
            return _filteredList;
        }
        public List<MonitoringDevice> MobileorStatic(string value)
        {
            _filteredList = new List<MonitoringDevice>();
            _utilityFunctions = new UtilityFunctions();
            _monitoringDevices = _utilityFunctions.GetList();

            foreach (var device in _monitoringDevices)
            {
                if (device.MobileOrStatic == value)
                    _filteredList.Add(device);
            }
            return _filteredList;
        }
        public List<MonitoringDevice> AdvancedFeatures()
        {
            _filteredList = new List<MonitoringDevice>();
            _utilityFunctions = new UtilityFunctions();
            _monitoringDevices = _utilityFunctions.GetList();

            foreach (var device in _monitoringDevices)
            {
                if (device.PatientLocation=="YES"||device.PhysiologicalAlarming=="YES"||device.Qt=="YES")
                    _filteredList.Add(device);
            }
            return _filteredList;
        }
        public List<MonitoringDevice> Display(string value)
        {
            _filteredList = new List<MonitoringDevice>();
            _utilityFunctions = new UtilityFunctions();
            _monitoringDevices = _utilityFunctions.GetList();

            foreach (var device in _monitoringDevices)
            {
                if (device.Size == value || device.SupportedScreenOrientations == "YES" || device.AntiMicrobialGlass== "YES")
                    _filteredList.Add(device);
            }
            return _filteredList;
        }


    }
}
