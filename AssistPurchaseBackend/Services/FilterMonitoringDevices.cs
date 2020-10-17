using System.Collections.Generic;
using AssistPurchaseData;
namespace AssistPurchaseBackend.Services
{
    public class FilterMonitoringDevices : IFilter
    {
        private UtilityFunctions _utilityFunctions;
        private List<MonitoringDevice> _filteredList;
        private List<MonitoringDevice> _monitoringDevices;
  
        public List<MonitoringDevice> GetCardiacType()
        {
            _filteredList = new List<MonitoringDevice>();
            _utilityFunctions = new UtilityFunctions();
            _monitoringDevices = _utilityFunctions.GetList();

            foreach (var device in _monitoringDevices)
            {
                if (device.Ecg == "YES" && device.Hr == "YES")
                    _filteredList.Add(device);
            }
            return _filteredList;

        }

        public List<MonitoringDevice> GetPneumoniaType()
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

        public List<MonitoringDevice> GetCovid19Type()
        {
            _filteredList = new List<MonitoringDevice>();
            _utilityFunctions = new UtilityFunctions();
            _monitoringDevices = _utilityFunctions.GetList();

            foreach (var device in _monitoringDevices)
            {
                if (device.Respiration == "YES" && device.BloodPressure == "YES")
                    _filteredList.Add(device);
            }
            return _filteredList;
        }

        public List<MonitoringDevice> GetHighBPType()
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

        public List<MonitoringDevice> GetNumberofMeasurmentParams(string value)
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

        public List<MonitoringDevice> GetBatteryLifeType(string value)
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

        public List<MonitoringDevice> GetMobileorStaticType(string value)
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

        public List<MonitoringDevice> GetAdvancedFeaturesType()
        {
            _filteredList = new List<MonitoringDevice>();
            _utilityFunctions = new UtilityFunctions();
            _monitoringDevices = _utilityFunctions.GetList();

            foreach (var device in _monitoringDevices)
            {
                if (device.PatientLocation == "YES" && device.AntiMicrobialGlass == "YES")
                    _filteredList.Add(device);
            }
            return _filteredList;
        }

        public List<MonitoringDevice> GetDisplay(string value)
        {
            _filteredList = new List<MonitoringDevice>();
            _utilityFunctions = new UtilityFunctions();
            _monitoringDevices = _utilityFunctions.GetList();

            foreach (var device in _monitoringDevices)
            {
                if (device.Size == value || device.SupportedScreenOrientations == "YES")
                    _filteredList.Add(device);
            }
            return _filteredList;
        }

        public List<MonitoringDevice> GetAlaramingType()
        {
            _filteredList = new List<MonitoringDevice>();
            _utilityFunctions = new UtilityFunctions();
            _monitoringDevices = _utilityFunctions.GetList();

            foreach (var device in _monitoringDevices)
            {
                if (device.PhysiologicalAlarming == "YES")
                    _filteredList.Add(device);
            }
            return _filteredList;
        }
    }
}
