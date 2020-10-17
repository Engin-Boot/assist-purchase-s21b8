using System.Collections.Generic;
using System.Linq;
using AssistPurchaseData;
using Xunit;

namespace FunctionsLogic.Tests
{
    public class UtilityFunctionsTests
    {
        private UtilityFunctions _utility = new UtilityFunctions();
        private MonitoringDevice _dummDevice = new MonitoringDevice()
        {
            DeviceName = "IntelliVue v3",
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
        };



        [Fact]
        public void AddDevice_ShouldAddNewDevice()
        {
            _utility.AddDevice(_dummDevice);
            List<MonitoringDevice> deviceList = _utility.MonitoringDevices;
            int indexOfLastDevice = deviceList.Count() - 1;
            Assert.True(deviceList[indexOfLastDevice].DeviceName == _dummDevice.DeviceName);
        }

        [Fact]
        public void ReadDevice_ShouldReadADeviceWhenDeviceNameIsGiven()
        {
            _utility.AddDevice(_dummDevice);
            MonitoringDevice foundDevice = _utility.ReadDevice("IntelliVue v3");
            Assert.True(foundDevice.DeviceName == _dummDevice.DeviceName);
        }

        [Fact]
        public void GetList_ShouldReturnListOfAllDevices()
        {
            _utility.AddDevice(_dummDevice);
            var allDeviceList = _utility.GetList();
            Assert.True(allDeviceList.Count == 1);
        }

        [Fact]
        public void ReadFromXml_ShouldReadFromXmlFileAndReturnAListOfObjects()
        {
            _utility.AddDevice(_dummDevice);
            List<MonitoringDevice> deviceList = _utility.ReadFromXml();
            Assert.True(deviceList.Count > 0);
        }

        [Fact]
        public void WriteToXml_ShouldWriteListOfDevicesToFile()
        {
            _utility.AddDevice(_dummDevice);
            _utility.WriteToXml();
            var deviceList = _utility.ReadFromXml();
            Assert.True(deviceList.Count == 1);
        }


    }
}
