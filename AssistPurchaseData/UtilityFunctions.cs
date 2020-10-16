using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace AssistPurchaseData
{
    public class UtilityFunctions
    {
        public readonly List<MonitoringDevice> _monitoringDevices = new List<MonitoringDevice>();
        private readonly List<MonitoringDevice> _deserializedMonitoringDevices = new List<MonitoringDevice>();

        // Give path of data.xml
        private readonly string _path =
            @"D:\a\assist-purchase-s21b8\assist-purchase-s21b8\data.xml";

        //public UtilityFunctions()
        //{
        //    PopulateExistingDevices();
        //    WriteToXml();
        //}

        public void AddDevice(MonitoringDevice newMonitoringDevice)
        {
            /* When a new device is to be added, it is first appended to the list and then the list is written to data.XML*/

            _monitoringDevices.Add(newMonitoringDevice);
            WriteToXml();
        }

        public void RemoveDevice(string deviceName)
        {
            foreach (var device in _monitoringDevices)
            {
                if (device.DeviceName == deviceName)
                {
                    //delete from list
                }
            }

            WriteToXml();
        }

        public MonitoringDevice ReadDevice(string deviceName)
        {
            // Read from the file
            var deviceList = ReadFromXml();
            MonitoringDevice foundDevice = new MonitoringDevice();

            foreach (var device in deviceList)
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
            return ReadFromXml();
        }

        public void WriteToXml()
        {

            var serializer = new XmlSerializer(_monitoringDevices.GetType(), new XmlRootAttribute("DeviceList"));

            var writer = new StreamWriter(_path);
            serializer.Serialize(writer.BaseStream, _monitoringDevices);
            writer.Close();

        }

        public List<MonitoringDevice> ReadFromXml()
        {
            var serializer = new XmlSerializer(_monitoringDevices.GetType(), new XmlRootAttribute("DeviceList"));

            if (File.Exists(_path))
            {
                StreamReader reader = new StreamReader(_path);
                List<MonitoringDevice> devices = (List<MonitoringDevice>)serializer.Deserialize(reader);
                reader.Close();

                foreach (var device in devices)
                {
                    _deserializedMonitoringDevices.Add(device);
                }
            }
            else
            {
                Console.WriteLine("File not found.");
                //var doc = new XDocument(new XElement("Use-Cases"));
                //doc.Save(path);
            }
            return _deserializedMonitoringDevices;
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
