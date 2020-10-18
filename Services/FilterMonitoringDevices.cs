using System.Collections.Generic;
using AssistPurchaseData;
namespace Services
{
    public class FilterMonitoringDevices : IFilter
    {
        private UtilityFunctions _utilityFunctions;
        private List<MonitoringDevice> _filteredList;
        private List<MonitoringDevice> _monitoringDevices;

        #region Returns Devices of Cardiac Type
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
        #endregion

        #region Returns Devices of Pneumonia Type
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

        #endregion

        #region Gets Covid19 Type devices
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
        #endregion

        #region Returns Devices of HighBP type
        public List<MonitoringDevice> GetHighBpType()
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


        #endregion

        #region Returns Devices of with given number of measurement waves
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


        #endregion


        #region Returns devices with a specified battery life

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

        #endregion

        #region Returns devices based on whether they are Mobile or static

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

        #endregion

        #region Returns devices having advanced features
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


        #endregion


        #region Returns devices with the given display size

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

        #endregion

        #region Returns devices that have the capability of alarming
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
        #endregion

    }
}
