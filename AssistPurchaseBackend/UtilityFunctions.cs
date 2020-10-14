using System.Collections.Generic;

namespace AssistPurchaseBackend
{
    public class UtilityFunctions
    {
        private List<MonitoringDevice> monitoringDevices = new List<MonitoringDevice>();
        public UtilityFunctions()
        {
            PopulateExistingDevices();
        }
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
        public List<MonitoringDevice> GetList()
        {
            return monitoringDevices;
        }
        public void PopulateExistingDevices()
        {

            AddDevice(new MonitoringDevice
            {
                DeviceName = "IntelliVue X3",
                Ecg = "YES",
                Spo2 = "YES",
                Respiration = "YES",
                NumberOfMeasurementWaves = "5",
                Hr = "YES",
                PhysiologicalAlarming = "NO",
                BloodPressure = "NO",
                St = "NO",
                Qt = "NO",
                BatteryLife = "5 in",
                SupportedScreenOrientations = "0° / 90° / 180°",
                Size = "249 x 97 x 111 mm",
                MobileOrStatic = "STATIC",
                AntiMicrobialGlass = "YES",
                PatientLocation = "NO"

            });
            AddDevice(new MonitoringDevice
            {
                DeviceName = "IntelliVue MX40",
                Ecg = "YES",
                Spo2 = "YES",
                Respiration = "YES",
                NumberOfMeasurementWaves = "5",
                Hr = "YES",
                PhysiologicalAlarming = "YES",
                BloodPressure = "NO",
                St = "YES",
                Qt = "YES",
                BatteryLife = "9 in",
                SupportedScreenOrientations = "NO",
                Size = "NULL",
                MobileOrStatic = "MOBILE",
                AntiMicrobialGlass = "NO",
                PatientLocation = "YES"

            });
            AddDevice(new MonitoringDevice
            {
                DeviceName = "IntelliVue MX750",
                Ecg = "YES",
                Spo2 = "YES",
                Hr = "YES",
                Respiration = "YES",
                MobileOrStatic = "STATIC",
                Size = "9 in",
                NumberOfMeasurementWaves = "12",
                PhysiologicalAlarming = "YES",
                BloodPressure = "YES",
                St = "NO",
                Qt = "NO",
                BatteryLife = "5",
                SupportedScreenOrientations = "NO",
                AntiMicrobialGlass = "NO",
                PatientLocation = "NO"

            });
            AddDevice(new MonitoringDevice
            {
                DeviceName = "IntelliVue MP2",
                Ecg = "YES",
                Spo2 = "YES",
                Hr = "NO",
                Respiration = "NO",
                MobileOrStatic = "MOBILE",
                Size = "NULL",
                NumberOfMeasurementWaves = "NULL",
                PhysiologicalAlarming = "NO",
                BloodPressure = "NO",
                St = "NO",
                Qt = "NO",
                BatteryLife = "6",
                SupportedScreenOrientations = "NO",
                AntiMicrobialGlass = "NO",
                PatientLocation = "NO"

            });
            AddDevice(new MonitoringDevice
            {
                DeviceName = "IntelliVue MP5",
                Ecg = "YES",
                Spo2 = "YES",
                Hr = "NO",
                Respiration = "NO",
                MobileOrStatic = "STATIC",
                Size = "NULL",
                NumberOfMeasurementWaves = "NULL",
                PhysiologicalAlarming = "NO",
                BloodPressure = "NO",
                St = "YES",
                Qt = "NO",
                BatteryLife = "NULL",
                SupportedScreenOrientations = "NO",
                AntiMicrobialGlass = "NO",
                PatientLocation = "NO"

            });
            AddDevice(new MonitoringDevice
            {
                DeviceName = "IntelliVue MX450",
                Ecg = "YES",
                Spo2 = "YES",
                Hr = "NO",
                Respiration = "NO",
                MobileOrStatic = "STATIC",
                Size = "12 in",
                NumberOfMeasurementWaves = "NULL",
                PhysiologicalAlarming = "NO",
                BloodPressure = "NO",
                St = "NO",
                Qt = "NO",
                BatteryLife = "NULL",
                SupportedScreenOrientations = "NO",
                AntiMicrobialGlass = "NO",
                PatientLocation = "NO"

            });
            AddDevice(new MonitoringDevice
            {
                DeviceName = "IntelliVue MX700",
                Ecg = "YES",
                Spo2 = "YES",
                Hr = "NO",
                Respiration = "NO",
                MobileOrStatic = "STATIC",
                Size = "15 in",
                NumberOfMeasurementWaves = "NULL",
                PhysiologicalAlarming = "YES",
                BloodPressure = "NO",
                St = "NO",
                Qt = "NO",
                BatteryLife = "NULL",
                SupportedScreenOrientations = "NO",
                AntiMicrobialGlass = "NO",
                PatientLocation = "NO"

            });
            AddDevice(new MonitoringDevice
            {
                DeviceName = "IntelliVue MMS X2",
                Ecg = "YES",
                Spo2 = "YES",
                Hr = "NO",
                Respiration = "YES",
                MobileOrStatic = "STATIC",
                Size = "3.5 in",
                NumberOfMeasurementWaves = "NULL",
                PhysiologicalAlarming = "NO",
                BloodPressure = "YES",
                St = "YES",
                Qt = "NO",
                BatteryLife = "6",
                SupportedScreenOrientations = "NO",
                AntiMicrobialGlass = "NO",
                PatientLocation = "NO"

            });
            AddDevice(new MonitoringDevice
            {
                DeviceName = "IntelliVue MX500",
                Ecg = "YES",
                Spo2 = "YES",
                Hr = "NO",
                Respiration = "NO",
                MobileOrStatic = "STATIC",
                Size = "12 in",
                NumberOfMeasurementWaves = "NULL",
                PhysiologicalAlarming = "NO",
                BloodPressure = "NO",
                St = "NO",
                Qt = "NO",
                BatteryLife = "NULL",
                SupportedScreenOrientations = "NO",
                AntiMicrobialGlass = "NO",
                PatientLocation = "NO"

            });
            AddDevice(new MonitoringDevice
            {
                DeviceName = "IntelliVue MX400",
                Ecg = "YES",
                Spo2 = "YES",
                Hr = "YES",
                Respiration = "YES",
                MobileOrStatic = "MOBILE",
                Size = "9 in",
                NumberOfMeasurementWaves = "0",
                PhysiologicalAlarming = "NO",
                BloodPressure = "YES",
                St = "YES",
                Qt = "YES",
                BatteryLife = "5",
                SupportedScreenOrientations = "NO",
                AntiMicrobialGlass = "NO",
                PatientLocation = "YES"

            });
            AddDevice(new MonitoringDevice
            {
                DeviceName = "IntelliVue MX550",
                Ecg = "YES",
                Spo2 = "YES",
                Hr = "YES",
                Respiration = "YES",
                MobileOrStatic = "MOBILE",
                Size = "15 in",
                NumberOfMeasurementWaves = "5",
                PhysiologicalAlarming = "NO",
                BloodPressure = "YES",
                St = "YES",
                Qt = "YES",
                BatteryLife = "6",
                SupportedScreenOrientations = "NO",
                AntiMicrobialGlass = "NO",
                PatientLocation = "NO"

            });
            AddDevice(new MonitoringDevice
            {
                DeviceName = "IntelliVue MP90",
                Ecg = "YES",
                Spo2 = "YES",
                Hr = "YES",
                St = "YES",
                Qt = "YES",
                Respiration = "YES",
                MobileOrStatic = "MOBILE",
                Size = "15 in",
                NumberOfMeasurementWaves = "13",
                PhysiologicalAlarming = "NO",
                BloodPressure = "NO",
                BatteryLife = "8",
                SupportedScreenOrientations = "NO",
                AntiMicrobialGlass = "NO",
                PatientLocation = "NO"

            });
            AddDevice(new MonitoringDevice
            {
                DeviceName = "IntelliVue MX800",
                Ecg = "YES",
                Spo2 = "YES",
                Hr = "YES",
                St = "YES",
                Qt = "YES",
                Respiration = "YES",
                MobileOrStatic = "STATIC",
                Size = "13 in",
                NumberOfMeasurementWaves = "5",
                PhysiologicalAlarming = "NO",
                BloodPressure = "YES",
                BatteryLife = "8",
                SupportedScreenOrientations = "NO",
                AntiMicrobialGlass = "NO",
                PatientLocation = "NO"

            });
            AddDevice(new MonitoringDevice
            {
                DeviceName = "IntelliVue MP5T",
                Ecg = "YES",
                Spo2 = "YES",
                Hr = "YES",
                St = "YES",
                Qt = "YES",
                Respiration = "YES",
                MobileOrStatic = "STATIC",
                Size = "8.4 in",
                NumberOfMeasurementWaves = "5",
                PhysiologicalAlarming = "NO",
                BloodPressure = "YES",
                BatteryLife = "8",
                SupportedScreenOrientations = "NO",
                AntiMicrobialGlass = "NO",
                PatientLocation = "NO"

            });
            AddDevice(new MonitoringDevice
            {
                DeviceName = "IntelliVue MX100",
                Ecg = "YES",
                Spo2 = "YES",
                Hr = "YES",
                St = "YES",
                Qt = "YES",
                Respiration = "YES",
                MobileOrStatic = "MOBILE",
                Size = "6.1 in",
                NumberOfMeasurementWaves = "5",
                PhysiologicalAlarming = "NO",
                BloodPressure = "YES",
                BatteryLife = "5",
                SupportedScreenOrientations = "0° / 90° / 180°",
                AntiMicrobialGlass = "YES",
                PatientLocation = "NO"

            });
            AddDevice(new MonitoringDevice
            {
                DeviceName = "Efficia CM Series",
                Ecg = "YES",
                Spo2 = "YES",
                Hr = "YES",
                St = "YES",
                Qt = "YES",
                Respiration = "YES",
                MobileOrStatic = "MOBILE",
                Size = "10.1 in",
                NumberOfMeasurementWaves = "5",
                PhysiologicalAlarming = "NO",
                BloodPressure = "YES",
                BatteryLife = "5",
                SupportedScreenOrientations = "0° / 90° / 180°",
                AntiMicrobialGlass = "YES",
                PatientLocation = "NO"

            });
            AddDevice(new MonitoringDevice
            {
                DeviceName = "Goldway G40E G40E",
                Ecg = "YES",
                Spo2 = "YES",
                Hr = "YES",
                St = "YES",
                Qt = "YES",
                Respiration = "YES",
                MobileOrStatic = "STATIC",
                Size = "12.1 in",
                NumberOfMeasurementWaves = "5",
                PhysiologicalAlarming = "NO",
                BloodPressure = "NO",
                BatteryLife = "5",
                SupportedScreenOrientations = "NO",
                AntiMicrobialGlass = "YES",
                PatientLocation = "NO"

            });
        }
    }
}
